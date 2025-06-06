﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp.Datos
{
    public class Conexion
    {
        // declaramos las variables   
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()  // asignamos valores a las variables de la conexion  
        {
            this.baseDatos = "clubdeportivo";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "3171";
        }

        // proceso de interacción  
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion  
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores  
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
                return cadena; // Devuelve la conexión si todo es correcto  
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }
        // para evaluar la instancia de la conectividad  
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada  
            {
                con = new Conexion(); // se crea una nueva  
            }
            return con;
        }
    }
}
