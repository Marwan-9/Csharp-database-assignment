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

        public int InsertDepartment(string name, int num, int ssn, DateTime SD)
        {
            string query = "INSERT INTO Department (Dname, Dnumber, Mgr_SSN, Mgr_Start_Date) " +
                            "Values ('" + name + "'," + num + "," + ssn + ",'" + SD + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteProject(int pnum)
        {
            string query = "DELETE FROM Project WHERE Pnumber='" + pnum + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEmployeeSalary(int empSSN, int salary)
        {
            string query = "UPDATE Employee SET Salary='" + salary + "' WHERE SSN='" + empSSN + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateEmployeeDno(int empSSN, int Dno)
        {
            string query = "UPDATE Employee SET Dno='" + Dno + "' WHERE SSN='" + empSSN + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateEmployeeAddress(int empSSN, int Address)
        {
            string query = "UPDATE Employee SET Address='" + Address + "' WHERE SSN='" + empSSN + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateEmployeeSup_SSN(int empSSN, int Sup_SSN)
        {
            string query = "UPDATE Employee SET Super_SSN='" + Sup_SSN + "' WHERE SSN='" + empSSN + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public string SelectManagerName(int depNum)
        {
            string query = "SELECT FName FROM Employee as E, Department as D WHERE Dnumber='" + depNum+ "' AND Mgr_SSN=SSN;";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string SelectAllDno(int depNum)
        {
            string query = "SELECT Dno FROM Department;";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int CountMaleEmp(int pNo)
        {
            string query = "SELECT COUNT(ESSN) FROM Works_On as W, Employee as E WHERE W.Pno='" + pNo + "' AND E.Sex='M' AND E.SSN=W.ESSN;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable SelectSSN()
        {
            string query = "SELECT SSN FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectSalary()
        {
            string query = "SELECT Salary FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllEmp()
        {
            string query = "SELECT * FROM Employee";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllDeps()
        {
            string query = "SELECT * FROM Department";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllProj()
        {
            string query = "SELECT * FROM Project";
            return dbMan.ExecuteReader(query);
        }
    }
}
