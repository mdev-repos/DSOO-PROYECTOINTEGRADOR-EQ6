using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivoApp.Datos;
using ClubDeportivoApp.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.Design.AxImporter;

namespace ClubDeportivoApp
{
    public partial class Inscripcion : Form
    {
        bool estado;
        public Inscripcion()
        {
            InitializeComponent();
        }

        //LOGICA DEL BOTON INSCRIBIR
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            //======== VALIDACIONES ========//

            // 1. Validar campos obligatorios
            if (!ValidarCamposObligatorios()) return;

            // 2. Validar formato de campos
            if (!ValidarFormatos()) return;

            // 3. Validar ficha médica
            if (!rbtnFichaMedica.Checked)
            {
                MessageBox.Show("Debe presentar la ficha médica para continuar",
                              "FICHA MÉDICA REQUERIDA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            //======== INSCRIPCION SOCIO ========//
            if (rbtSocio.Checked)
            {
                ProcesarInscripcionSocio();
            }

            //======== INSCRIPCION NO SOCIO ========//
            if (rbtNoSocio.Checked)
            {
                ProcesarInscripcionNoSocio();
            }

        }


        //======== METODOS DE VALIDACIONES ========//
        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                dtpFechaNac.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Debe completar todos los campos obligatorios marcados con (*)",
                               "CAMPOS OBLIGATORIOS",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidarFormatos()
        {
            // Validar nombre y apellido (solo letras y espacios)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtApellido.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MessageBox.Show("Nombre y apellido solo deben contener letras",
                               "FORMATO INCORRECTO",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }
            // Validar DNI (solo números, 7-8 dígitos)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDni.Text, @"^\d{7,8}$"))
            {
                MessageBox.Show("El DNI debe contener entre 7 y 8 dígitos numéricos",
                               "DNI INVÁLIDO",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }
            // Validar teléfono (opcional pero si existe debe ser válido)
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                !System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, @"^[\d\s\-\(\)]{6,20}$"))
            {
                MessageBox.Show("El teléfono debe contener solo números, espacios, guiones o paréntesis",
                               "TELÉFONO INVÁLIDO",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }
            // Validar email
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(txtEmail.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese un email válido (ejemplo: usuario@dominio.com)",
                               "EMAIL INVÁLIDO",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //======== METODOS DE INSCRIPCION DE SOCIO ========//
        private void ProcesarInscripcionSocio()
        {
            string respuesta;

            //CREACION DEL SOCIO A PARTIR DE LOS CAMPOS RECIBIDOS
            E_Socio socio = new E_Socio();
            socio.Nombre = txtNombre.Text;
            socio.Apellido = txtApellido.Text;
            socio.Dni = Convert.ToInt32(txtDni.Text);
            socio.FechaNac = dtpFechaNac.Value;
            socio.Direccion = txtDireccion.Text;
            socio.Telefono = txtTelefono.Text;
            socio.Email = txtEmail.Text;
            socio.FichaMedica = estado;
            socio.CodSocio = $"SOC-{socio.Dni}";
            socio.Carnet = true;
            socio.FechaInscripcion = DateTime.Now.ToString("yyyy-MM-dd");
            socio.Moroso = false;

            //PERSISTENCIA DEL SOCIO EN BBDD
            Datos.Socio socioDatos = new Datos.Socio();
            respuesta = socioDatos.Nuevo_Socio(socio);

            //EVALUACION DE LA PERSISTENCIA
            if (respuesta == "1")
            {
                MessageBox.Show("El socio ya existe", "AVISO DEL SISTEMA",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (respuesta == "0")
            {
                //CREACION DE LA PRIMERA CUOTAMENSUAL DEL SOCIO
                E_CuotaMensual primerCuota = new E_CuotaMensual();
                primerCuota.NroCuota = 1;
                primerCuota.CodCuota = $"CUOTA-0{primerCuota.NroCuota}-{socio.CodSocio}";
                primerCuota.Vencimiento = DateTime.Now;
                primerCuota.ValorMensual = 25000f;
                primerCuota.Pagada = false;
                primerCuota.CodSocio = socio.CodSocio;

                //PERSISTENCIA DE LA CUOTA EN BBDD
                CuotaMensual cuotaDatos = new CuotaMensual();
                string respuestaCuota = cuotaDatos.GenerarPrimerCuota(primerCuota);

                //EVALUACION DE LA PERSISTENCIA
                if (respuestaCuota != "0")
                {
                    MessageBox.Show("Error al generar la cuota: " + respuestaCuota,
                                   "ERROR",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }

                //APERTURA DE UNA VENTANA PAGAR CON LOS DATOS DE LA CUOTA GENERADA
                Pagar formPago = new Pagar(socio, primerCuota);
                formPago.ShowDialog();

                //RETORNO DEL AREA DE PAGO. MENSAJE DE EXITO EN LA INSCRIPCION
                if (formPago.PagoRealizado)
                {
                    MessageBox.Show($"Inscripción del Socio {socio.CodSocio} completada correctamente!\n" +
                              $"Cuota inicial pagada: {primerCuota.CodCuota}",
                              "INSCRIPCIÓN EXITOSA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                   this.Close();
                }
                else
                {
                    MessageBox.Show("Error al generar la cuota inicial: " + respuestaCuota,
                                  "ERROR",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Error al guardar al Socio en Base de Datos", "AVISO DEL SISTEMA",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        //======== METODOS DE INSCRIPCION DE NO SOCIO ========//
        private void ProcesarInscripcionNoSocio()
        {
            string respuesta; 
            E_NoSocio nosocio = new E_NoSocio();
            nosocio.Nombre = txtNombre.Text;
            nosocio.Apellido = txtApellido.Text;
            nosocio.Dni = Convert.ToInt32(txtDni.Text);
            nosocio.FechaNac = dtpFechaNac.Value;
            nosocio.Direccion = txtDireccion.Text;
            nosocio.Telefono = txtTelefono.Text;
            nosocio.Email = txtEmail.Text;
            nosocio.FichaMedica = estado;
            nosocio.CodNoSocio = $"NOSOC-{nosocio.Dni}";

            Datos.NoSocio noSocioDatos = new Datos.NoSocio();
            respuesta = noSocioDatos.Nuevo_NoSocio(nosocio);
            bool esNumero = int.TryParse(respuesta, out int codigo);
            if (esNumero)
            {
                if (codigo == 1)
                {
                    MessageBox.Show("El no socio ya existe", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"El no socio {nosocio.Nombre} {nosocio.Apellido} se registró con éxito con el código número: {nosocio.CodNoSocio} " + respuesta,
                         "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }
                    
        private void Inscripcion_Load(object sender, EventArgs e)
        {

        }

        private void rbtnFichaMedica_CheckedChanged(object sender, EventArgs e)
        {

            estado = rbtnFichaMedica.Checked;
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtSocio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtNoSocio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Application.OpenForms.OfType<Opciones>().Any())
                {
                    Application.OpenForms.OfType<Opciones>().First().Show();
                }
                else
                {
                    Opciones opciones = new Opciones();
                    opciones.Show();
                }
                this.Close();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro que desea limpiar todos los campos?", "AVISO DEL SISTEMA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                rbtSocio.Checked = false;
                rbtNoSocio.Checked = false;
                txtNombre.Clear();
                txtApellido.Clear();
                txtDni.Clear();
                dtpFechaNac.Value = DateTime.Now;
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                rbtnFichaMedica.Checked = false;
            }
        }
    }
}
