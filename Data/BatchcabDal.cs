using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ICG.FrontRetail.Datos.Entidades;

namespace ICG.FrontRetail.Datos.Acceso
{
    public class BatchcabDal
    {
        public List<BatchcabEnt> ReadAll(string cadena, DateTime fechaini, DateTime fechafin)
        {
            using (var sqlConnection = new SqlConnection(cadena))
            using (var sqlCommand = sqlConnection.CreateCommand())
            using (var sqlDataReader = sqlCommand.ExecuteReader())
            {
                sqlConnection.Open();
                sqlCommand.CommandText = @"";
                var result = new List<BatchcabEnt>();
                while (sqlDataReader.Read())
                {
                    result.Add(new BatchcabEnt()
                    {
                        Empcod = sqlDataReader["EMPCOD"] as string,
                        Asifch = sqlDataReader["ASIFCH"] as DateTime?,
                        Tasicod = sqlDataReader["TASICOD"] as string,
                        Asinum = sqlDataReader["ASINUM"] as int?,
                        Asidsc = sqlDataReader["ASIDSC"] as string,
                        Asicot = sqlDataReader["ASICOT"] as double?,
                        Asicon = sqlDataReader["ASICON"] as string,
                        Asifching = sqlDataReader["ASIFCHING"] as DateTime?,
                        Asihoring = sqlDataReader["ASIHORING"] as TimeSpan?,
                        Asiusuing = sqlDataReader["ASIUSUING"] as string,
                        Asinumaut = sqlDataReader["ASINUMAUT"] as string,
                        Asiproc = sqlDataReader["ASIPROC"] as string,
                        Asinroren = sqlDataReader["ASINROREN"] as int?
                    });
                }
                return result;
            }
        } 
    }
}
