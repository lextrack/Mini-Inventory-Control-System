namespace Mini_Inventory_Control.Forms
{
    static class Connections
    {
        private static string cadena = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='database.xlsm';Extended Properties='Excel 8.0;IMEX=1;';";
        public static System.Data.OleDb.OleDbConnection Conexion;
        public static Application xlibro;

        public static void OpenConnection()
        {
            Conexion = new System.Data.OleDb.OleDbConnection(cadena);
            //Conexion.Open();
        }
    }
}