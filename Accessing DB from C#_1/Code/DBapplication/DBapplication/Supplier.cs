using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace DBapplication
{
    public partial class Company_Lab4 : Form
    {
        Controller controllerObj;
        public Company_Lab4()
        {
            InitializeComponent();
            String DB_Connection_String = ConfigurationManager.ConnectionStrings
                ["MyConnectionString"].ConnectionString;
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDBLab4DataSet3.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.companyDBLab4DataSet3.Employee);
            // TODO: This line of code loads data into the 'companyDBLab4DataSet1.Department' table. You can move, or remove it, as needed.
            //this.departmentTableAdapter.Fill(this.companyDBLab4DataSet1.Department);
            controllerObj = new Controller();
        }

    }

}
