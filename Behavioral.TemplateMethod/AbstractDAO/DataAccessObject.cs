using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Behavioral.TemplateMethod.AbstractDAO
{
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    public abstract class DataAccessObject
    {
        protected string connectionString;
        protected List<string> dataSet;

        public virtual void Connect()
        {
            // Make sure mdb is available to app
            this.connectionString = "provider=Microsoft.JET.OLEDB.4.0; data source=..\\..\\..\\db1.mdb";
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            this.connectionString = String.Empty;
        }

        // The 'Template Method' 
        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
