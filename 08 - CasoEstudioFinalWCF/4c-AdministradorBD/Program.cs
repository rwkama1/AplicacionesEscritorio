using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data.SqlClient;



namespace AdministradorBD
{
    class Program
    {
        internal static string _StrConn = "Data Source=.; Initial Catalog = Banco; Integrated Security = true";

        static void Main(string[] args)
        {
            Boolean _seguir=true;

            while (_seguir)
            {
                try
                {
                    Menu();
                    _seguir = Proceso(Convert.ToInt32(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("Opcion Invalida - Solo Numeros");
                    Console.ReadLine();
                }
            }
        }

        internal static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************************************************************");
            Console.WriteLine("         Administradcion de la Base de Datos del Sistema            ");
            Console.WriteLine("********************************************************************");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("1.- Crear Indice para Tabla Movimientos (por cuenta)");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("2.- Deshabilitar Indice para Tabla Movimientos (por cuenta)");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("3.- Crear Usuario de logueo a SqlServer (usuario + rol)");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("4.- Crear Usuario para Base de datos del sistema en SqlServer");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("5.- Quitar Usuario SqlServer");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("6.- Quitar Permisos de Usuario");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("7.- Salir");
            Console.ResetColor();

            Console.WriteLine();
            Console.Write("Ingrese su Opcion: ");
        }

        internal static Boolean Proceso(int _opcion)
        {
            Boolean _retorno = true;

            switch (_opcion)
            {
                case 1:
                    CrearIndice();
                    break;
                case 2:
                    DeshabilitarIndice();
                    break;
                case 3:
                    CrearUsuarioLogueo();
                    break;
                case 4:
                    CrearUsuarioComunBD();
                    break;
                case 5:
                    EliminarUsuarioLogueo();
                    break;
                case 6:
                    QuitarPermisoUsuarioBd();
                    break;
                case 7:
                    _retorno = false;
                    Console.WriteLine("Se termino la ejecucion");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    Console.ReadLine();
                    break;
            }
            return (_retorno);
        }

        private static void CrearIndice()
        {
            //titulo de la accion en pantalla
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************************************************************");
            Console.WriteLine("        Creacion de Indice en Tabla Movimientos                     ");
            Console.WriteLine("********************************************************************");
            Console.ResetColor();
            Console.WriteLine();


            //Conexion a BD
            SqlConnection _miConn = new SqlConnection(_StrConn);
            

            //Creacion de Comando a Ejecutar
            SqlCommand _miComando = new SqlCommand("CrearIndice", _miConn);
            _miComando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _miComando.Parameters.Add(_retorno);


            //Ejecucion de la accion en la bd
            try
            {
                _miConn.Open();
                _miComando.ExecuteNonQuery();
                int _resultado = Convert.ToInt32(_retorno.Value.ToString());
                
                //verificacion de errores
                if (_resultado == -1)
                    throw new Exception("El indice ya existe - No se creo");
                else if (_resultado == -2)
                    throw new Exception("Error");

                //si se llego aca - TOdo Ok
                Console.WriteLine("Creacion del Indice Con Exito");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void DeshabilitarIndice()
        {
            //titulo de la accion en pantalla
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************************************************************");
            Console.WriteLine("        Deshabilitar de Indice en Tabla Movimientos                 ");
            Console.WriteLine("********************************************************************");
            Console.ResetColor();
            Console.WriteLine();


            //Conexion a BD
            SqlConnection _miConn = new SqlConnection(_StrConn);


            //Creacion de Comando a Ejecutar
            SqlCommand _miComando = new SqlCommand("DeshabilitarIndice", _miConn);
            _miComando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _miComando.Parameters.Add(_retorno);


            //Ejecucion de la accion en la bd
            try
            {
                _miConn.Open();
                _miComando.ExecuteNonQuery();
                int _resultado = Convert.ToInt32(_retorno.Value.ToString());

                //verificacion de errores
                if (_resultado == -1)
                    throw new Exception("El indice no existe - No se pudo deshabilitar");
                else if (_resultado == -2)
                    throw new Exception("Error");

                //si se llego aca - TOdo Ok
                Console.WriteLine("Se deahabilito del Indice Con Exito");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void CrearUsuarioLogueo()
        {
            //titulo de la accion en pantalla
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************************************************************");
            Console.WriteLine("                  Crear Usuario de Logueo con Rol                   ");
            Console.WriteLine("********************************************************************");
            Console.ResetColor();
            Console.WriteLine();


            //solicito los datos necesarios
            string _nombre = "";
            string _pass = "";
            int _rol = 0;
            try
            {
                //nombre de usuario
                Console.Write("\nIngrese Nombre de Usuario: ");
                _nombre = Console.ReadLine().Trim();
                if (_nombre.Length > 10 || _nombre.Length == 0)
                    throw new Exception("EL nombre de usuario debe tener al menos 1 caracter - Maximo 10 caracteres");

                //contraseña
                Console.Write("\nIngrese Contraseña de Acceso: ");
                _pass = Console.ReadLine().Trim();
                if (_pass.Length > 10 || _pass.Length == 0)
                    throw new Exception("La contraseña debe tener al menos 1 caracter - Maximo 10 caracteres");

                //rol para asignar
                Console.WriteLine("\n1 - sysadmin");
                Console.WriteLine("2 - securityadmin");
                Console.Write("Determine Rol: ");
                _rol = Convert.ToInt32(Console.ReadLine());
                if (_rol != 1 && _rol != 2)
                    throw new Exception("Opcion Invalida");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Se cancela la creacion de usuario");
                Console.ReadLine();
                return;
            }


            //Conexion a BD
            SqlConnection _miConn = new SqlConnection(_StrConn);


            //Creacion de Comando a Ejecutar
            SqlCommand _miComando = new SqlCommand("NuevoUsuarioSql", _miConn);
            _miComando.CommandType = System.Data.CommandType.StoredProcedure;

            //parametros
            _miComando.Parameters.AddWithValue("@nombre", _nombre);
            _miComando.Parameters.AddWithValue("@pass", _pass);
            if (_rol ==1)
                _miComando.Parameters.AddWithValue("@Rol", "sysadmin");
            else
                _miComando.Parameters.AddWithValue("@Rol", "securityadmin");
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _miComando.Parameters.Add(_retorno);


            //Ejecucion de la accion en la bd
            try
            {
                _miConn.Open();
                _miComando.ExecuteNonQuery();
                int _resultado = Convert.ToInt32(_retorno.Value.ToString());

                //verificacion de errores
                if (_resultado == -1)
                    throw new Exception("Error en Creacion de Usuario");
                else if (_resultado == -2)
                    throw new Exception("Error en Asignacion de rol");

                //si se llego aca - TOdo Ok
                Console.WriteLine("Se creao el Usuario de Logueo con Exito");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void CrearUsuarioComunBD()
        {
            //titulo de la accion en pantalla
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************************************************************");
            Console.WriteLine("             Crear Usuario para la Base de datos con Rol            ");
            Console.WriteLine("********************************************************************");
            Console.ResetColor();
            Console.WriteLine();


            //solicito los datos necesarios
            string _nombre = "";
            string _logueo = "";
            int _rol = 0;
            try
            {
                //nombre de usuario
                Console.Write("\nIngrese Nombre de Usuario: ");
                _nombre = Console.ReadLine().Trim();
                if (_nombre.Length > 10 || _nombre.Length == 0)
                    throw new Exception("EL nombre de usuario debe tener al menos 1 caracter - Maximo 10 caracteres");

                //usuario para loguearse
                Console.Write("\nIngrese Usuario de Logueo: ");
                _logueo = Console.ReadLine().Trim();
                if (_logueo.Length > 10 || _logueo.Length == 0)
                    throw new Exception("El usuario de logueo debe tener al menos 1 caracter - Maximo 10 caracteres");

                //rol para asignar
                Console.WriteLine("\n1 - db_ddladmin");
                Console.WriteLine("2 - db_datawriter");
                Console.WriteLine("3 - db_datareader");
                Console.Write("Determine Rol: ");
                _rol = Convert.ToInt32(Console.ReadLine());
                if (_rol != 1 && _rol != 2 && _rol != 3)
                    throw new Exception("Opcion Invalida");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Se cancela la creacion de usuario");
                Console.ReadLine();
                return;
            }


            //Conexion a BD
            SqlConnection _miConn = new SqlConnection(_StrConn);


            //Creacion de Comando a Ejecutar
            SqlCommand _miComando = new SqlCommand("NuevoUsuarioBD", _miConn);
            _miComando.CommandType = System.Data.CommandType.StoredProcedure;

            //parametros
            _miComando.Parameters.AddWithValue("@nombre", _nombre);
            _miComando.Parameters.AddWithValue("@logueo", _logueo);
            if (_rol == 1)
                _miComando.Parameters.AddWithValue("@Rol", "db_ddladmin");
            else if (_rol == 2)
                _miComando.Parameters.AddWithValue("@Rol", "db_datawriter");
            else
                _miComando.Parameters.AddWithValue("@Rol", "db_datareader");
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _miComando.Parameters.Add(_retorno);


            //Ejecucion de la accion en la bd
            try
            {
                _miConn.Open();
                _miComando.ExecuteNonQuery();
                int _resultado = Convert.ToInt32(_retorno.Value.ToString());

                //verificacion de errores
                if (_resultado == -1)
                    throw new Exception("Error en Creacion de Usuario");
                else if (_resultado == -2)
                    throw new Exception("Error en Asignacion de rol");

                //si se llego aca - TOdo Ok
                Console.WriteLine("Se creao el Usuario de Logueo con Exito");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void EliminarUsuarioLogueo()
        {
            //titulo de la accion en pantalla
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************************************************************");
            Console.WriteLine("                  Eliminar Usuario de Logueo                        ");
            Console.WriteLine("********************************************************************");
            Console.ResetColor();
            Console.WriteLine();


            //solicito los datos necesarios
            string _nombre = "";
            try
            {
                //nombre de usuario
                Console.Write("\nIngrese Nombre de Usuario: ");
                _nombre = Console.ReadLine().Trim();
                if (_nombre.Length > 10 || _nombre.Length == 0)
                    throw new Exception("EL nombre de usuario debe tener al menos 1 caracter - Maximo 10 caracteres");

             }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Se cancela la eliminacion de usuario");
                Console.ReadLine();
                return;
            }


            //Conexion a BD
            SqlConnection _miConn = new SqlConnection(_StrConn);


            //Creacion de Comando a Ejecutar
            SqlCommand _miComando = new SqlCommand("EliminarUsuarioSql", _miConn);
            _miComando.CommandType = System.Data.CommandType.StoredProcedure;

            //parametros
            _miComando.Parameters.AddWithValue("@nombre", _nombre);
             SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _miComando.Parameters.Add(_retorno);


            //Ejecucion de la accion en la bd
            try
            {
                _miConn.Open();
                _miComando.ExecuteNonQuery();
                int _resultado = Convert.ToInt32(_retorno.Value.ToString());

                //verificacion de errores
                if (_resultado == -1)
                    throw new Exception("Error en Eliminacion de Usuario");
                else if (_resultado == -2)
                    throw new Exception("Error en Asignacion de rol");

                //si se llego aca - TOdo Ok
                Console.WriteLine("Se elimino el Usuario de Logueo con Exito");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }          
        }

        private static void QuitarPermisoUsuarioBd()
        {
            //titulo de la accion en pantalla
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************************************************************");
            Console.WriteLine("         Quitar Permisos de un Usuario de la Base de datos          ");
            Console.WriteLine("********************************************************************");
            Console.ResetColor();
            Console.WriteLine();


            //solicito los datos necesarios
            string _nombre = "";
            int _permiso = 0;
            try
            {
                //nombre de usuario
                Console.Write("\nIngrese Nombre de Usuario: ");
                _nombre = Console.ReadLine().Trim();
                if (_nombre.Length > 10 || _nombre.Length == 0)
                    throw new Exception("EL nombre de usuario debe tener al menos 1 caracter - Maximo 10 caracteres");

                //permiso
                Console.WriteLine("\n1 - Permiso de Ejecucion de SP");
                Console.WriteLine("2 - Permiso de Escritura sobre la tabla Movimientos");
                Console.Write("Determine Permiso: ");
                _permiso = Convert.ToInt32(Console.ReadLine());
                if (_permiso != 1 && _permiso != 2)
                    throw new Exception("Opcion Invalida");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Se cancela la eliminacion de permisos");
                Console.ReadLine();
                return;
            }


            //Conexion a BD
            SqlConnection _miConn = new SqlConnection(_StrConn);


            //Creacion de Comando a Ejecutar
            SqlCommand _miComando = new SqlCommand("QuitarPermisoUsuarioBD", _miConn);
            _miComando.CommandType = System.Data.CommandType.StoredProcedure;

            //parametros
            _miComando.Parameters.AddWithValue("@nombre", _nombre);
            _miComando.Parameters.AddWithValue("@permiso", _permiso);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _miComando.Parameters.Add(_retorno);


            //Ejecucion de la accion en la bd
            try
            {
                _miConn.Open();
                _miComando.ExecuteNonQuery();
                int _resultado = Convert.ToInt32(_retorno.Value.ToString());

                //verificacion de errores
                if (_resultado == -1)
                    throw new Exception("Error en Tipo de Permiso");
                else if (_resultado == -2)
                    throw new Exception("Error en Quitar Permiso");

                //si se llego aca - TOdo Ok
                Console.WriteLine("Se Quito el Permiso con Exito");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }           
        }

    }
}
