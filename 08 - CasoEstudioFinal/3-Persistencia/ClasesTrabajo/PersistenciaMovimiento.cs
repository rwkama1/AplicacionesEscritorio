using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using System.Data.SqlClient;


namespace Persistencia
{
    internal class PersistenciaMovimiento : IPersistenciaMovimiento
    {
        //singleton
        private static PersistenciaMovimiento _instancia = null;
        private PersistenciaMovimiento() { }
        public static PersistenciaMovimiento GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaMovimiento();
            return _instancia;
        }

        //operaciones
        public void Alta(Movimiento pMovimiento)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("MovimientosAlta", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@NumCta", pMovimiento.UnaCuenta.NumCta);
            _comando.Parameters.AddWithValue("@MontoMov", pMovimiento.MontoMov);
            _comando.Parameters.AddWithValue("@TipoMov", pMovimiento.TipoMov);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("No existe la cuenta");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("Error en Alta Movimiento");
                else if ((int)_retorno.Value == -3)
                    throw new Exception("Error en Modificacion de saldo");

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

        public List<EntidadesCompartidas.Movimiento> ListarTodosLosMovimientos()
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            List<Movimiento> _lista = new List<Movimiento>();
            Movimiento _unMov = null;

            SqlCommand _comando = new SqlCommand("TodosLosMovs", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        //busco la cuenta
                        Cuenta _unaCuenta = null;
                        _unaCuenta = PersistenciaCuentaCAhorro.GetInstancia().Buscar((int)_lector["NumCta"]);
                        if (_unaCuenta == null)
                            _unaCuenta = PersistenciaCuentaCorriente.GetInstancia().Buscar((int)_lector["NumCta"]);

                        //creo el movimiento
                        _unMov = new Movimiento((int)_lector["IdMov"], (DateTime)_lector["FechaMov"], Convert.ToDouble(_lector["MontoMov"]), (string)_lector["TipoMov"], _unaCuenta);
                        _lista.Add(_unMov);
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
