using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic.FileIO; //for CSV reader

namespace Sprout_Mortgage_Prog
{
    public partial class MainForm : Form
    {

        string ABS_PATH = @"C:\Users\Jorge\source\repos\Sprout Mortgage Prog";


        public MainForm()
        {
            InitializeComponent();
        }

        private void yearPlanLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            Console.WriteLine("MainForm_Load called");
            
            loadTableOperations(ABS_PATH);

            loadBaseRateComboBox();
            loadYearPlanComboBox();
            loadDaysComboBox();
            loadLtvComboBox();
            loadCreditScoreRangeComboBox();
            loadLAComboBox();
        }

        private void loadBaseRateComboBox()
        {
            Console.WriteLine("loadBaseRateComboBox() called");
            TableOperations.setBaseRateComboBox(this.baseRateComboBox);            
        }

        private void loadCreditScoreRangeComboBox()
        {
            Console.WriteLine("loadCreditScoreRangeComboBox called()");
            TableOperations.setCreditScoreRangeComboBox(this.creditScoreRangeComboBox);
        }

        private void loadYearPlanComboBox()
        {
            Console.WriteLine("loadYearPlanTextBox called");
            TableOperations.setYearPlanComboBox(this.yearPlanComboBox);
        }

        private void loadDaysComboBox()
        {
            Console.WriteLine("loadDaysComboBox called()"); ;
            TableOperations.setDaysComboBox(this.daysComboBox);
        }

        private void loadLtvComboBox()
        {
            Console.WriteLine("loadLtvComboBox called()");
            TableOperations.setLTVRangeComboBox(this.LTVRangeComboBox);
        }

        private void loadLAComboBox()
        {
            Console.WriteLine("loadLAComboBox called()");
            TableOperations.setLoanAmountComboBox(this.loanAmountComboBox);
        }

        private void loadAddOns()
        {
            throw new NotImplementedException();
        }

        private void loadA5Table()
        {
            Console.WriteLine("loadA5Table called");
            string ABS_PATH = @"C:\Users\Jorge\source\repos\Sprout Mortgage Prog\A5 Table.csv";
            string[] DELIMITERS = new string[] { "," };
            using (TextFieldParser csvParser = new TextFieldParser(ABS_PATH))
            {
                //csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(DELIMITERS);
                csvParser.HasFieldsEnclosedInQuotes = false;

                // Skip the row with the column names


                //read first line                
                int currentLine = 0;
                
                while (!csvParser.EndOfData)
                {
                    string[] fields = csvParser.ReadFields();

                    if (currentLine == 0)//first line
                    {
                        int FIVE_ONE_ARM_LOC = 0;
                        int SEVEN_ONE_ARM_LOC = 4;
                        int THIRTY_YEAR_FIXED_LOC = 8;

                        string five_one_arm = fields[FIVE_ONE_ARM_LOC] + "<---TEST!";
                        string seven_one_arm = fields[SEVEN_ONE_ARM_LOC] + "<---TEST2!";
                        string thirty_year_fixed = fields[THIRTY_YEAR_FIXED_LOC] + "<---TEST3!";

                        this.yearPlanComboBox.Items.AddRange(new object[] { five_one_arm, seven_one_arm, thirty_year_fixed });

                                                    
                    }

                    if(currentLine == 1) //second line
                    {
                        
                    }
                    // Read current line fields, pointer moves to the next line.
                    
                    string Name = fields[0];
                    string Address = fields[1];
                }
            }
        }

        //gets the data from a row and column
        //NOTE: - This method should be called
        //      - locations start from 1, not from 0
        //      - each reference to a cell is actually relative to the start row and column
        //        of the data itself (that is: not titles)
        private double getA5Cell(int x, int y)
        {
            if (x <= 2)
                throw new Exception("can't call getA5Cell on this row! because these are strings, not numbers!");

            string ABS_PATH = @"C:\Users\Jorge\source\repos\Sprout Mortgage Prog\A5 Table.csv";
            string[] DELIMITERS = new string[] { "," };
            using (TextFieldParser csvParser = new TextFieldParser(ABS_PATH))
            {
                //csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(DELIMITERS);
                csvParser.HasFieldsEnclosedInQuotes = false;

                // Skip the row with the column names


                //read first line                
                int currentLine = 0;

                while (!csvParser.EndOfData)
                {
                    string[] fields = csvParser.ReadFields();

                    if (currentLine == 0)//first line
                    {
                        int FIVE_ONE_ARM_LOC = 0;
                        int SEVEN_ONE_ARM_LOC = 4;
                        int THIRTY_YEAR_FIXED_LOC = 8;

                        string five_one_arm = fields[FIVE_ONE_ARM_LOC] + "<---TEST!";
                        string seven_one_arm = fields[SEVEN_ONE_ARM_LOC] + "<---TEST2!";
                        string thirty_year_fixed = fields[THIRTY_YEAR_FIXED_LOC] + "<---TEST3!";

                        this.yearPlanComboBox.Items.AddRange(new object[] { five_one_arm, seven_one_arm, thirty_year_fixed });


                    }

                    if (currentLine == 1) //second line
                    {

                    }
                    // Read current line fields, pointer moves to the next line.

                    string Name = fields[0];
                    string Address = fields[1];
                }
            }

            return 1;
        }

        //gets the data from a row and column
        //NOTE: - This method should be called
        //      - locations start from 1, not from 0
        private double getA5Cell(int x, char y)
        {
            return 1;
        }

        private void loadTableOperations(String dirPath)
        {
            TableOperations.loadAllTables(dirPath);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //this.LTVRangeComboBox.ResetText();
        }

        private void Alerts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addOnsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
