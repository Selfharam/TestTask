using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
namespace Test
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            /*
            //DESKTOP-24S5SPT
            string connectionString = "Server=DESKTOP-24S5SPT\\MSSQLSERVER1;Database=test;User Id=test;Password=test;Encrypt=False;Trusted_Connection=False";
            SqlConnection connection = new SqlConnection(connectionString);

           
                try
                {
                // ��������� �����������
                await connection.OpenAsync();
                System.Console.WriteLine("����������� �������");
                
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                
            }
                finally
                {
                    // ���� ����������� �������
                    if (connection.State == ConnectionState.Open)
                    {
                    
                    // ��������� �����������
                    await connection.CloseAsync();
                    Console.WriteLine("����������� �������...");
                    }
                }
                Console.WriteLine("��������� ��������� ������.");
                Console.Read();
            */

            string connectionString = "Server=DESKTOP-24S5SPT\\MSSQLSERVER1;Database=test;User Id=test;Password=test;Encrypt=False;Trusted_Connection=False";
            //SqlConnection connection = new SqlConnection(connectionString);






            SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

            




           ApplicationConfiguration.Initialize();
           Application.Run(new Form1(connection));
        }
    }
}