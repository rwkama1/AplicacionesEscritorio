using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using EntidadesCompartidas;
using System.Data.SqlClient;
using System.Data;


namespace Persistencia
{
   internal class PersistenciaPedidos: IPersistenciaPedidos
    {
        //singleton
        private static PersistenciaPedidos _miInstancia;
        private PersistenciaPedidos() { }
        public static PersistenciaPedidos GetInstancia()
        {
            if (_miInstancia == null)
                _miInstancia = new PersistenciaPedidos();
            return (_miInstancia);
        }


        //atributo
        private static string _cnn = "Data Source=.; Initial Catalog = Ventas; Integrated Security = true";

       //operaciones
        public void AltaPedido(Pedido pPedido)
        {
            SqlConnection oConexion = new SqlConnection(_cnn);
            SqlCommand oComando = new SqlCommand("AltaPedido", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@nom", pPedido.NomCliente);
            oComando.Parameters.AddWithValue("@dir", pPedido.DirCliente);
            oComando.Parameters.AddWithValue("@art", pPedido.UnARticulo.Codigo);

            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(_Retorno);

            int oAfectados = -1;

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("El Articulo no Existe");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }
        }

        public List<Pedido> ListarPedidos()
        {
            int _numero;
            string _nombre;
            string _dir;
            Articulo _art;
            List<Pedido> _Lista = new List<Pedido>();

            SqlConnection _Conexion = new SqlConnection(_cnn);
            SqlCommand _Comando = new SqlCommand("Exec ListoPedido", _Conexion);

            SqlDataReader _Reader;
            try
            {
                _Conexion.Open();
                _Reader = _Comando.ExecuteReader();

                while (_Reader.Read())
                {
                    _numero = (int)_Reader["NumPed"];
                    _nombre = (string)_Reader["NomCliPed"];
                    _dir = (string)_Reader["DirPed"];
                    _art = FabricaPersistencia.getPersistenciaArticulo().BuscarArticulo((int)_Reader["CodArt"]);
                    Pedido p = new Pedido(_numero, _nombre, _dir, _art);
                    _Lista.Add(p);
                }

                _Reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas con la base de datos:" + ex.Message);
            }
            finally
            {
                _Conexion.Close();
            }

            return _Lista;
        }
    }
}
