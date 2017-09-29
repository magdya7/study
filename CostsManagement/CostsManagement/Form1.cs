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
        public Form1()
        {
            InitializeComponent();
            acc = new Account();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category ctg = new Category(operationType.Text, true);
            int sum = Int32.Parse(transactionSum.Text);
            Operation opp = new Operation(acc, ctg, sum);
            history.Items.Add("+"+opp.Sum.ToString()+" "+ctg.Name);
            balance.Text = acc.Balance.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category ctg = new Category(operationType.Text, false);
            int sum = Int32.Parse(transactionSum.Text);
            Operation opp = new Operation(acc, ctg, sum);
            history.Items.Add("-" + opp.Sum.ToString() + " " + ctg.Name);
            balance.Text = acc.Balance.ToString();
        }
    }
}
