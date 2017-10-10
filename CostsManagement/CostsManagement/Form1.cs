using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostsManagement
{
    public partial class Form1 : Form
    {
        Account acc;
        Category cost, income;
        public Form1()
        {
            InitializeComponent();
            LoadAccounts();
            LoadCategories();
            LoadOperations();                   
        }

        void LoadAccounts()
        {
            //Testing variant
            acc = new Account();                    //Create new account
            cb_Account.Items.Add(acc.Name);         //Add account in combobox
            cb_Account.Text = acc.Name;
        }

        void LoadCategories()
        {
            cost = new Category("Cost", false);     //Create two categories for costs and incomes
            cb_Category.Items.Add(cost.Name);
            cb_Category.Text = cost.Name;
            income = new Category("Income", true);
            cb_Category.Items.Add(income.Name);
        }

        void LoadOperations()
        {
            //
            RefreshTree();
            RefreshTable();
            UpdateChart();
        }

        void RefreshTree()
        {
            //
        }

        void RefreshTable()
        {
            //
        }

        void UpdateChart()
        {
            //
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dateTimePicker2.Format = DateTimePickerFormat.Custom || DateTimePickerFormat.Long;
            //dateTimePicker2.CustomFormat = "MMMM yyyy" //"April 2017"
            //dateTimePicker2.CustomFormat = "yyyy" //"2017"
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            double sum = Double.Parse(tb_Sum.Text);
            Operation opp;
            if (cb_Category.Text == cost.Name)
            {
                opp = new Operation(dtp_OperationDate.Value, acc, cost, sum);
            }
            else
            {
                opp = new Operation(dtp_OperationDate.Value, acc, income, sum);
            }

            int rowNum = dgv_History.Rows.Add();

            string opDate;
            opDate = dtp_OperationDate.Value.ToString("dd MMMM yyyy");
            dgv_History.Rows[rowNum].Cells["Date"].Value = opDate;
            dgv_History.Rows[rowNum].Cells["Account"].Value = cb_Account.Text;
            dgv_History.Rows[rowNum].Cells["Category"].Value = cb_Category.Text;
            dgv_History.Rows[rowNum].Cells["Sum"].Value = tb_Sum.Text;
            dgv_History.Rows[rowNum].Cells["Note"].Value = tb_Note.Text;

            TreeNode parent;
            if (treeHistory.Nodes.Find(opDate, false).Length == 0)
            {
                parent = new TreeNode(opDate);
                parent.Name = opDate;
                treeHistory.Nodes.Add(parent);
            }

            TreeNode child = new TreeNode(tb_Sum.Text + " "+cb_Category.Text);
            child.Name = child.Text;
            if(opp.OperationType.Type)
                child.ForeColor = Color.Green;
            else
                child.ForeColor = Color.Red;
            treeHistory.Nodes[opDate].Nodes.Add(child);
        }

    }
}
