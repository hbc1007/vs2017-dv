using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using Chinook.Entities;

namespace Chinook.Data
{
    public class clsArtistDA:clsBaseConnection
    {
        public int GetCount()
        {
            var result = 0;
            var sql = "SELECT COUNT(*) FROM ARTIST";
            //1. CREAR EL OBJETO CONNECTION
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                //2. CREAR UNA INSTANCIA DEL OBJETO COMMAND
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                //3. EJECUTAR EL COMANDO
                result = (int)cmd.ExecuteScalar();
            }

            return result;
        }

        public IEnumerable<clsArtist> Gets()
        {
            var result = new List<clsArtist>();
            var sql = "SELECT ARTISTID,NAME FROM ARTIST";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var entity = new clsArtist();
                    indice = reader.GetOrdinal("ARTISTID");
                    entity.ArtistID = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("NAME");
                    entity.Name = reader.GetString(indice);

                    result.Add(entity);
                }
            }

            return result;
        }

        public IEnumerable<clsArtist> GetWithParam(string nombre)
        {
            var result = new List<clsArtist>();
            var sql = "SELECT ARTISTID,NAME FROM ARTIST WHERE NAME LIKE @FILTROPORNOMBRE ";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                //CONFIGURANDO LOS PARAMETROS DE LA CONSULTA SQL
                cmd.Parameters.Add(new SqlParameter("@FILTROPORNOMBRE", nombre));
                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var entity = new clsArtist();
                    indice = reader.GetOrdinal("ARTISTID");
                    entity.ArtistID = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("NAME");
                    entity.Name = reader.GetString(indice);

                    result.Add(entity);
                }
            }

            return result;
        }

        public IEnumerable<clsArtist> GetWithParamSP(string nombre)
        {
            var result = new List<clsArtist>();
            var sql = "usp_GetArtist";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                //CONFIGURANDO LOS PARAMETROS DE LA CONSULTA SQL
                cmd.Parameters.Add(new SqlParameter("@FILTROPORNOMBRE", nombre));
                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var entity = new clsArtist();
                    indice = reader.GetOrdinal("ARTISTID");
                    entity.ArtistID = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("NAME");
                    entity.Name = reader.GetString(indice);

                    result.Add(entity);
                }
            }

            return result;
        }

        public int InsertArtist(clsArtist entity)
        {
            var result = 0;
            var sql = "usp_InsertArtist";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                //CONFIGURANDO LOS PARAMETROS DE LA CONSULTA SQL
                cmd.Parameters.Add(new SqlParameter("@NOMBRE", entity.Name));
                //EJECUTANDO EL COMANDO
                result = Convert.ToInt32(cmd.ExecuteScalar());
                
            }

            return result;
        }
    }
}
