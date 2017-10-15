using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CostsManagement
{
    public partial class Form1 : Form
    {
        Dictionary<string, Category> categoryList = new Dictionary<string, Category>();
        Dictionary<string, Account> accountList = new Dictionary<string, Account>();
        Dictionary<string, int> pointList = new Dictionary<string, int>();

        public static StartSettingsForm settingsForm;
        public Form1()
        {
            InitializeComponent();

            Text = "Cost managment v." + Properties.Settings.Default.Version;                  
        }

        void LoadAccounts()
        {
            //Testing variant
            Account acc = new Account();                    //Create new account
            accountList.Add(acc.Name, acc);
            cb_Account.Items.Add(acc.Name);         //Add account in combobox
            cb_Account.Text = acc.Name;
        }

        void LoadCategories()
        {
            Category cost = new Category("Cost", false);     //Create two categories for costs and incomes
            cb_Category.Items.Add(cost.Name);
            cb_Category.Text = cost.Name;
            Category income = new Category("Income", true);
            cb_Category.Items.Add(income.Name);

            categoryList.Add(cost.Name, cost);
            categoryList.Add(income.Name, income);
        }

        void LoadOperations()
        {
            //
            FillTree();
            FillTable();
            FillChart();
        }

        void FillTree()
        {
            //
        }

        void FillTable()
        {
            //
        }

        void FillChart()
        {
            int i;
            foreach (KeyValuePair<string, Category> ctg in categoryList)
            {
                chart_Analysis.Series["SeriesAnalysis"].Points.AddY(0);
                i = chart_Analysis.Series["SeriesAnalysis"].Points.Count - 1;
                chart_Analysis.Series["SeriesAnalysis"].Points[i].LegendText = ctg.Key;
                chart_Analysis.Series["SeriesAnalysis"].Points[i].Label = ctg.Key;
                pointList.Add(ctg.Key, i);
            }
        }

        private void cb_TypeOfDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show or Hide dateTimePickers and formatting date depending from TypeOfDate 
            switch (cb_TypeOfDate.Text)
            {
                case "Day":
                    label_DateFrom.Text = "Date";
                    dtp_DateFrom.Format = DateTimePickerFormat.Long;
                    label_DateTo.Hide();
                    dtp_DateTo.Hide();
                    break;
                case "Week":
                    label_DateFrom.Text = "Date from";
                    dtp_DateFrom.Format = DateTimePickerFormat.Long;
                    label_DateTo.Show();
                    dtp_DateTo.Show();
                    dtp_DateTo.Enabled = false;
                    dtp_DateTo.Value = dtp_DateFrom.Value.AddDays(7);
                    break;
                case "Month":
                    label_DateFrom.Text = "Month";
                    dtp_DateFrom.Format = DateTimePickerFormat.Custom;
                    dtp_DateFrom.CustomFormat = "MMMM yyyy";
                    label_DateTo.Hide();
                    dtp_DateTo.Hide();
                    break;
                case "Year":
                    label_DateFrom.Text = "Year";
                    dtp_DateFrom.Format = DateTimePickerFormat.Custom;
                    dtp_DateFrom.CustomFormat = "yyyy";
                    label_DateTo.Hide();
                    dtp_DateTo.Hide();
                    break;
                case "Other":
                    label_DateFrom.Text = "Date from";
                    dtp_DateFrom.Format = DateTimePickerFormat.Long;
                    label_DateTo.Show();
                    dtp_DateTo.Show();
                    dtp_DateTo.Enabled = true;
                    dtp_DateTo.Value = dtp_DateFrom.Value;
                    break;
            }
        }

        private void tb_Sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Save 3 symbols for coins
            if (tb_Sum.Text.IndexOf(',') != -1)
                tb_Sum.MaxLength = 15;
            else
                tb_Sum.MaxLength = 12;
            
            //Replace "." to "," for convert from string to double
            if (e.KeyChar == '.') 
                e.KeyChar = ',';

            //If cursor position is 0 and first digit 0 then replace 0 for other digit from input, when nothing selected
            if (tb_Sum.Text.Length == 4 && tb_Sum.Text[0] == '0' && tb_Sum.SelectionStart == 0 && tb_Sum.SelectionLength == 0)
                tb_Sum.SelectionLength = 1;

            //Allow digits
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                //Only 2 digits after separator (",")
                if (tb_Sum.Text.IndexOf(',') != -1 && tb_Sum.SelectionStart - tb_Sum.Text.IndexOf(',') > 0)
                    if (tb_Sum.SelectionStart - tb_Sum.Text.IndexOf(',') < 3)
                        tb_Sum.SelectionLength = 1;
                    else
                        e.Handled = true;
            }
            else
                //Allow "," when its not begin of text
                if (tb_Sum.TextLength != 0 && e.KeyChar == ',')
                    //If "," alreary in text then denided input
                    if (tb_Sum.Text.Contains(","))
                    {
                        //If next symbol "," then shift cursor to right
                        if (tb_Sum.SelectionStart == tb_Sum.Text.IndexOf(','))
                            tb_Sum.SelectionStart++;
                        e.Handled = true;
                    }
                    else
                        e.Handled = false;
                else
                    //Allow backspace
                    if (e.KeyChar != (char)8) 
                        e.Handled = true;
        }

        private void tb_Sum_Enter(object sender, EventArgs e)
        {
            //Selecting whole part of sum for changing
            tb_Sum.SelectionStart = 0;
            tb_Sum.SelectionLength = tb_Sum.Text.IndexOf(",");  
        }

        private void tb_Sum_Leave(object sender, EventArgs e)
        {
            //Add coins for money format
            if (tb_Sum.Text.IndexOf(',') == -1)
                tb_Sum.Text += ",00";
            else
                //Fill in "0" after "," for have money format
                while (tb_Sum.Text.Length - tb_Sum.Text.IndexOf(',') < 3)
                {
                    tb_Sum.Text += "0";
                }

            //Add "0" if first symbol is ","
            if (tb_Sum.Text.IndexOf(',') == 0)
                tb_Sum.Text = "0" + tb_Sum.Text;

            //Remove excessive "0"
            while (tb_Sum.Text[0] == '0' && (tb_Sum.Text.IndexOf(',') != 1 || (tb_Sum.Text.IndexOf(',') == -1 && tb_Sum.Text.Length > 1)))
            {
                tb_Sum.Text = tb_Sum.Text.Remove(0, 1);
            }
        }

        private void dtp_DateFrom_ValueChanged(object sender, EventArgs e)
        {
            //Formating date in dateTimePickers for week or arbitrary period
            switch (cb_TypeOfDate.Text)
            {
                case "Week":
                    dtp_DateTo.Value = dtp_DateFrom.Value.AddDays(7);
                    break;
                case "Other":
                    if (dtp_DateTo.Value < dtp_DateFrom.Value)
                        dtp_DateTo.Value = dtp_DateFrom.Value;
                    break;
            }
        }

        private void dtp_DateTo_ValueChanged(object sender, EventArgs e)
        {
            //Checking that DateTo can't be less then DateFrom
            if (dtp_DateTo.Value < dtp_DateFrom.Value)
            {
                MessageBox.Show("\"Date to\" can\'t be less then \"Date from\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_DateTo.Value = dtp_DateFrom.Value;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double sum = Double.Parse(tb_Sum.Text);

            Operation opp = new Operation(dtp_OperationDate.Value, accountList[cb_Account.Text], categoryList[cb_Category.Text], sum);

            UpdateTable(opp, tb_Note.Text);
            UpdateTree(opp);
            UpdateChart(opp);
        }

        void UpdateChart(Operation opp)
        {
            chart_Analysis.Series["SeriesAnalysis"].Points[pointList[opp.OperationType.Name]].YValues[0] += opp.Sum;
            chart_Analysis.Series["SeriesAnalysis"].Points.ResumeUpdates();
        }

        void UpdateTable(Operation opp, string note)
        {
            int rowNum = dgv_History.Rows.Add();
            dgv_History.Rows[rowNum].Cells["Date"].Value = opp.Date.ToString("dd MMMM yyyy");
            dgv_History.Rows[rowNum].Cells["Account"].Value = opp.Account.Name;
            dgv_History.Rows[rowNum].Cells["Category"].Value = opp.OperationType.Name;
            dgv_History.Rows[rowNum].Cells["Sum"].Value = opp.Sum.ToString();
            dgv_History.Rows[rowNum].Cells["Note"].Value = note;
        }

        void UpdateTree(Operation opp)
        {
            string opDate = opp.Date.ToString("dd MMMM yyyy");
            TreeNode parent;
            if (treeHistory.Nodes.Find(opDate, false).Length == 0)
            {
                parent = new TreeNode(opDate);
                parent.Name = opDate;
                treeHistory.Nodes.Add(parent);
            }

            TreeNode child = new TreeNode(tb_Sum.Text + " " + cb_Category.Text);
            child.Name = child.Text;
            if (opp.OperationType.Type)
                child.ForeColor = Color.Green;
            else
                child.ForeColor = Color.Red;
            treeHistory.Nodes[opDate].Nodes.Add(child);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.LaunchTheSettingsWizard.ToString());
            if (Properties.Settings.Default.LaunchTheSettingsWizard)
            {
                settingsForm = new StartSettingsForm();
                settingsForm.ShowDialog();
            }

            LoadAccounts();
            LoadCategories();
            LoadOperations();
        }
    }
}
