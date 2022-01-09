using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    internal class PersistenciaTipo : IPersistenciaTipo
    {
         //Singleton
        private static PersistenciaTipo _miInstancia;
        private PersistenciaTipo() { }
        public static PersistenciaTipo GetInstancia()
        {
            if (_miInstancia == null)
                _miInstancia = new PersistenciaTipo();
            return _miInstancia;
        }

        //Operaciones
        public TipoLibro BuscarTipo(int pCodigo)
        {
            //variables para crear Tipos de Libro
            int _codigo;
            string _nombre;
            int _estanteria;
            TipoLibro t = null;

            //variables para comunicacion ADO
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("Exec BuscoTipoLibro " + pCodigo, oConexion);
            SqlDataReader oReader;

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.Read())
                {
                    _codigo = (int)oReader["CodTip"];
                    _nombre = (string)oReader["NomTip"];
                    _estanteria = (int)oReader["EstanteriaTip"];
                    t = new TipoLibro(_codigo,_nombre,_estanteria);
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
            return t;
        }

        public List<TipoLibro> ListarTipo()
        {
            //variables para crear Tipos de Libros
            int _codigo;
            string _nombre;
            int _estanteria;
            List<TipoLibro> _Lista = new List<TipoLibro>();

            //variables para comunicacion ADO
            SqlConnection _Conexion = new SqlConnection(Conexion.Cnn);
            SqlCommand _Comando = new SqlCommand("Exec ListoTipoLibro", _Conexion);
            SqlDataReader _Reader;

            try
            {
                _Conexion.Open();
                _Reader = _Comando.ExecuteReader();
                while (_Reader.Read())
                {
                    _codigo = (int)_Reader["CodTip"];
                    _nombre = (string)_Reader["NomTip"];
                    _estanteria = (int)_Reader["EstanteriaTip"];
                    _Lista.Add( new TipoLibro(_codigo, _nombre, _estanteria));
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
