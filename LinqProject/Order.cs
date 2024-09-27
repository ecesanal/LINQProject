using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public List<Order> GetOrders()
        {
            List<Order> liste = new List<Order>();
            string sorgu = @"select o.CustomerID, o.EmployeeID, o.OrderID, o.OrderDate,
                        (Select ContactName
                       from Customers
                       where CustomerID=o.CustomerID) AS ContactName
                       from Orders o";
            DataTable dt = GetDataTable(sorgu);
            foreach (DataRow item in dt.Rows)
            {
                Order o = new Order();
                o.OrderID = (int)item["OrderID"];
                o.CustomerID = (string)item["CustomerID"];
                o.EmployeeID = (int)item["EmployeeID"];
                o.OrderDate = (DateTime)item["OrderDate"];
                o.Customer=new Customer();
                o.Customer.ContactName = item["ContactName"].ToString();
                o.Customer.CustomerID = (string)item["CustomerID"];



                liste.Add(o);
            }
            return liste;
        }

        private DataTable GetDataTable(string sorgu)
        {
            string cs = @"Server=ECE-SANAL;Database=NORTHWND;Integrated Security=True";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, cs);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
    }
    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public List<Order> Orders { get; set; }
        public int OrderCount
        {
            get { return Orders.Count; }
        }
    }
}
