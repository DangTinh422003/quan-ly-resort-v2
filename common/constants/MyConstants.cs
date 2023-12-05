using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.common.constants
{
    internal class MyConstants
    {
        private const string serverName = "localhost";
        private const string uid = "root";
        private const string pwd = "";
        private const string database = "khachsan";
        private string connectionString
            = "server=" + serverName + ";" +
                "uid=" + uid + ";" +
                "pwd=" + pwd + ";" +
                "database=" + database + ";" +
                " convert zero datetime=True";

        public static MyConstants getInstance()
        {
            return new MyConstants();
        }

        public string getConnectionString()
        {
            return this.connectionString;
        }
    }
}
