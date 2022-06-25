using InventoryManagementSystem;
using Mini_Inventory_Control.UI;
using Mini_Inventory_Control.Properties;

namespace Mini_Inventory_Control
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
            Application.Run(new LoadingForm());
            Application.Run(new InventoryControlMainWindow());
        }
    }
}