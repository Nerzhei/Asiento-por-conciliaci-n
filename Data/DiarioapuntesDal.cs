using System.Data.SqlClient;
using ICG.FrontRetail.Datos.Entidades;
using ICG.Utiles.Extensiones;

namespace ICG.FrontRetail.Datos.Acceso
{
    public class DiarioapuntesDal
    {
        public void Create(string cadena, DiarioapuntesEnt ent)
        {
            using (var sqlConnection = new SqlConnection(cadena))
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                sqlConnection.Open();
#region SQL Query
                sqlCommand.CommandText = @"
IF NOT EXISTS(SELECT [USUARIO] FROM [dbo].[DIARIOAPUNTES] WHERE [USUARIO] = @USUARIO AND [ASIENTO] = @ASIENTO AND [APUNTE] = @APUNTE)
BEGIN
    INSERT INTO [dbo].[DIARIOAPUNTES]
           ([USUARIO]
           ,[ASIENTO]
           ,[APUNTE]
           ,[NIVEL]
           ,[FECHA]
           ,[CUENTA]
           ,[CONCEPTO]
           ,[COMENTARIO]
           ,[SERIEDOCUMENTO]
           ,[NUMERODOCUMENTO]
           ,[DEBE]
           ,[HABER]
           ,[LIBROIVA]
           ,[COSTES]
           ,[PUNTEO]
           ,[RETENCION]
           ,[CENTROCOSTE]
           ,[FACTORMONEDA]
           ,[CODMONEDA]
           ,[EMPRESAGESTION]
           ,[DEBE1]
           ,[HABER1]
           ,[PNORMA43STR]
           ,[ASIENTOVISIBLE]
           ,[CODMONEDADC]
           ,[TIPODOCUMENTO]
           ,[SERIEFISCAL]
           ,[CODTERCERO]
           ,[TERCEROESCLIENTE]
           ,[NUMEROFISCAL])
     VALUES
            (@USUARIO
           ,@ASIENTO
           ,@APUNTE
           ,@NIVEL
           ,@FECHA
           ,@CUENTA
           ,@CONCEPTO
           ,@COMENTARIO
           ,@SERIEDOCUMENTO
           ,@NUMERODOCUMENTO
           ,@DEBE
           ,@HABER
           ,@LIBROIVA
           ,@COSTES
           ,@PUNTEO
           ,@RETENCION
           ,@CENTROCOSTE
           ,@FACTORMONEDA
           ,@CODMONEDA
           ,@EMPRESAGESTION
           ,@DEBE1
           ,@HABER1
           ,@PNORMA43STR
           ,@ASIENTOVISIBLE
           ,@CODMONEDADC
           ,@TIPODOCUMENTO
           ,@SERIEFISCAL
           ,@CODTERCERO
           ,@TERCEROESCLIENTE
           ,@NUMEROFISCAL)
END";
#endregion

                sqlCommand.Parameters.AddWithNullableValue("@USUARIO", ent.Usuario);
                sqlCommand.Parameters.AddWithNullableValue("@ASIENTO", ent.Asiento);
                sqlCommand.Parameters.AddWithNullableValue("@APUNTE", ent.Apunte);
                sqlCommand.Parameters.AddWithNullableValue("@NIVEL", ent.Nivel);
                sqlCommand.Parameters.AddWithNullableValue("@FECHA", ent.Fecha);
                sqlCommand.Parameters.AddWithNullableValue("@CUENTA", ent.Cuenta);
                sqlCommand.Parameters.AddWithNullableValue("@CONCEPTO", ent.Concepto);
                sqlCommand.Parameters.AddWithNullableValue("@COMENTARIO", ent.Comentario);
                sqlCommand.Parameters.AddWithNullableValue("@SERIEDOCUMENTO", ent.Seriedocumento);
                sqlCommand.Parameters.AddWithNullableValue("@NUMERODOCUMENTO", ent.Numerodocumento);
                sqlCommand.Parameters.AddWithNullableValue("@DEBE", ent.Debe);
                sqlCommand.Parameters.AddWithNullableValue("@HABER", ent.Haber);
                sqlCommand.Parameters.AddWithNullableValue("@LIBROIVA", ent.Libroiva);
                sqlCommand.Parameters.AddWithNullableValue("@COSTES", ent.Costes);
                sqlCommand.Parameters.AddWithNullableValue("@PUNTEO", ent.Punteo);
                sqlCommand.Parameters.AddWithNullableValue("@RETENCION", ent.Retencion);
                sqlCommand.Parameters.AddWithNullableValue("@CENTROCOSTE", ent.Centrocoste);
                sqlCommand.Parameters.AddWithNullableValue("@FACTORMONEDA", ent.Factormoneda);
                sqlCommand.Parameters.AddWithNullableValue("@CODMONEDA", ent.Codmoneda);
                sqlCommand.Parameters.AddWithNullableValue("@EMPRESAGESTION", ent.Empresagestion);
                sqlCommand.Parameters.AddWithNullableValue("@DEBE1", ent.Debe1);
                sqlCommand.Parameters.AddWithNullableValue("@HABER1", ent.Haber2);
                sqlCommand.Parameters.AddWithNullableValue("@PNORMA43STR", ent.Pnorma43Str);
                sqlCommand.Parameters.AddWithNullableValue("@ASIENTOVISIBLE", ent.Asientovisible);
                sqlCommand.Parameters.AddWithNullableValue("@CODMONEDADC", ent.Codmonedadc);
                sqlCommand.Parameters.AddWithNullableValue("@TIPODOCUMENTO", ent.Tipodocumento);
                sqlCommand.Parameters.AddWithNullableValue("@SERIEFISCAL", ent.Seriefiscal);
                sqlCommand.Parameters.AddWithNullableValue("@CODTERCERO", ent.Codtercero);
                sqlCommand.Parameters.AddWithNullableValue("@TERCEROESCLIENTE", ent.Terceroescliente);
                sqlCommand.Parameters.AddWithNullableValue("@NUMEROFISCAL", ent.Numerofiscal);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
