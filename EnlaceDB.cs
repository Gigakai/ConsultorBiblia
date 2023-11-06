/*
Autor: Alejandro Villarreal

LMAD

PARA EL PROYECTO ES OBLIGATORIO EL USO DE ESTA CLASE, 
EN EL SENTIDO DE QUE LOS DATOS DE CONEXION AL SERVIDOR ESTAN DEFINIDOS EN EL App.Config
Y NO TENER ESOS DATOS EN CODIGO DURO DEL PROYECTO.

NO SE PERMITE HARDCODE.

LOS MÉTODOS QUE SE DEFINEN EN ESTA CLASE SON EJEMPLOS, PARA QUE SE BASEN Y USTEDES HAGAN LOS SUYOS PROPIOS
Y DEFINAN Y PROGRAMEN TODOS LOS MÉTODOS QUE SEAN NECESARIOS PARA SU PROYECTO.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using ConsultorBiblia.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

/*
Se tiene que cambiar el namespace para el que usen en su proyecto
*/
namespace ConsultorBiblia
{
    public class EnlaceDB
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }

        private static void conectar()
        {
            /*
			Para que funcione el ConfigurationManager
			en la sección de "Referencias" de su proyecto, en el "Solution Explorer"
			dar clic al botón derecho del mouse y dar clic a "Add Reference"
			Luego elegir la opción System.Configuration
			
			tal como lo vimos en clase.
			*/
            string cnn = ConfigurationManager.ConnectionStrings["SQL"].ToString();
            // Cambiar Grupo01 por el que ustedes hayan definido en el App.Confif
            _conexion = new SqlConnection(cnn);
            _conexion.Open();
        }
        private static void desconectar()
        {
            _conexion.Close();
        }
        public bool IniciarSesion(string email, string password)
        {
            _tabla.Clear();
            bool isValid = false;
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@email", SqlDbType.VarChar, 35);
                parametro1.Value = email;
                var parametro2 = _comandosql.Parameters.Add("@contraseña", SqlDbType.VarChar, 12);
                parametro2.Value = password;
                var parametro3 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro3.Value = 'L';


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    isValid = true;
                    _tabla.Rows.Clear();
                }
            }
            catch (SqlException e)
            {
                isValid = false;
            }
            finally
            {
                desconectar();
            }

            return isValid;
        }

        public DataTable getLanguages()
        {
            bool isValid = false;
            try
            {
                conectar();
                string qry = "spGestionDB_Bible";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'I';


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    return _tabla;
                    
                }
            }
            catch (SqlException e)
            {
                isValid = false;
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public DataTable getVersiones(string idiomaSelected)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spGestionDB_Bible";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'V';
                var parametro2 = _comandosql.Parameters.Add("@idiomaSeleccionado", SqlDbType.VarChar, 20);
                parametro2.Value = idiomaSelected;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return tabla;

                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public DataTable get_Users()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                // Ejemplo de cómo ejecutar un query, 
                // PERO lo correcto es siempre usar SP para cualquier consulta a la base de datos
                string qry = "SELECT Nombre, email, Fecha_modif from Usuarios where Activo = 0;";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.Text;
                // Esta opción solo la podrían utilizar si hacen un EXEC al SP concatenando los parámetros.
                _comandosql.CommandTimeout = 1200;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        // Ejemplo de método para recibir una consulta en forma de tabla
        // Cuando el SP ejecutará un SELECT
        public DataTable get_Deptos(string opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SELECT * FROM Usuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.Text;
                _comandosql.CommandTimeout = 1200;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla
                int i = 0;
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
           
            return tabla;
        }

        // Ejemplo de método para ejecutar un SP que no se espera que regrese información, 
        // solo que ejecute ya sea un INSERT, UPDATE o DELETE
        public bool Add_Usuario(string email, string password, string nombre, string apellidoPat, string apellidoMat, char genero, DateTime fechaNacimiento)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@email", SqlDbType.VarChar, 35);
                parametro1.Value = email;
                var parametro2 = _comandosql.Parameters.Add("@contraseña", SqlDbType.VarChar, 12);
                parametro2.Value = password;
                var parametro3 = _comandosql.Parameters.Add("@nombres", SqlDbType.VarChar, 25);
                parametro3.Value = nombre;
                var parametro4 = _comandosql.Parameters.Add("@apellidoPat", SqlDbType.VarChar, 15);
                parametro4.Value = apellidoPat;
                var parametro5 = _comandosql.Parameters.Add("@apellidoMat", SqlDbType.VarChar, 15);
                parametro5.Value = apellidoMat;
                var parametro6 = _comandosql.Parameters.Add("@genero", SqlDbType.Char, 1);
                parametro6.Value = genero;
                var parametro7 = _comandosql.Parameters.Add("@fechaNacimiento", SqlDbType.Date);
                parametro7.Value = fechaNacimiento;
                var parametro8 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro8.Value = 'I';
      
                _adaptador.InsertCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand
                
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                switch (e.Number)
                {
                    case 547:
                        {
                            msg = "Error en la fecha de nacimiento\nNo se puede agragar una fecha anterior al año 1923-01-01";
                            break;
                        }
                    case 2627:
                        {
                            msg = "Error en el email\nEste Email ya esta registrado";
                            break;
                        }
                }
                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                desconectar();
            }

            return add;



        }
        public DataTable getUsuario(string email)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'S';
                var parametro2 = _comandosql.Parameters.Add("@email", SqlDbType.VarChar, 35);
                parametro2.Value = email;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return tabla;

                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public DataTable getNumPasswords(string email, string password)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'D';
                var parametro2 = _comandosql.Parameters.Add("@email", SqlDbType.VarChar, 35);
                parametro2.Value = email;
                var parametro3 = _comandosql.Parameters.Add("@contraseña", SqlDbType.VarChar, 12);
                parametro3.Value = password;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return tabla;

                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public void deleteUsuario(string email)
        {
            
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@email", SqlDbType.VarChar, 35);
                parametro1.Value = email;
                var parametro2 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro2.Value = 'B';

                _adaptador.UpdateCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
               
            }
            finally
            {
                desconectar();
            }

            
        }
        public void errorPassword(string email)
        {
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@email", SqlDbType.VarChar, 35);
                parametro1.Value = email;
                var parametro2 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro2.Value = 'E';

                _adaptador.UpdateCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {

            }
            finally
            {
                desconectar();
            }
        }
        public bool updateUser(string email, string password, string nombre, string apellidoMat, string apellidoPat, char genre, DateTime fechaNacimiento)
        {
            bool validUpdate = true;
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@email", SqlDbType.VarChar, 35);
                parametro1.Value = email;
                var parametro2 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro2.Value = 'A';
                var parametro3 = _comandosql.Parameters.Add("@contraseña", SqlDbType.VarChar, 12);
                parametro3.Value = password;
                var parametro4 = _comandosql.Parameters.Add("@nombres", SqlDbType.VarChar, 25);
                parametro4.Value = nombre;
                var parametro5 = _comandosql.Parameters.Add("@apellidoPat", SqlDbType.VarChar, 15);
                parametro5.Value = apellidoPat;
                var parametro6 = _comandosql.Parameters.Add("@apellidoMat", SqlDbType.VarChar, 15);
                parametro6.Value = apellidoMat;
                var parametro7 = _comandosql.Parameters.Add("@genero", SqlDbType.Char, 1);
                parametro7.Value = genre;
                var parametro8 = _comandosql.Parameters.Add("@fechaNacimiento", SqlDbType.Date);
                parametro8.Value = fechaNacimiento;
                _adaptador.UpdateCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                validUpdate = false;
                MessageBox.Show("Esa contraseña ya ha sido usada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
            return validUpdate;
        }
        public bool updatePassword(string email, string password)
        {
            bool isValid = true;
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@email", SqlDbType.VarChar, 35);
                parametro1.Value = email;
                var parametro2 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro2.Value = 'P';
                var parametro3 = _comandosql.Parameters.Add("@contraseña", SqlDbType.VarChar, 12);
                parametro3.Value = password;

                _adaptador.UpdateCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                isValid = false;
                MessageBox.Show("Esa contraseña ya ha sido usada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
            return isValid;
        }
        public bool updateTryLogIn(string email)
        {
            bool isValid = true;
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@email", SqlDbType.VarChar, 35);
                parametro1.Value = email;
                var parametro2 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro2.Value = 'R';

                _adaptador.UpdateCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                isValid = false;
                MessageBox.Show("Error", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
            return isValid;
        }
        public DataTable getLibros(string version)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spGestionDB_Bible";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'L';
                var parametro2 = _comandosql.Parameters.Add("@versionSeleccionado", SqlDbType.VarChar, 30);
                parametro2.Value = version;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return tabla;

                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public DataTable getTestamento(string version)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spGestionDB_Bible";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'T';
                var parametro2 = _comandosql.Parameters.Add("@versionSeleccionado", SqlDbType.VarChar, 30);
                parametro2.Value = version;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return tabla;

                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public DataTable getTestamentoLibros(string version, string testamento)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spGestionDB_Bible";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'S';
                var parametro2 = _comandosql.Parameters.Add("@versionSeleccionado", SqlDbType.VarChar, 30);
                parametro2.Value = version;
                var parametro3 = _comandosql.Parameters.Add("@testamentoSeleccionado", SqlDbType.VarChar, 20);
                parametro3.Value = testamento;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return tabla;

                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public DataTable getCapitulos(string version, string libro)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spGestionDB_Bible";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'C';
                var parametro2 = _comandosql.Parameters.Add("@versionSeleccionado", SqlDbType.VarChar, 30);
                parametro2.Value = version;
                var parametro3 = _comandosql.Parameters.Add("@libroSeleccionado", SqlDbType.VarChar, 20);
                parametro3.Value = libro;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return tabla;

                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public DataTable getnumVersiculos(string version, string libro, string numCap)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spGestionDB_Bible";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'N';
                var parametro2 = _comandosql.Parameters.Add("@versionSeleccionado", SqlDbType.VarChar, 30);
                parametro2.Value = version;
                var parametro3 = _comandosql.Parameters.Add("@libroSeleccionado", SqlDbType.VarChar, 20);
                parametro3.Value = libro;
                var parametro4 = _comandosql.Parameters.Add("@capituloSeleccionado", SqlDbType.VarChar, 20);
                parametro4.Value = numCap;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return tabla;

                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public DataTable getVersiculos(string version, string libro, string numCap)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spGestionDB_Bible";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'B';
                var parametro2 = _comandosql.Parameters.Add("@versionSeleccionado", SqlDbType.VarChar, 30);
                parametro2.Value = version;
                var parametro3 = _comandosql.Parameters.Add("@libroSeleccionado", SqlDbType.VarChar, 20);
                parametro3.Value = libro;
                var parametro4 = _comandosql.Parameters.Add("@capituloSeleccionado", SqlDbType.VarChar, 20);
                parametro4.Value = numCap;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return tabla;

                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public DataTable getVersiculos(string version, string libro, string numCap, string versiculos)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spGestionDB_Bible";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'B';
                var parametro2 = _comandosql.Parameters.Add("@versionSeleccionado", SqlDbType.VarChar, 30);
                parametro2.Value = version;
                var parametro3 = _comandosql.Parameters.Add("@libroSeleccionado", SqlDbType.VarChar, 20);
                parametro3.Value = libro;
                var parametro4 = _comandosql.Parameters.Add("@capituloSeleccionado", SqlDbType.VarChar, 20);
                parametro4.Value = numCap;
                var parametro5 = _comandosql.Parameters.Add("@versiculoSeleccionado", SqlDbType.VarChar, 100);
                parametro5.Value = versiculos;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return tabla;

                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public DataTable getVersiculosW(string version, string keywords, string testamento, string libros)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spGestionDB_Bible";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'W';
                var parametro2 = _comandosql.Parameters.Add("@versionSeleccionado", SqlDbType.VarChar, 30);
                parametro2.Value = version;
                var parametro3 = _comandosql.Parameters.Add("@palabraIngresada", SqlDbType.VarChar, 200);
                parametro3.Value = keywords;
                if (!string.IsNullOrEmpty(testamento))
                {
                    var parametro4 = _comandosql.Parameters.Add("@testamentoSeleccionado", SqlDbType.VarChar, 20);
                    parametro4.Value = testamento;
                }
                if (!string.IsNullOrEmpty(libros))
                {
                    var parametro5 = _comandosql.Parameters.Add("@librosSeleccionado", SqlDbType.VarChar, 200);
                    parametro5.Value = libros;
                }

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return tabla;

                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
                desconectar();
            }

            return null;
        }
        public bool AddBusquedas(string email, string version, string keywords, string testamento, string libros)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionBusquedas";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcionSeleccionada", SqlDbType.Char, 1);
                parametro1.Value = 'I';
                var parametro2 = _comandosql.Parameters.Add("@versionSeleccionado", SqlDbType.VarChar, 30);
                parametro2.Value = version;
                var parametro3 = _comandosql.Parameters.Add("@palabraIngresada", SqlDbType.VarChar, 200);
                parametro3.Value = keywords;
                if (!string.IsNullOrEmpty(testamento))
                {
                    var parametro4 = _comandosql.Parameters.Add("@testamentoSeleccionado", SqlDbType.VarChar, 20);
                    parametro4.Value = testamento;
                }
                if (!string.IsNullOrEmpty(libros))
                {
                    var parametro5 = _comandosql.Parameters.Add("@librosSeleccionado", SqlDbType.VarChar, 200);
                    parametro5.Value = libros;
                }
                var parametro6 = _comandosql.Parameters.Add("@email", SqlDbType.VarChar, 35);
                parametro6.Value = email;

                _adaptador.InsertCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                switch (e.Number)
                {
                    case 547:
                        {
                            msg = "Error en la fecha de nacimiento\nNo se puede agragar una fecha anterior al año 1923-01-01";
                            break;
                        }
                    case 2627:
                        {
                            msg = "Error en el email\nEste Email ya esta registrado";
                            break;
                        }
                }
                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                desconectar();
            }

            return add;



        }
    }
}
