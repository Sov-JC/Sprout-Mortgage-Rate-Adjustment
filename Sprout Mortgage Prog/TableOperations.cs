using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Sprout_Mortgage_Prog
{
    class TableOperations
    {
        public enum Table
        {
            A5 = 1,
            CSA = 2,
            LA = 3,
            LLA = 4,
        }

        public enum Arm
        {
            Arm5 = 1, // 5/1 ARM
            Arm7 = 2, // 7/1 ARM 
            YearFixed30 = 3, // 30 year fixed
        }

        public const int A5_TABLE_ROWS  = 18;
        public const int A5_TABLE_COLS  = 12;
        public const int CSA_TABLE_ROWS = 12;
        public const int CSA_TABLE_COLS = 10;
        public const int LA_TABLE_ROWS  = 7;
        public const int LA_TABLE_COLS  = 10;
        public const int LLA_TABLE_ROWS = 11;
        public const int LLA_TABLE_COLS = 10;

        public const string A5_TABLE_NAME   = "A5 Table.csv";
        public const string CSA_TABLE_NAME  = "CSA Table.csv";
        public const string LA_TABLE_NAME   = "LA Table.csv";
        public const string LLA_TABLE_NAME  = "LLA Table.csv";

        private static String[,] a5Table = new String[A5_TABLE_ROWS,A5_TABLE_COLS];
        private static String[,] csaTable = new String[CSA_TABLE_ROWS,CSA_TABLE_COLS];
        private static String[,] laTable = new String[LA_TABLE_ROWS,LA_TABLE_COLS];
        private static String[,] llaTable = new String[LLA_TABLE_ROWS,LLA_TABLE_COLS];

        //not yet being used. Make use of them later
        private Boolean A5TableLoaded = false;
        private Boolean CSATableLoaded = false;
        private Boolean LATableLoaded = false;
        private Boolean LLATableLoaded = false;
        

        public static void loadAllTables(String dirPath)
        {
            loadA5Table(dirPath);
            printA5Table();

            loadCSATable(dirPath);
            printCSATable();

            loadLATable(dirPath);
            printLATable();

            loadLLATable(dirPath);
            printLLATable();
        }

        public static void setBaseRateComboBox(ComboBox comboBox) {
            Console.WriteLine("setBaseRateComboBox called");
            
            List<String> rates = new List<String>();
            const int RATES_ROW_START = 2;//row where rates are displayed from top to bottom
                        
            for(int i=RATES_ROW_START; i<A5_TABLE_ROWS; i++)
            {

                //the rates on the row are separated in the table by 4 cells where each column corresponds
                //to a rate in an 5/1, 7/1, or 30 year fixed column.
                const int CELL_DIFFERENCE = 4; 
                for (int j = 0; j < A5_TABLE_COLS; j += CELL_DIFFERENCE)
                {                    
                    String rate = getTableCell(i, j, Table.A5);
                    Console.WriteLine("rate: " + rate);
                    rates.Add(rate);
                }
            }

            String[] ratesSorted = rates.ToArray<String>();
            Array.Sort(ratesSorted);

            comboBox.Items.AddRange(ratesSorted);
        }
        public static void setYearPlanComboBox(ComboBox comboBox)
        {

            //TODO?: Make extraction dynamic??
            Console.WriteLine("loadYearComboBox called");
            const int YEAR_PLAN_ROW = 0;

            const int FIVE_ONE_ARM_COL = 0;
            const int SEVEN_ONE_ARM_COL = 4;
            const int THIRTY_YEAR_FIXED_COL = 8;


            string five_one_arm = a5Table[YEAR_PLAN_ROW, FIVE_ONE_ARM_COL];
            string seven_one_arm = a5Table[YEAR_PLAN_ROW, SEVEN_ONE_ARM_COL];
            string thirty_year_fixed = a5Table[YEAR_PLAN_ROW, THIRTY_YEAR_FIXED_COL];

            comboBox.Items.AddRange(new object[] { five_one_arm, seven_one_arm, thirty_year_fixed });
        }
        public static void setLTVRangeComboBox(ComboBox comboBox)
        {
            Console.WriteLine("setLTVRangeComboBox() called");

            //LTV range can be gather from many tables, let's just pick the LA table
            const int LTV_COL_START = 1; //column were the first LTV range is (0-base)
            const int LTV_COL_END = 9; //column where the last LTV range is (0-base)
            const int LTV_ROW = 0; //row where the LTV ranges lie
            int n = LTV_COL_END - LTV_COL_START + 1;

            String[] ltvValues = new string[n];
            for(int j=0; j<n; j++) {
                ltvValues[j] = laTable[LTV_ROW, (LTV_COL_START + j)];
                pstrl("ltvValues[" + j + "]: " + ltvValues[j]);
            }

            comboBox.Items.AddRange(ltvValues);
        }
        public static void setDaysComboBox(ComboBox comboBox)
        {
            String[] days = new String[] {"15", "30", "45"};
            comboBox.Items.AddRange(days);
        }
        public static void setCreditScoreRangeComboBox(ComboBox comboBox)
        {
            //TODO?: Extract dynamically?
            Console.WriteLine("setCreditScoreRangeComboBox() called");
            
            String[] creditScoreRanges = new String[]
            {
                ">=760",
                "740-759",
                "720-739",
                "700-719",
                "680-699",
                "660-679",
                "640-659",
                "620-639"
            };

            comboBox.Items.AddRange(creditScoreRanges);
        }
        public static void setLoanAmountComboBox(ComboBox comboBox)
        {
            String[] loanAmounts = new string[]
            {
                "Loan Amount < $125000",
                "Loan Amount $125000-$299999",
                "Loan Amount $300000-$749999",
                "Loan Amount $750000 - $2000000",
                "Loan Amount $2000001 - $4000000",
                "Loan Amount $4000001 - $6000000"
            };
            comboBox.Items.AddRange(loanAmounts);
        }
        public static void printA5Table()
        {
            Console.WriteLine("printA5Table() called");
            Console.WriteLine("getLength(0) is: " + a5Table.GetLength(0));
            Console.WriteLine("getLength(1) is: " + a5Table.GetLength(1));
            for (int i=0;i<a5Table.GetLength(0); i++)
            {
                for(int j=0; j<a5Table.GetLength(1); j++)
                {
                    Console.Write("[i="+i+"][j="+j+"] = " + a5Table[i, j]);
                }

                Console.WriteLine("");
            }

        }
        public static void printLATable()
        {
            
            for (int i = 0; i < laTable.GetLength(0); i++)
            {
                for (int j = 0; j < laTable.GetLength(1); j++)
                {
                    Console.Write("[i=" + i + "][j=" + j + "] = " + laTable[i, j]);
                }

                Console.WriteLine("");
            }
        }
        public static void printCSATable()
        {
            Console.WriteLine("printCSATable() called");
            for(int i=0; i<csaTable.GetLength(0); i++)
            {
                for(int j=0; j<csaTable.GetLength(1); j++)
                {
                    Console.Write("[i=" + i + "][j=" + j + "] = " + csaTable[i, j]);
                }
                Console.WriteLine("");
            }
        }
        public static void printLLATable()
        {
            for (int i = 0; i < llaTable.GetLength(0); i++)
            {
                for (int j = 0; j < llaTable.GetLength(1); j++)
                {
                    Console.Write("[i=" + i + "][j=" + j + "] = " + llaTable[i, j]);
                }
                Console.WriteLine("");
            }
        }
        public static void loadA5Table(String dirPath)
        {
            Console.WriteLine("loadA5Table called");
            string[] DELIMITERS = new string[] { "," };
            String filePath = dirPath + @"\" + A5_TABLE_NAME;
            pstrl("filePath: " + filePath);            
            using (TextFieldParser csvParser = new TextFieldParser(filePath))
            {
                //csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(DELIMITERS);
                csvParser.HasFieldsEnclosedInQuotes = false;


                int currentLine = 0;
                while (!csvParser.EndOfData)
                {
                    string[] fields = csvParser.ReadFields();

                    Console.WriteLine(fields == null ? "fields null" : "fields not null");

                    int currentCol = 0;
                    foreach (String str in fields)
                    {
                        if (str == null)
                        {
                            Console.WriteLine("str is null so skipping");
                            continue;
                        }
                        Console.WriteLine(str + ", ");
                        a5Table[currentLine, currentCol++] = str;
                    }

                    currentLine++;

                    Console.WriteLine();

                }
            }
        }
        public static void loadCSATable(String dirPath) {
            Console.WriteLine("loadCSATable() called");
            
            
            String filePath = (dirPath + @"\" + CSA_TABLE_NAME); //add the file name to the dirPath
            
            string[] DELIMITERS = new string[] { "," };
            
            pstrl("filePath: " + filePath);
            
            using (TextFieldParser csvParser = new TextFieldParser(filePath))
            {
                //csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(DELIMITERS);
                csvParser.HasFieldsEnclosedInQuotes = false;
                int currentLine = 0;


                while (!csvParser.EndOfData)
                {
                    pstrl("currentLine:" + currentLine.ToString());

                    string[] fields = csvParser.ReadFields();

                    Console.WriteLine(fields == null ? "fields null" : "fields not null");

                    int currentCol = 0;
                    foreach (String str in fields)
                    {
                        pstrl("current col is " + currentCol.ToString());
                        if (str == null) //this doesn't happen, just remove this later
                        {
                            Console.WriteLine("str is null so skipping");
                            continue;
                        }
                        Console.WriteLine(str + ", ");
                        
                        csaTable[currentLine, currentCol++] = str;
                    }

                    currentLine++;

                    Console.WriteLine();
                }
            }
        }
        public static void loadLATable(String dirPath) {
            Console.WriteLine("loadLATable() called");
            String filePath = (dirPath + @"\" + LA_TABLE_NAME); //add the file name to the dirPath
            string[] DELIMITERS = new string[] { "," };
            pstrl("filePath: " + filePath);
            using (TextFieldParser csvParser = new TextFieldParser(filePath))
            {
                //csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(DELIMITERS);
                csvParser.HasFieldsEnclosedInQuotes = false;


                int currentLine = 0;
                while (!csvParser.EndOfData)
                {
                    string[] fields = csvParser.ReadFields();

                    Console.WriteLine(fields == null ? "fields null" : "fields not null");

                    int currentCol = 0;
                    foreach (String str in fields)
                    {
                        if (str == null)
                        {
                            Console.WriteLine("str is null so skipping");
                            continue;
                        }
                        Console.WriteLine(str + ", ");
                        laTable[currentLine, currentCol++] = str;
                    }

                    currentLine++;

                    Console.WriteLine();

                }
            }
        }
        public static void loadLLATable(String dirPath) {
            Console.WriteLine("loadLLATable() called");
            String filePath = (dirPath + @"\" + LLA_TABLE_NAME); //add the file name to the dirPath
            string[] DELIMITERS = new string[] { "," };
            pstrl("filePath: " + filePath);
            using (TextFieldParser csvParser = new TextFieldParser(filePath))
            {
                //csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(DELIMITERS);
                csvParser.HasFieldsEnclosedInQuotes = false;


                int currentLine = 0;
                while (!csvParser.EndOfData)
                {
                    string[] fields = csvParser.ReadFields();

                    Console.WriteLine(fields == null ? "fields null" : "fields not null");

                    int currentCol = 0;
                    foreach (String str in fields)
                    {
                        if (str == null)
                        {
                            Console.WriteLine("str is null so skipping");
                            continue;
                        }
                        Console.WriteLine(str + ", ");
                        llaTable[currentLine, currentCol++] = str;
                    }

                    currentLine++;

                    Console.WriteLine();

                }
            }
        }
        
        private static String getTableCell(int x, int y, Table table)
        {
            Console.WriteLine("getTableCell called");

            String cell = "";
            if (table == Table.A5)
                cell = a5Table[x, y];
            else if (table == Table.CSA)
                cell = csaTable[x, y];
            else if (table == Table.LA)
                cell = laTable[x, y];
            else if (table == Table.LLA)
                cell = llaTable[x, y];
            else
                throw new Exception("Invalid table enum type");

            Console.WriteLine("Cell is: " + cell);

            return cell;
        }

        public static String getA5AdjustmentRate(string rate, Arm arm)
        {
            const int RATES_ROW_START = 2;//row where rates are displayed from top to bottom
            for (int i=RATES_ROW_START; i<A5_TABLE_ROWS; i++)
            {
                
            }    

            return "";
        }

        

        
        

        private static void pstr(Object o)
        {            
            Console.Write(o.ToString());
        }
        private static void pstrl(Object o)
        {
            Console.WriteLine(o.ToString());
        }

    }
}
