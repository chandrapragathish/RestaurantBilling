﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace DataAccess
{
    public class ClsDataAccess
    {
        public string ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public DataTable GetTable(string Qry)   //  Return DataTable for specified Query
        {
            DataTable dDataTable = new DataTable("FillTable");
            MySqlDataAdapter dAdp = new MySqlDataAdapter("SET SESSION TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ;" + Qry + ";  SET SESSION TRANSACTION ISOLATION LEVEL REPEATABLE READ ;", ConnectionString);
            try { dAdp.Fill(dDataTable); }
            catch { }
            finally { dAdp.Dispose(); }
            return dDataTable;
        }
        public DataTable GetTable1(string Qry)   //  Return DataTable for specified Query
        {
            DataTable dDataTable = new DataTable("FillTable");
            MySqlDataAdapter dAdp = new MySqlDataAdapter( Qry , ConnectionString);
            try { dAdp.Fill(dDataTable); }
            catch { }
            finally { dAdp.Dispose(); }
            return dDataTable;
        }
       
        public DataView GetView(string Qry)     //  Return DataView for specified Query
        {
            DataTable dDataTable = new DataTable();
            MySqlDataAdapter dAdp = new MySqlDataAdapter(Qry, ConnectionString);
            try { dAdp.Fill(dDataTable); }
            catch { }
            finally { dAdp.Dispose(); }
            return dDataTable.DefaultView;
        }

        public String GetSingleValue(string Qry)        // Return single value for the query specified
        {
            object objVal = null;
            MySqlConnection tmpCn = new MySqlConnection(ConnectionString);
            try
            {
                tmpCn.Open();
                MySqlCommand cmd = new MySqlCommand(Qry, tmpCn);
                objVal = cmd.ExecuteScalar();
                cmd.Dispose();
            }
            catch { }
            finally { tmpCn.Close(); tmpCn.Dispose(); }
            return (objVal == null) ? "" : objVal.ToString();

        }

        public String GetSingleValue(string Qry, MySqlConnection Connection, MySqlTransaction Transaction)     // Return single value for the query specified with transaction (If we need any value at the time of any transaction, we should read the value from table by specify the same transaction)
        {
            object objVal = null;
            MySqlCommand cmd = new MySqlCommand(Qry, Connection, Transaction);
            try
            {
                objVal = cmd.ExecuteScalar();
            }
            catch { }
            finally { cmd.Dispose(); }
            return objVal.ToString();
        }


        public DataRow GetRow(string Qry)
        {
            MySqlDataAdapter dAdp = new MySqlDataAdapter(Qry, ConnectionString);
            DataTable dTbl = new DataTable();
            try { dAdp.Fill(dTbl); }
            catch { return null; }
            finally { dAdp.Dispose(); }
            if (dTbl.Rows.Count > 0) return dTbl.Rows[0];
            else return null;
        }

        public Boolean SaveData(DataTable DataTbl)      // Save the data to database. Here DataTable's name should be same as the BackEnd Table name
        {
            //if (!HasChanges(DataTbl)) return true;
            MySqlDataAdapter dAdp = new MySqlDataAdapter("Select * From " + DataTbl.TableName + " Where 1 = 2 ", ConnectionString);
            MySqlCommandBuilder cBld = new MySqlCommandBuilder(dAdp);
            int iSave = 0;
            try { iSave = dAdp.Update(DataTbl); DataTbl.AcceptChanges(); }
            catch { }
            finally { dAdp.Dispose(); cBld.Dispose(); }
            return (iSave != 0);
        }

        public Boolean SaveData(DataTable DataTbl, string TableName)        // Save the data to database from datatable to specified Table name. 
        {
            //if (!HasChanges(DataTbl)) return true;
            MySqlDataAdapter dAdp = new MySqlDataAdapter("Select * From " + (string)TableName + " Where 1 = 2 ", ConnectionString);
            MySqlCommandBuilder cBld = new MySqlCommandBuilder(dAdp);
            int iSave = 0;
            try { iSave = dAdp.Update(DataTbl); DataTbl.AcceptChanges(); }
            catch (Exception ex) { }
            finally { dAdp.Dispose(); cBld.Dispose(); }
            return (iSave != 0);
        }

        public Boolean SaveData(DataTable DataTbl, string TableName, MySqlConnection Cn, MySqlTransaction Tran)     // Save the data to database with Transaction. 
        {
            //if (!HasChanges(DataTbl)) return true;
            MySqlDataAdapter dAdp = new MySqlDataAdapter("Select * From " + (string)TableName + " Where 1 = 2", Cn);
            MySqlCommandBuilder cBld = new MySqlCommandBuilder(dAdp);
            dAdp.SelectCommand.Transaction = Tran;
            int iSave = 0;
            try { iSave = dAdp.Update(DataTbl); DataTbl.AcceptChanges(); }
            catch (Exception ex) { }
            finally { dAdp.Dispose(); cBld.Dispose(); }
            return (iSave != 0);
        }

        public Boolean ExecuteQry(string Qry)
        {
            int iSave = 0;
            MySqlConnection tmpCn = new MySqlConnection(ConnectionString);
            try
            {
                tmpCn.Open();
                MySqlCommand cmd = new MySqlCommand(Qry, tmpCn);
                iSave = cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception ex) { return false; }
            finally { tmpCn.Close(); tmpCn.Dispose(); }
            return (iSave != 0);
        }
       


    }
}
