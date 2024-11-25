 Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
 Console.WriteLine();
 Console.WriteLine("---------------------");
 #region Kategöri Eklemek
 //Console.Write("Eklemek istediğiniz kategori adı: ");
 //string categoryname = Console.ReadLine();

 //SqlConnection connection2 = new SqlConnection("Data Source=LAPTOP-4ROLKKOD;initial catalog=set caffee;integrated security=true");
 //connection2.Open();
 //SqlCommand command = new SqlCommand("insert into TBLkategori (menus) values (@p1) ",connection2);
 //command.Parameters.AddWithValue("@p1", categoryname);
 //command.ExecuteNonQuery();
 //command.Clone();
 //Console.WriteLine("başarıyla ekleding!");
 #endregion
 #region Ürün Eklemek
 //string porsiyon_isim;
 //decimal porsiyon_fiyat;
 ////bool porsiyon_durum = false;
 //Console.Write("ürün adı: ");
 //porsiyon_isim = Console.ReadLine();
 //Console.Write("ürün fiyatı: ");
 //porsiyon_fiyat = decimal.Parse(Console.ReadLine());
 //SqlConnection sqlconnec = new SqlConnection("Data Source=LAPTOP-4ROLKKOD;initial catalog=set caffee;integrated security=true");
 //sqlconnec.Open();
 //SqlCommand cmd = new SqlCommand("insert into TBLurun (urunname,urunfiyat,urundurum) values (@p1,@p2,@p3)", sqlconnec);

 //cmd.Parameters.AddWithValue("@p1", porsiyon_isim);
 //cmd.Parameters.AddWithValue("@p2", porsiyon_fiyat);
 //cmd.Parameters.AddWithValue("@p3", true);
 //cmd.ExecuteNonQuery();

 //cmd.Clone();
 //Console.Write("ürün ekleme işlemi başarılı!");

 //sqlconnec.Close();
 #endregion
 #region ürün listelemek
 //SqlConnection Connection = new SqlConnection("Data Source=LAPTOP-4ROLKKOD;initial Catalog=set caffee;integrated security=true");
 //Connection.Open();
 //SqlCommand Command = new SqlCommand("select * from tblproduct",Connection);
 //SqlDataAdapter Adapter = new SqlDataAdapter(Command);
 //DataTable table = new DataTable();
 //Adapter.Fill(table);
 //string bos = "                 ";
 //foreach (DataRow row in table.Rows)
 //{
 //    foreach (var item in row.ItemArray)
 //    {
 //        Console.Write(item.ToString() + " ");
 //    }
 //    Console.WriteLine();
 //}

 //Connection.Close();

 #endregion
 #region ürün silmek
 //Console.Write("silmek için ıd gir: ");
 //int ıd = int.Parse(Console.ReadLine());
 //SqlConnection Connection = new SqlConnection("Data Source=LAPTOP-4ROLKKOD;initial Catalog=set caffee;integrated security=true");
 //Connection.Open();
 //SqlCommand cmd = new SqlCommand("delete from tblproduct where urunıd=@p1",Connection);
 //cmd.Parameters.AddWithValue("@p1", ıd);
 //cmd.ExecuteNonQuery();
 //Connection.Close();
 //Console.WriteLine("işlem başarılı");
 #endregion
 #region ürün güncellemek
 //Console.Write("güncelenecek ürün ıd: ");
 //int urunıd = int.Parse(Console.ReadLine());
 //Console.Write("güncelenecek ürün adı: ");
 //string urunname = Console.ReadLine();
 //Console.Write("güncelenecek ürün fiyatı: ");
 //decimal urunfiyat = decimal.Parse(Console.ReadLine());

 //SqlConnection Connection = new SqlConnection("Data Source=LAPTOP-4ROLKKOD;initial Catalog=set caffee;integrated security=true");
 //Connection.Open();
 //SqlCommand Command = new SqlCommand("update tblproduct set urunname=@urunisim,urunfiyat=@fiyat where urunıd=@ıd",Connection);
 //Command.Parameters.AddWithValue("@urunisim", urunname);
 //Command.Parameters.AddWithValue("@fiyat", urunfiyat);
 //Command.Parameters.AddWithValue("@ıd", urunıd);
 //Command.ExecuteNonQuery();
 //Connection.Close();
 //Console.WriteLine("işlem bitti haydi hayırlısı :)");
 #endregion