using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;


namespace Persistencia
{
    public class PersitenciaEmpleado:IPeristenciaEmpleado
    {
         //singleton
        private static PersitenciaEmpleado _instancia = null;
        private PersitenciaEmpleado() { }
        public static PersitenciaEmpleado GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersitenciaEmpleado();
            return _instancia;
        }

        //operaciones
        public EntidadesCompartidas.Empleado Logueo(int pCI, string pPass)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Empleado _unEmpleado = null;

            SqlCommand _comando = new SqlCommand("LogueoEmp", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@CiEmp", pCI);
            _comando.Parameters.AddWithValue("@PassEmp", pPass);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    _lector.Read();
                    _unEmpleado = new Empleado((int)_lector["CiEmp"], (string)_lector["NomEmp"], (string)_lector["PassEmp"]);
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
            return _unEmpleado;
        }


    }
}
