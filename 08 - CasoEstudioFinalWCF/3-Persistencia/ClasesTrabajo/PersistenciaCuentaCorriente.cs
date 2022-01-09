using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using System.Data.SqlClient;


namespace Persistencia
{
   internal class PersistenciaCuentaCorriente:IPersistenciaCuentaCorriente
    {
        //singleton
        private static PersistenciaCuentaCorriente _instancia = null;
        private PersistenciaCuentaCorriente() { }
        public static PersistenciaCuentaCorriente GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaCuentaCorriente();
            return _instancia;
        }

        //operaciones
       public void Alta(CuentaCorriente pCuenta)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("CuentaCorrienteAlta", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@NumCli", pCuenta.UnCliente.NumCli);
            _comando.Parameters.AddWithValue("@MinimoCta", pCuenta.MinimoCta);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("El cliente no existe - No se creo cuenta");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("Error en Alta");
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

       public void Baja(CuentaCorriente pCuenta)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("CuentaCorrienteBaja", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@NumCta", pCuenta.NumCta);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("La cuenta tiene Movimientos asignados");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("Error en Borrar Cuenta Corriente");
                else if ((int)_retorno.Value == -3)
                    throw new Exception("Error en Borrar Cuenta");
 
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

       public CuentaCorriente Buscar(int pNumCta)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            CuentaCorriente _unaCta= null;

            SqlCommand _comando = new SqlCommand("BuscarCuentaCorriente", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@NumCta", pNumCta);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    _lector.Read();
                    _unaCta = new CuentaCorriente((int)_lector["NumCta"], (PersistenciaCliente.GetInstancia().Buscar((int)_lector["NumCli"])), Convert.ToDouble(_lector["SaldoCta"]), Convert.ToDouble(_lector["MinimoCta"]));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
            return _unaCta;
        }
 
       public List<CuentaCorriente> Listado()
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            CuentaCorriente _unaCta = null;
            List<CuentaCorriente> _lista = new List<CuentaCorriente>();

            SqlCommand _comando = new SqlCommand("ListadoCuentaCorriente", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        _unaCta = new CuentaCorriente((int)_lector["NumCta"], (PersistenciaCliente.GetInstancia().Buscar((int)_lector["NumCli"])), Convert.ToDouble(_lector["SaldoCta"]), Convert.ToDouble(_lector["MinimoCta"]));
                        _lista.Add(_unaCta);
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

       public List<EntidadesCompartidas.Movimiento> ListarMovimientosDeCuenta(EntidadesCompartidas.CuentaCorriente pCuenta)
      {
           SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
           List<Movimiento> _lista = new List<Movimiento>();
           Movimiento _unMov = null;

           SqlCommand _comando = new SqlCommand("ListadoMovimientoDeCuenta", _cnn);
           _comando.Parameters.AddWithValue("Numcta", pCuenta.NumCta);
           _comando.CommandType = System.Data.CommandType.StoredProcedure;

           try
           {
               _cnn.Open();
               SqlDataReader _lector = _comando.ExecuteReader();
               if (_lector.HasRows)
               {
                   while (_lector.Read())
                   {
                       _unMov = new Movimiento((int)_lector["IdMov"], (DateTime)_lector["FechaMov"], Convert.ToDouble(_lector["MontoMov"]), (string)_lector["TipoMov"], pCuenta);
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
