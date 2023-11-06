namespace ConsultorBiblia.Forms
{
    internal static class Program
    {
        static public Form1 signInWindow;
        static public MenuWindow menuWindow;
        static public SelectorForm selectorForm;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            signInWindow = new Form1();
            menuWindow = new MenuWindow();
            selectorForm = new SelectorForm();
            Application.Run(signInWindow);
        }
    }
}