using Behavioral.TemplateMethod.AbstractDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Behavioral.TemplateMethod.DAO
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public class Products : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select ProductName from Products";
            //OleDbDataAdapter is not a .NET CORE library
            //OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connectionString);

            base.dataSet = new List<string>();
            //dataAdapter.Fill(dataSet, "Products");
        }

        public override void Process()
        {
            Console.WriteLine("Products ---- ");
            base.dataSet.Add("Wtyczka samochodowa");
            base.dataSet.Add("Dezodorant");
            base.dataSet.Add("Zegarek");

            foreach (var row in base.dataSet)
                Console.WriteLine(row);

            Console.WriteLine();
        }
    }
}
