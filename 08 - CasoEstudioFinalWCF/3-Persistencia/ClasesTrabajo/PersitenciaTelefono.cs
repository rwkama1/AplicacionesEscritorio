using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data;
using System.Data.SqlClient;



namespace Persistencia
{
   internal class PersitenciaTelefono
    {

       internal static void Alta(string unTelefono, int pCodCli, SqlTransaction _pTransaccion)
       {         
           SqlCommand _comando = new SqlCommand("AltaTelefono", _pTransaccion.Connection);
           _comando.CommandType = CommandType.StoredProcedure;
           _comando.Parameters.AddWithValue("@NumCli", pCodCli);
           _comando.Parameters.AddWithValue("@TelCli", unTelefono);
           SqlParameter _ParmRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
           _ParmRetorno.Direction = ParameterDirection.ReturnValue;
           _comando.Parameters.Add(_ParmRetorno);


           try
           {
               //determino que debo trabajar con la misma transaccion
               _comando.Transaction = _pTransaccion;

               //ejecuto comando
               _comando.ExecuteNonQuery();

               //verifico si hay errores
               int retorno = Convert.ToInt32(_ParmRetorno.Value);
               if (retorno == -1)
                   throw new Exception("Cliente Invalido");
               else if (retorno == 0)
                   throw new Exception("Error No Especificado");

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }


       internal static List<string> CargoTelCliente(int pNumCli)
       {
           SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

           SqlCommand _comando = new SqlCommand("ListadoTelefonosCliente", _cnn);
           _comando.CommandType = CommandType.StoredProcedure;
           _comando.Parameters.AddWithValue("@NumCLi", pNumCli);

           List<string> _ListaTels = new List<string>();

           try
           {
               //me conecto
               _cnn.Open();

               //ejecuto consulta
               SqlDataReader _lector = _comando.ExecuteReader();

               //verifico si hay telefonos
               if (_lector.HasRows)
               {
                   while (_lector.Read())
                   {
                       _ListaTels.Add((string)_lector["TelCli"]);
                   }
               }

               _lector.Close();
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               _cnn.Close();
           }

           return _ListaTels;
       }


       internal static void EliminarTelsCliente(EntidadesCompartidas.Cliente unCliente, SqlTransaction _pTransaccion)
       {
           SqlCommand _comando = new SqlCommand("EliminoTelsDeCliente", _pTransaccion.Connection);
           _comando.CommandType = CommandType.StoredProcedure;
           _comando.Parameters.AddWithValue("@NumCli", unCliente.NumCli);
           SqlParameter _ParmRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
           _ParmRetorno.Direction = ParameterDirection.ReturnValue;
           _comando.Parameters.Add(_ParmRetorno);


           try
           {
               //determino que debo trabajar con la misma transaccion
               _comando.Transaction = _pTransaccion;

               //ejecuto comando
               _comando.ExecuteNonQuery();
          
           }
           catch (Exception ex)
           {
               throw ex; 
           }
       }

    }
}
