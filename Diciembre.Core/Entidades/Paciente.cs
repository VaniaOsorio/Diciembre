using Diciembre.Core.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diciembre.Core.Entidades
{
    public class Paciente{
                
            public int Id { get; set; }

            public string Nombre { get; set; }

            public string Apellido { get; set; }

            public string Nss { get; set; }

            public string Curp { get; set; }

            public string Email { get; set; }

            public string Alta { get; set; }

            public static Paciente GetById(int id){
                Paciente paciente = new Paciente();
                try
                {
                    Conexion conexion = new Conexion();
                    if (conexion.OpenConnection())
                    {
                        string query = "SELECT * FROM paciente WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conexion.connection);
                        cmd.Parameters.AddWithValue("@id", id);

                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        while (dataReader.Read()){
                            paciente.Id = int.Parse(dataReader["id"].ToString());
                            paciente.Nombre = dataReader["nombre"].ToString();
                            paciente.Apellido = dataReader["apellido"].ToString();
                            paciente.Nss = dataReader["nss"].ToString();
                            paciente.Curp = dataReader["curp"].ToString();
                            paciente.Email = dataReader["email"].ToString();
                            paciente.Alta = dataReader["alta"].ToString();

                    }
                        dataReader.Close();
                        conexion.CloseConnection();
                    }

                }
                catch (Exception ex){
                    throw ex;
                }
                return paciente;
            }


            public static List<Paciente> GetAll()
            {
                List<Paciente> pacientes = new List<Paciente>();
                try
                {
                    Conexion conexion = new Conexion();
                    if (conexion.OpenConnection()){
                        string query = "SELECT * FROM paciente ORDER BY nombre;";

                        MySqlCommand command = new MySqlCommand(query, conexion.connection);

                        MySqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read()){

                            Paciente paciente = new Paciente();
                            paciente.Id = int.Parse(dataReader["id"].ToString());
                            paciente.Nombre = dataReader["nombre"].ToString();
                            paciente.Apellido = dataReader["apellido"].ToString();
                            paciente.Nss = dataReader["nss"].ToString();
                            paciente.Curp = dataReader["curp"].ToString();
                            paciente.Email = dataReader["email"].ToString();
                            paciente.Alta = dataReader["alta"].ToString();

                        pacientes.Add(paciente);

                        }
                        dataReader.Close();
                        conexion.CloseConnection();
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return pacientes;
            }














        }
    }
