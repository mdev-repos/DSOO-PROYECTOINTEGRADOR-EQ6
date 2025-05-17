namespace ClubDeportivoApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Opciones());

           
            using (Login loginForm = new Login())
            {
                if (loginForm.ShowDialog() == DialogResult.OK && loginForm.Autenticado)
                {
                    // Aquí puedes pasar la información del usuario al formulario principal si es necesario
                    Application.Run(new Opciones());
                }
                else
                {
                    Application.Exit();
                }
            }
            
        }
    }
}