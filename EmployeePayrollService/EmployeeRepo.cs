using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace EmployeePayrollService
{
   public class EmployeeRepo
    {
        public static string connectionString = @"Data Source=(LocalDb)\localdb;Initial Catalog=payroll_service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        EmployeePayroll employeePayroll = new EmployeePayroll();
        public void ConnectionString()
        {
            try
            {
                EmployeePayroll employeePayroll = new EmployeePayroll();
                using (this.connection)
                {
                    string query = @"SELECT id,name,address,Department,Gender,basic_pay,deductions,
                                    taxable_pay,tax,net_pay
                                    From employee_payroll";
                    //Defining the sqlCommand Object
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    //check if there are records
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employeePayroll.id = dr.GetInt32(0);
                            employeePayroll.name = dr.GetString(1);
                            employeePayroll.phone = dr.GetString(2);
                            employeePayroll.address = dr.GetString(3);
                            employeePayroll.Department = dr.GetString(4);
                            employeePayroll.Gender = dr.GetString(5);
                            employeePayroll.basic_pay = dr.GetDecimal(6);
                            employeePayroll.deductions = dr.GetDouble(7);
                            employeePayroll.taxable_pay = dr.GetDouble(8);
                            employeePayroll.tax = dr.GetDouble(9);
                            employeePayroll.net_pay = dr.GetDouble(10);
                            employeePayroll.Start = dr.GetDateTime(11);

                            //Display retrive record
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", employeePayroll.id, employeePayroll.name, employeePayroll.phone, employeePayroll.address, employeePayroll.Department, employeePayroll.Gender, employeePayroll.basic_pay, employeePayroll.deductions, employeePayroll.taxable_pay, employeePayroll.tax, employeePayroll.net_pay, employeePayroll.Start);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Data Found");
                    }
                    //close data reader
                    dr.Close();
                    this.connection.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }

        }
    }
}
