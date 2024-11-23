using System.Data;
using System.Data.SqlClient;
using static System.Console;
namespace sqldata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tablonum;
            WriteLine("***** C# Veri Tabanı Ürün-Kategori Bilgi Sistemi *****");
            WriteLine();
            WriteLine();
            WriteLine("---------------------------------------");
            WriteLine("1-Kategoriler");
            WriteLine("2-Ürünler");
            WriteLine("3-Siparişle");
            WriteLine("4-Çıkış Yap");
            Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tablonum = ReadLine();
            WriteLine("---------------------------------------");

            SqlConnection Connection = new SqlConnection("Data Source=LAPTOP-4ROLKKOD;initial Catalog=set caffee;integrated security=true");
              
            Connection.Open();

            SqlCommand commad = new SqlCommand("Select * from TBLkategori",Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commad);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Connection.Close();
            
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item1 in row.ItemArray)
                {
                    Write(item1.ToString());
                }
                WriteLine();
            }
            Read();
        }
    }
}

