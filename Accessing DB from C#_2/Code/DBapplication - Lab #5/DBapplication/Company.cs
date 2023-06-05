using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Lab5 : Form
    {
        Controller controllerObj;
        public Lab5()
        {
            InitializeComponent();
        }


        private void Company_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDBLab42EDataSet.Project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.companyDBLab42EDataSet.Project);
            // TODO: This line of code loads data into the 'companyDBLab42EDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.companyDBLab42EDataSet.Department);
            // TODO: This line of code loads data into the 'companyDBLab42EDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.companyDBLab42EDataSet.Employee);

            controllerObj = new Controller();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            controllerObj.TerminateConnection();
            this.Close();
        }

        private void AddPrjBtn_Click(object sender, EventArgs e)
        {
            int result = controllerObj.InsertProject(Decimal.ToInt32(PrjNo.Value), PrjNameTxtBox.Text, prjLocTxtBox.Text, Int32.Parse(LnkDepComboBox.SelectedValue.ToString()));

            if (result == 0)
            {
                MessageBox.Show("The Project insertion failed");
            }
            else
            {
                MessageBox.Show("The project is inserted successfully!");
            }
        }

        private void addDepBtn_Click(object sender, EventArgs e)
        {
            int result2 = controllerObj.InsertEmp(depNameTxtBox.Text, textBox1.Text, Char.Parse(textBox2.Text), Int32.Parse(textBox3.Text), Decimal.ToInt32(DepNumber.Value));

            if (result2 == 0)
            {
                MessageBox.Show("The Employee insertion failed");
            }
            else
            {
                MessageBox.Show("The Employee is added successfully!");
            }
        }

        private void AddDepLocBtn_Click(object sender, EventArgs e)
        {
            int result = controllerObj.InsertWorksIn(Int32.Parse(textBox5.Text), Int32.Parse(DepLocTxtBox.Text), float.Parse(textBox4.Text));

            if (result == 0)
            {
                MessageBox.Show("The WorksOn insertion failed");
            }
            else
            {
                MessageBox.Show("The WorksOn is added successfully!");
            }
        }

        private void getPrjEmpBtn_Click(object sender, EventArgs e)
        {
            
            string dum = textBox6.Text;
            DataTable dumm1 = controllerObj.Selectdepnum(dum);
            
            int trial = Int16.Parse(dumm1.ToString());
            
            DataTable one = controllerObj.final(trial);
            dataGridView.DataSource = one;
            dataGridView.Refresh();
        }

        private void addDepGrpBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void depNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*DataTable one = controllerObj.SelectProjn(textBox6.Text);
            dataGridView.DataSource = one;
            dataGridView.Refresh();
            dataGridView.Update();*/
        }
    }
}
