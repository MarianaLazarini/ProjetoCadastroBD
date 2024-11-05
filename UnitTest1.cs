using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Client;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTest
{
    [TestClass]
    public class UnitTest1
    {
        public MySqlConnection GetConnection()
        {
            String C = @"server=127.0.0.1;" +
                "uid=root;" +
                "pwd=Mari040303*;" +
                "Database=academico";
            return new MySqlConnection(C);
        }

        [TestMethod]
        public void Test1Connect()
        {
            var con = GetConnection();
            con.Open();
            Assert.IsTrue(con.State == System.Data.ConnectionState.Open);
        }
    }
}