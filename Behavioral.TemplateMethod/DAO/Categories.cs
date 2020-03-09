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
    public class Categories : DataAccessObject

    {
        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            //OleDbDataAdapter is .NET Lib, non .NET Core
            //var dataAdapter = new OleDbDataAdapter(sql, connectionString);
            base.dataSet = new List<String>(); ;
        }

        public override void Process()
        {
            Console.WriteLine("Categories DataSet ---- ");
            base.dataSet.Add("Samochody");
            base.dataSet.Add("Zwierzeta");
            base.dataSet.Add("elektronika");

            foreach (var row in base.dataSet)
                Console.WriteLine(row);

            Console.WriteLine();
        }
    }
}
