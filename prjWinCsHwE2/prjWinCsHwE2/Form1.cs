using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsHwE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtMidTerm.Text = "";
            txtFinal.Text = "";
            txtProject.Text = "";
            txtBirthYear.Text = "";
            lblResult.Text = "";

        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            Single grade1, grade2, grade3, result4;
            double result1, result2, result3,total;
            string name = txtName.Text;
            grade1 = Convert.ToSingle(txtMidTerm.Text);
            grade2 = Convert.ToSingle(txtFinal.Text);
            grade3 = Convert.ToSingle(txtProject.Text);
            result1 = Convert.ToDouble(grade1 * 0.25);
            result2 = Convert.ToDouble(grade2 * 0.4);
            result3 = Convert.ToDouble(grade3 * 0.35);
            result4 = 2022 - Convert.ToInt16(txtBirthYear.Text);
            total = result1+ result2 + result3 ;
            lblResult.Text = "Sir or Miss " + name + "\r\n" + "Born in " + txtBirthYear.Text + " You are " + result4 + " years old "
                + "\r\n" + "Here are the calculations of your grades" + "\r\n"
                + "-Mid Term exam : " + result1 + "\r\n" +
                "-Final exam : " + result2 + "\r\n" +
                "-Projects grades : " + result3 + "\r\n" +
                "-------------------------------" + "\r\n" +
                "Total average : " + total;
        }
    }
}
