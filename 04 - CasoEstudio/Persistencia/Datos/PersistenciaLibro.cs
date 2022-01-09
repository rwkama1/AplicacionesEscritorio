using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    internal class PersistenciaLibro : IPersistenciaLibro
    {
        //Singleton
        private static PersistenciaLibro _miInstancia;
        private PersistenciaLibro() { }
        public static PersistenciaLibro GetInstancia()
        {
            if (_miInstancia == null)
                _miInstancia = new PersistenciaLibro();
            return _miInstancia;
        }
 
        //Operaciones
        public void AltaLibro(Libro unLibro)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("AltaLibro", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@isbn", unLibro.Codigo);
            oComando.Parameters.AddWithValue("@nom", unLibro.Nombre);
            oComando.Parameters.AddWithValue("@reseña", unLibro.Reseña);
            oComando.Parameters.AddWithValue("codaut", unLibro.UnAutor.Codigo);
            oComando.Parameters.AddWithValue("@codtip", unLibro.UnTipo.Codigo);

            SqlParameter _retorno = new SqlParameter("@Retorno",SqlDbType.Int);
            _retorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(_retorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                switch ((int)_retorno.Value)
                {
                    case -1:
                        {
                            throw new Exception("Duplica ISBN");
                        }
                    case -2: 
                        {
                            throw new Exception("El Autor No existe");
                        }
                    case -3: 
                        {
                            throw new Exception("El Tipo de Libro no Existe");
                        }
                    case 0:
                        {
                            throw new Exception("Error Indefinido");
                        }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                oConexion.Close();
            }

        }

        public void BajaLibro(Libro unLibro)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("BajaLibro", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@isbn", unLibro.Codigo);

            SqlParameter _retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _retorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(_retorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                switch ((int)_retorno.Value)
                {
                    case -1:
                        {
                            throw new Exception("No Existe el Libro - No se Puede Eiminar");
                        }
                    case 0:
                        {
                            throw new Exception("Error Indefinido");
                        }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                oConexion.Close();
            }
        }

        public void ModificaLibro(Libro unLibro)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("ModificarLibro", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@isbn", unLibro.Codigo);
            oComando.Parameters.AddWithValue("@nom", unLibro.Nombre);
            oComando.Parameters.AddWithValue("@reseña", unLibro.Reseña);
            oComando.Parameters.AddWithValue("codaut", unLibro.UnAutor.Codigo);
            oComando.Parameters.AddWithValue("@codtip", unLibro.UnTipo.Codigo);

            SqlParameter _retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _retorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(_retorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                switch ((int)_retorno.Value)
                {
                    case -1:
                        {
                            throw new Exception("No Existe ISBN - No se puede Modificar");
                        }
                    case -2:
                        {
                            throw new Exception("El Autor No existe");
                        }
                    case -3:
                        {
                            throw new Exception("El Tipo de Libro no Existe");
                        }
                    case 0:
                        {
                            throw new Exception("Error Indefinido");
                        }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                oConexion.Close();
            }
        }

        public Libro BuscarLibro(int pIsbn)
        {
            //variables para crear Libro
            string _nombre;
            string _reseña;
            TipoLibro t = null;
            Autor a = null;
            Libro l = null;

            //variables para comunicacion ADO
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("Exec BuscoLibro " + pIsbn, oConexion);
            SqlDataReader oReader;

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.Read())
                {
                    _nombre = (string)oReader["NomLib"];
                    _reseña = (string)oReader["ReseñaLib"];
                    a = FabricaPersistencia.getPersistenciaAutor().BuscarAutor((int)oReader["CodAut"]);
                    t = FabricaPersistencia.getPersistenciaTipoLibro().BuscarTipo((int)oReader["CodTip"]);
                    l = new Libro(pIsbn,_nombre,_reseña,a,t);
                }
                oReader.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Problemas con la base de datos:" + ex.Message);
            }
            finally
            {
                oConexion.Close();
            }
            return l;
        }

        public List<Libro> ListarLibro()
        {
            //variables para crear Libros
            int _isbn;
            string _nombre;
            string _reseña;
            List<Libro> _Lista = new List<Libro>();

            //variables para comunicacion ADO
            SqlConnection _Conexion = new SqlConnection(Conexion.Cnn);
            SqlCommand _Comando = new SqlCommand("Exec ListoLibro", _Conexion);
            SqlDataReader _Reader;

            try
            {
                _Conexion.Open();
                _Reader = _Comando.ExecuteReader();
                while (_Reader.Read())
                {
                    _isbn = (int)_Reader["IsbnLib"];
                    _nombre = (string)_Reader["NomLib"];
                    _reseña = (string)_Reader["ReseñaLib"];
                    Autor a = FabricaPersistencia.getPersistenciaAutor().BuscarAutor((int)_Reader["CodAut"]);
                    TipoLibro t = FabricaPersistencia.getPersistenciaTipoLibro().BuscarTipo((int)_Reader["CodTip"]);
                    _Lista.Add(new Libro(_isbn, _nombre, _reseña, a, t));
                }
                _Reader.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Problemas con la base de datos:" + ex.Message);
            }
            finally
            {
                _Conexion.Close();
            }
            return _Lista;
        }

        public List<Libro> ListarLibroPorTipo(TipoLibro unTipo)
        {
            //varibles para crear libro
            int _isbn;
            string _nombre;
            string _reseña;
            List<Libro> _Lista = new List<Libro>();

            //variables para comunicacion ADO
            SqlConnection _Conexion = new SqlConnection(Conexion.Cnn);
            SqlCommand _Comando = new SqlCommand("Select * from Libro Where codTip = " + unTipo.Codigo.ToString(), _Conexion);
            SqlDataReader _Reader;

            try
            {
                _Conexion.Open();
                _Reader = _Comando.ExecuteReader();
                while (_Reader.Read())
                {
                    _isbn = (int)_Reader["IsbnLib"];
                    _nombre = (string)_Reader["NomLib"];
                    _reseña = (string)_Reader["ReseñaLib"];
                    Autor a = FabricaPersistencia.getPersistenciaAutor().BuscarAutor((int)_Reader["CodAut"]);                    
                    _Lista.Add(new Libro(_isbn, _nombre, _reseña, a, unTipo));
                }
                _Reader.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Problemas con la base de datos:" + ex.Message);
            }
            finally
            {
                _Conexion.Close();
            }
            return _Lista;
        }

    }
}
