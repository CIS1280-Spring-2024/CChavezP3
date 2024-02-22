//  Programed Name:CChavezP3   
//  Programed by: Colby Chhavez
//  Contact Email: cchavez572@cnm.edu
//  Program Goal: Created a logo store app per the spec that caululated te cost of items being ordered.

namespace CChavezP3
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
        }
    }
}