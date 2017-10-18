using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using BPO.Core;

namespace CMS.MVC.Controllers
{
    public class DatabaseController : Controller
    {
        public DatabaseController()
        {

        }
        //public class Conn
        //{
        //    public string databaseType { get; set; }
        //    public string host { get; set; }
        //    public string uid { get; set; }
        //    public string pwd { get; set; }
        //}
 

        public AjaxResult Test()
        {
            AjaxResult result = new AjaxResult();
            try
            {
                var databaseNameList = new List<string>();

                var databaseType = Request.Form["databaseType"].FirstOrDefault();
                var host = Request.Form["host"].FirstOrDefault();
                var uid = Request.Form["uid"].FirstOrDefault();
                var pwd = Request.Form["pwd"].FirstOrDefault();
                string connectionString = $"server={host};";
                connectionString += $"uid={uid};pwd={pwd};";
                if (databaseType.Equals("SqlServer", StringComparison.OrdinalIgnoreCase))
                {

                    var connection = new SqlConnection(connectionString);
                    var command = new SqlCommand("select name from master..sysdatabases order by name asc", connection);
                    connection.Open();
                    connection.ChangeDatabase("master");
                    var dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        var dbName = dr["name"] as string;
                        if (dbName == null) continue;
                        if (dbName != "master" &&
                            dbName != "msdb" &&
                            dbName != "tempdb" &&
                            dbName != "model")
                        {
                            databaseNameList.Add(dbName);
                        }
                    }
                    connection.Close();
                }
                else if (databaseType.Equals("MySql", StringComparison.OrdinalIgnoreCase))
                {
                    var connection = new MySqlConnection(connectionString);
                    var command = new MySqlCommand("show databases", connection);
                    connection.Open();
                    var rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        var dbName = rdr.GetString(0);
                        if (dbName == null) continue;
                        if (dbName != "information_schema" &&
                            dbName != "mysql" &&
                            dbName != "performance_schema" &&
                            dbName != "sakila" &&
                            dbName != "sys" &&
                            dbName != "world")
                        {
                            databaseNameList.Add(dbName);
                        }
                    }

                    connection.Close();
                }
                result.data = databaseNameList;
                result.state = ResultType.success;
            }
            catch(Exception ex)
            {
                result.state = ResultType.error;
                result.message = ex.Message;
                Log4NetHelper.Log(LoggerType.LogError, ex.Message, ex);
            }

            return result;
        }
    }
}