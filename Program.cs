using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//data set is collection of data tables that contains relational data in memory in tabular format

//create table , create column and schema, add data rows in Employee table
namespace ADO.NetDataSet
{
    class Program
    {
        static void Main()
        {

            try
            {
                //create Customer table

                DataTable Customer = new DataTable("Customer");

                //creating column and schema
                DataColumn cid = new DataColumn("ID", typeof(Int32));
                Customer.Columns.Add(cid);

                DataColumn cname = new DataColumn("name", typeof(string));
                Customer.Columns.Add(cname);

                DataColumn cemail = new DataColumn("email", typeof(string));
                Customer.Columns.Add(cemail);

                //add data rows in customer table
                Customer.Rows.Add(101, "fima", "f@gmail.com");
                Customer.Rows.Add(202, "gima", "g@gmail.com");


                //add these three columns into the Department table. 

                //first create data table Department
                DataTable Department = new DataTable("Department");

                //create column and schema

                DataColumn did = new DataColumn("ID", typeof(Int32));
                Department.Columns.Add(did);

                DataColumn cuid = new DataColumn("customerid", typeof(Int32));
                Department.Columns.Add(cuid);

                DataColumn Damount = new DataColumn("amount", typeof(Int32));
                Department.Columns.Add(Damount);

                //add data rows in order table
               Department.Rows.Add(1001, 100, 20000);
               Department.Rows.Add(1002, 102, 30000);

                //create dataset object
                DataSet ds = new DataSet();


                //add data tables to dataset
                //create a DataSet object and then add the two data tables (Customers and Orders) into the DataSet
                ds.Tables.Add(Customer);
                ds.Tables.Add(Department);

                //customer table
                Console.WriteLine("customer table data");

                //fetch datatable from data set
                //As we first add the Customers table to DataSet, so the Customer table Index position is 0

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Console.WriteLine(r["ID"] + "," + r["name"] + "," + r["email"]);
                }
                Console.WriteLine();
                Console.WriteLine("now Department table data");
            
                //fetching data table from data Department table
                foreach (DataRow r in ds.Tables["Department"].Rows)
                {
                    Console.WriteLine(r["ID"] + "," + r["customerid"] + "," + r["amount"]);
                }

               
            }
            catch (Exception er)
            {
                Console.WriteLine("not possible" + er);
            }
            Console.ReadLine();


        }
    }
            
}
