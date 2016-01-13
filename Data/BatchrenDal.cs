using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ICG.FrontRetail.Datos.Entidades;

namespace ICG.FrontRetail.Datos.Acceso
{
    public class BatchrenDal
    {
        public List<BatchrenEnt> ReadAll(string cadena, BatchcabEnt ent)
        {
            using (var sqlConnection = new SqlConnection(cadena))
            using (var sqlCommand = sqlConnection.CreateCommand())
            using (var sqlDataReader = sqlCommand.ExecuteReader())
            {
                sqlConnection.Open();
                sqlCommand.CommandText = @"";
                var result = new List<BatchrenEnt>();
                while (sqlDataReader.Read())
                {
                    result.Add(new BatchrenEnt()
                    {
                        Empcod = sqlDataReader["EMPCOD"] as string,
                        Asifch = sqlDataReader["ASIFCH"] as DateTime?,
                        Tasicod = sqlDataReader["TASICOD"] as string,
                        Asinum = sqlDataReader["ASINUM"] as int?,
                        Rennum = sqlDataReader["RENNUM"] as int?,
                        Rensec = sqlDataReader["RENSEC"] as int?,
                        Rubcod = sqlDataReader["RUBCOD"] as string,
                        Rendoh = sqlDataReader["RENDOH"] as int?,
                        Rendsc = sqlDataReader["RENDSC"] as string,
                        Renmpmp = sqlDataReader["RENMPMP"] as double?,
                        Renmpme = sqlDataReader["RENMPME"] as double?,
                        Renele1 = sqlDataReader["RENELE1"] as string,
                        Renele2 = sqlDataReader["RENELE2"] as string,
                        Renele3 = sqlDataReader["RENELE3"] as string,
                        Renele4 = sqlDataReader["RENELE4"] as string,
                        Rentdoccod = sqlDataReader["RENTDOCCOD"] as string,
                        Renfchvto = sqlDataReader["RENFCHVTO"] as DateTime?,
                        Tdoccodafe = sqlDataReader["TDOCCODAFE"] as string,
                        Doccodafe = sqlDataReader["DOCCODAFE"] as string,
                        Venvtoafe = sqlDataReader["VENVTOAFE"] as DateTime?,
                        Renmpmc = sqlDataReader["RENMPMC"] as double?,
                        Renmpmi = sqlDataReader["RENMPMI"] as double?
                    });
                }
                return result;
            }
        }
    }
}
