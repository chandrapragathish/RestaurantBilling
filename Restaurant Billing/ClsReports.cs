using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace Restaurant_Billing
{
    class ClsReports
    {

        public string Deno = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 0px solid;border-bottom: #7B869A 0px solid;" +
"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt; font-weight: bold; text-overflow: clip; white-space:nowrap;height: 16px; font-style: normal; \"";

        public string LeftTable = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 0px solid;border-bottom: #7B869A 0px solid;" +
"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 7pt; font-weight: normal; text-overflow: clip; white-space:nowrap;height: 16px; font-style: normal; \"";

        public string HeadTable = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 0px solid;border-bottom: #7B869A 0px solid;" +
            "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 7pt;font-weight: normal;height: 22px;font-style: normal; \"";

        public string FooterTable = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 0px solid;border-bottom: #7B869A 0px solid;" +
            "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 7pt;font-weight: bold;height: 16px;font-style: normal; \"";

        public string RightTable = "\"border-right: #7B869A 0px solid; border-top: #7B869A 0px solid;border-left: #7B869A 0px;border-bottom: #7B869A 0px;" +
            "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 7pt;font-weight: normal;height: 16px;font-style: normal; table-layout:fixed;\"";

        public string LeftTableFsize = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 0px solid;border-bottom: #7B869A 0px solid;" +
            "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 7pt;font-weight: normal;height: 16px;font-style: normal;\"";

        public string FooterTableFsize = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 0px solid;border-bottom: #7B869A 0px solid;" +
            "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 7pt;font-weight: bold;height: 16px;font-style: normal;\"";

        public string HeadTableFsize = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 0px solid;border-bottom: #7B869A 0px solid;" +
           "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 7pt;font-weight: normal;height: 16px;font-style: normal;\"";

        public string RightTableFsize = "\"border-right: #7B869A 0px solid; border-top: #7B869A 0px solid;border-left: #7B869A 0px;border-bottom: #7B869A 0px;" +
            "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 7pt;font-weight: normal;height: 16px;font-style: normal;\"";

        public string MainHeading = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt;font-weight: bold;font-style: normal;text-align: center;\"";

        public string CompanyHead = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt;font-weight: bold;font-style: normal;text-align: left;\"";

        public string LeftTableFsize8 = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 1px solid;border-bottom: #7B869A 1px solid;" +
            "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 8pt;font-weight: normal;height: 20px;font-style: normal;\"";

        public string LeftTable1 = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 10pt;font-weight: normal;height: 20px;font-style: normal;\"";

        public string HeadTable1 = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 10pt;font-weight: bold;height: 20px;font-style: normal;\"";

        public string STLeftTable = "\"border-right: #7B869A 0px; border-top: #7B869A 1px solid;border-left: #7B869A 1px solid;border-bottom: #7B869A 1px solid;" +
        "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 8pt;font-weight: normal;height: 18px;font-style: normal;\"";

        public string SLeftTable = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 1px solid;border-bottom: #7B869A 0px solid;" +
        "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 8pt;font-weight: normal;height: 18px;font-style: normal;\"";

        public string Hline = "\"border-right: #7B869A 0px; border-top: #7B869A 1px solid;border-left: #7B869A 0px; border-bottom: #7B869A 1px solid;" +
        "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 10pt;font-weight: normal;height: 20px;font-style: normal;\"";

        public string HeadTableFsize8 = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 1px solid;border-bottom: #7B869A 1px solid;" +
           "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 8pt;font-weight: bold;height: 20px;font-style: normal;\"";

        public string FullBorder = "\"border-right: #7B869A 1px solid ; border-top: #7B869A 1px solid;border-left: #7B869A 1px solid;border-bottom: #7B869A 1px solid;" +
            "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 10pt;font-weight: normal;height: 20px;font-style: normal;\"";

        public string AllBorder = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 0px;border-bottom: #7B869A 0px;" +
            "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 10pt;font-weight: normal;height: 20px;font-style: normal;\"";

        public string HeadTable2 = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 1px solid;border-bottom: #7B869A 1px solid;" +
       "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 8pt;font-weight: normal;height: 18px;font-style: normal;\"";

        public string MainHeading1 = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt;font-weight: bold;font-style: normal;text-align: center;\"";

        public string PageNo = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 8pt;font-weight: normal;font-style: normal;\"";

        public string SubHead = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt;font-weight: bold;font-style: normal;text-align: left;\"";

        public string RSubHead = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt;font-weight: bold;font-style: normal;text-align: right;\"";

        public string Header = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt;font-weight: bold;font-style: normal;text-align: center;\"";

        public string LeftTableFsize8b = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 1px solid;border-bottom: #7B869A 1px solid;" +
            "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 8pt;font-weight: bold;height: 20px;font-style: normal;\"";

        public string SRightTable = "\"border-right: #7B869A 1px solid; border-top: #7B869A 1px solid;border-left: #7B869A 0px;border-bottom: #7B869A 0px;" +
           "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 8pt;font-weight: normal;height: 18px;font-style: normal;\"";

        // For Flash-Raj
        public string FSBLeftTable = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 1px solid;border-bottom: #7B869A 1px solid;background-color:Gainsboro;" +
        "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt;font-weight: bold;height: 18px;font-style: normal;\"";

        public string FSBRightTable = "\"border-right: #7B869A 1px solid; border-top: #7B869A 1px solid;border-left: #7B869A 0px;border-bottom: #7B869A 0px;" +
        "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt;font-weight: normal;height: 18px;font-style: normal;\"";

        public string FSLeftTable = "\"border-right: #7B869A 0px; border-top: #7B869A 0px;border-left: #7B869A 1px solid;border-bottom: #7B869A 1px solid;" +
        "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt;font-weight: normal;height: 18px;font-style: normal;\"";

        public string FSRightTable = "\"border-right: #7B869A 1px solid; border-top: #7B869A 1px solid;border-left: #7B869A 0px;border-bottom: #7B869A 0px;" +
            "font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt;font-weight: normal;height: 18px;font-style: normal;\"";

        public string FMainHeading = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 11pt;font-weight: bold;font-style: normal;text-align: center;\"";

        public string FCompanyHead = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 10pt;font-weight: bold;font-style: normal;text-align: center;\"";

        public string FRSubHead = "\"font-family: Verdana, Arial, Helvetica, sans-serif;font-size: 9pt;font-weight: bold;font-style: normal;text-align: right;\"";
       

        #region "Printing Functions"

        public StringReader stringToPrint;
        Font printFont;
        Font printFont1;

        public string FormatString(string InpStr, int strLen, int strAlign)
        {
            int cstrlen;
            string OutStr = "";
            cstrlen = InpStr.Trim().Length;

            if (cstrlen > strLen)
                return (InpStr.Substring(0, strLen));

            if (strAlign == 1) // align left
            {
                OutStr = InpStr.Trim() + Space(strLen - cstrlen);
            }
            else if (strAlign == 2)
            {
                OutStr = Space(strLen - cstrlen) + InpStr.Trim();
            }
            else if (strAlign == 0)
            {
                double dd = (strLen - cstrlen) / 2;
                if (((strLen - cstrlen) / 2) == System.Math.Round(dd, 0))
                {
                    OutStr = Space((strLen - cstrlen) / 2) + InpStr.Trim() + Space((strLen - cstrlen) / 2);
                }
                else
                {
                    OutStr = Space((strLen - cstrlen) / 2) + InpStr.Trim() + Space(((strLen - cstrlen) / 2) + 1);
                }
            }
            return OutStr;
        }

        public string Repeat(string PrnChar, int PrnLen)
        {
            string OutChar = "";
            for (int i = 0; i < PrnLen; i++)
                OutChar += PrnChar;
            return OutChar;
        }

        public string Space(int n)
        {
            string SSpace = "";
            for (int i = 1; i <= n; i++)
            {
                SSpace += " ";
            }
            return SSpace;
        }


        public void PrintFile(StringBuilder SFileName, string SPrinterName)
        {
            try
            {
                PrintDocument pDoc = new PrintDocument();
                //stringToPrint = new StringBuilder();
                stringToPrint = new StringReader(SFileName.ToString());
                // set font and size here
                //printFont = new Font("Times New Roman", 10);
                printFont = new Font("Courier New", 10, FontStyle.Bold);//10 hemalatha 18JUL18
                // printFont1 = new Font("Courier New", 10, FontStyle.Bold);

                pDoc.PrinterSettings.PrinterName = SPrinterName;
                pDoc.PrintPage += new PrintPageEventHandler(this.PagePrint);

                pDoc.Print();
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                stringToPrint.Close();
            }
        }

        public void PagePrint(object sender, PrintPageEventArgs e)
        {
            float linesPerPage = 0;
            float linePosition = 0;
            int lineCount = 0;
            float leftMargin = 0;
            float topMargin = 0;
            String line = null;

            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            while (lineCount < linesPerPage && ((line = stringToPrint.ReadLine()) != null))
            {

                linePosition = topMargin + (lineCount * printFont.GetHeight(e.Graphics));

                if ("THE MADRAS RESTRO & CAFE" == line.Trim())
                {
                    Font f = new Font("Times New Roman", 12, FontStyle.Bold);
                    e.Graphics.DrawString(line, f, Brushes.Black, leftMargin, linePosition, new StringFormat());

                }
                //else if (Globalvar.billttl == line)//chandru4/10/18
                //{
                //    //Font f = new Font("Courier New", 12, FontStyle.Bold);
                //    Font f = new Font("Courier New", 11, FontStyle.Bold);
                //    e.Graphics.DrawString(line, f, Brushes.Black, leftMargin, linePosition, new StringFormat());
                //}
                //else if (Globalvar.billttl1 == line)//chandru4/10/18
                //{
                //    //Font f = new Font("Courier New", 12, FontStyle.Bold);
                //    Font f = new Font("Courier New", 11, FontStyle.Bold);
                //    e.Graphics.DrawString(line, f, Brushes.Black, leftMargin, linePosition, new StringFormat());
                //}
                //else if (Globalvar.KotName == line)
                //{
                //    //Font f = new Font("Courier New", 12, FontStyle.Bold);
                //    Font f = new Font("Times New Roman", 12, FontStyle.Bold);
                //    e.Graphics.DrawString(line, f, Brushes.Black, leftMargin, linePosition, new StringFormat());
                //}
                //else if (Globalvar.KotNo == line || Globalvar.BillNo == line)
                //{
                //    //Font f = new Font("Courier New", 12, FontStyle.Bold);
                //    Font f = new Font("Times New Roman", 12, FontStyle.Bold);
                //    e.Graphics.DrawString(line, f, Brushes.Black, leftMargin, linePosition, new StringFormat());
                //}
                //else if (Globalvar.Kotprint == line || Globalvar.BillAmt == line)
                //{
                //    //Font f = new Font("Courier New", 12, FontStyle.Bold);
                //    Font f = new Font("Times New Roman", 12, FontStyle.Bold);
                //    e.Graphics.DrawString(line, f, Brushes.Black, leftMargin, linePosition, new StringFormat());
                //}
                //else if (Globalvar.Billline.Trim() == line.Trim())
                //{
                //    //Font f = new Font("Courier New", 10, FontStyle.Bold);
                //    Font f = new Font("Times New Roman", 8, FontStyle.Bold);
                //    e.Graphics.DrawString(line, f, Brushes.Black, leftMargin, linePosition, new StringFormat());
                //}
                else
                {
                    e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, linePosition, new StringFormat());
                }
                lineCount++;
            }

            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        public void PagePrint1(object sender, PrintPageEventArgs e)
        {
            float linesPerPage = 0;
            float linePosition = 0;
            int lineCount = 0;
            float leftMargin = 0;
            float topMargin = 0;
            String line = null;

            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            while (lineCount < linesPerPage && ((line = stringToPrint.ReadLine()) != null))
            {

                linePosition = topMargin + (lineCount * printFont.GetHeight(e.Graphics));
               
                    if (lineCount != 0)
                    {
                        printFont = new Font("Times New Roman", 10, FontStyle.Regular);
                    }
                    else
                    {
                        printFont = new Font("Times New Roman", 15, FontStyle.Bold);
                    }
                }

                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, linePosition, new StringFormat());
                lineCount++;
               
            
            //e.Graphics.DrawString(stringToPrint.ToString(), printFont, Brushes.Black, leftMargin, linePosition, new StringFormat());
            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        public string FormatNumber(decimal InpValue, Int32 TotLen, Int32 DecLen)
        {
            string tempstr, OutStr, decipart = "", fractpart = "";
            Int32 CurrDecLen, CurrFactLen;
            string[] RFields;

            tempstr = InpValue.ToString();
            RFields = tempstr.Split('.');

            if (RFields.Length > 1)  // decimal point here 
            {
                CurrDecLen = RFields[0].Length;
                CurrFactLen = RFields[1].Length;
            }
            else
            {
                CurrDecLen = RFields[0].Length;
                //RFields[1] = "";
                CurrFactLen = 0;
            }


            if (RFields[0].Length < TotLen - DecLen - 1)
                decipart = Space((TotLen - DecLen - 1) - CurrDecLen) + RFields[0].Trim();
            else
                decipart = RFields[0].Trim();

            if (RFields.Length > 1)  // decimal point here 
            {
                if (RFields[1].Length < DecLen)
                    fractpart = RFields[1].Trim() + Repeat("0", (DecLen - CurrFactLen));

                else
                    fractpart = RFields[1].Trim();
            }
            else
                fractpart = Repeat("0", DecLen);

            if (DecLen == 0)
            {
                OutStr = decipart;
            }
            else
            {
                OutStr = decipart + "." + fractpart;
            }

            return OutStr;


        }

        //public string GetPrintName(string OutletID)
        //{
        //    string Qry = "SELECT OUTPRINTERNAME  FROM FBOUTLET WHERE OUTLETID=" + OutletID;
        //   // string PrntNm = cData.GetSingleValue(Qry);
        //    return PrntNm;
        //}

        #endregion



    }
}
