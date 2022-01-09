using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data.SqlClient;
using EntidadesCompartidas;



namespace Persistencia
{
    internal class PersistenciaPrestamo : IPersistenciaPrestamo
    {
        //singleton
        private static PersistenciaPrestamo _instancia = null;
        private PersistenciaPrestamo() { }
        public static PersistenciaPrestamo GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaPrestamo();
            return _instancia;
        }

        //operaciones
        public List<EntidadesCompartidas.Prestamo> ListoPrestamosCliente(EntidadesCompartidas.Cliente unCliente)
        {
           SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Prestamo _unPrestamo = null;
            List<Prestamo> _lista = new List<Prestamo>();

            SqlCommand _comando = new SqlCommand("ListarPrestamosCliente", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@NumCli", unCliente.NumCli);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        _unPrestamo = new Prestamo(Convert.ToInt32(_lector["IdPres"]), unCliente, Convert.ToDateTime(_lector["FechaPres"]), Convert.ToDouble(_lector["MontoPres"]), Convert.ToBoolean(_lector["AprobadoPres"]));
                        _lista.Add(_unPrestamo);
                    }
                }
                _lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
            return _lista;
        }

        public void Alta(EntidadesCompartidas.Prestamo pPrestamo)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("PrestamoAlta", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@Fecha", pPrestamo.Fecha);
            _comando.Parameters.AddWithValue("@monto", pPrestamo.Monto);
            _comando.Parameters.AddWithValue("@Aprobado", pPrestamo.Aprobado);
            _comando.Parameters.AddWithValue("@NumCli", pPrestamo.UnCliente.NumCli);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -2)
                    throw new Exception("No existe el cliente");
                else if ((int)_retorno.Value == -1)
                    throw new Exception("Error en Alta Movimiento");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
        }

        public List<EntidadesCompartidas.Prestamo> ListoPrestamos()
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Prestamo _unPrestamo = null;
            List<Prestamo> _lista = new List<Prestamo>();

            SqlCommand _comando = new SqlCommand("TodosLosPrestamos", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        _unPrestamo = new Prestamo(Convert.ToInt32(_lector["IdPres"]), PersistenciaCliente.GetInstancia().Buscar(Convert.ToInt32(_lector["NumCli"])), Convert.ToDateTime(_lector["FechaPres"]), Convert.ToDouble(_lector["MontoPres"]), Convert.ToBoolean(_lector["AprobadoPres"]));
                        _lista.Add(_unPrestamo);
                    }
                }
                _lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
            return _lista;
        }

    }
}
