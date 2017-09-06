using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TimkenTest.Interface;
using TimkenTest.Models;

namespace TimkenTest.Repository
{
    public class TimkenRepo : ITimkenRepo
    {
         private IDbConnection con;
        static string connectionString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        public TimkenRepo()
            : base()
        {
            con = new SqlConnection(connectionString);
        }
        public int AddData(TimkenModel collection)
        {
            var parameterDapper = new DynamicParameters();
            parameterDapper.Add("@JobId", collection.JobId);
            parameterDapper.Add("@DesignationId", collection.DesignationId);
            parameterDapper.Add("@ManagerId", collection.ManagerId);
            parameterDapper.Add("@Name", collection.Name);
            parameterDapper.Add("@StateId", collection.StateId);
            parameterDapper.Add("@CityName", collection.CityName);
            parameterDapper.Add("@JobDescription", collection.JobDescription);
            parameterDapper.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            con.Query<int>("[UserDataInsert]", parameterDapper, commandType: CommandType.StoredProcedure);
            return parameterDapper.Get<int>("Result");
        }
        public IEnumerable<TimkenModel> ListData()
        {
            var x=con.Query<TimkenModel>("[UserGetDataList]", commandType: CommandType.StoredProcedure);
            return x;
        }
    }
}