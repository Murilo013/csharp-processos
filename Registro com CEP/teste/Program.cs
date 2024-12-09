using teste.Data;
namespace teste
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated(); // For�a a cria��o do banco se ele n�o existir
            }
        }
    }
}