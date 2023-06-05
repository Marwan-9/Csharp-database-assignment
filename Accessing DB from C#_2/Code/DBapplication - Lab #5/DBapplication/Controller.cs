using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public int InsertDep(string dName, int dNumber, int MgrSSN, string MgrStartDate)
        {
            string query = "INSERT INTO DEPARTMENT " +
                            "Values ('" + dName + "'," + dNumber + ",'" + MgrSSN + "','" + MgrStartDate + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertDepLoc(int dNumber, string dLoc)
        {
            string query = "INSERT INTO Dept_Locations " +
                            "Values ('" + dNumber + "','" + dLoc + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertEmp(string fn, string ln, char minit, int ssn, int dno)
        {
            string query = "INSERT INTO Employee (Fname, LName, Minit, SSN, Dno) " +
                            "Values ('" + fn + "','" + ln + "','" + minit + "'," + ssn + ",'" + dno + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertWorksIn(int essn, int Pno, float hours)
        {
            string query = "INSERT INTO Works_On (Essn, Pno, Hours) " +
                            "Values ("+ essn +"," + Pno + "," + hours + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertProject(int pNumber, string pName, string pLocation, int dNumber)
        {
            string query = "INSERT INTO PROJECT " +
                "VALUES ('" + pName + "', '" + pNumber + "','" + pLocation + "','" + dNumber + "');";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable Selectdepnum(String Dname)
        {
            string query = "SELECT Dnumber FROM Department " +
                "WHERE Dnum = '" + Dname + "';";
            return dbMan.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
