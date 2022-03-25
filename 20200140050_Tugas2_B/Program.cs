using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200140050_Tugas2_B
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-5B0DFV64;database=Andi;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("Insert into Pembeli (Id_Pembeli,Nama_Pembeli,Umur_Pembeli,Jk_Pembeli, Penyakit) values ('101010','Andi','12','L','Flu')"
                    + "Insert into Pembeli (Id_Pembeli,Nama_Pembeli,Umur_Pembeli,Jk_Pembeli,Penyakit) values ('202020', 'Septi','20','P','Sakit Gigi')"
                    + "Insert into Pembeli (Id_Pembeli,Nama_Pembeli,Umur_Pembeli,Jk_Pembeli,Penyakit) values ('303030', 'Reza','21','L','Mag')"
                    + "Insert into Pembeli (Id_Pembeli,Nama_Pembeli,Umur_Pembeli,Jk_Pembeli,Penyakit) values ('404040', 'Putri','12','P','Flu')"
                   + "Insert into Pembeli (Id_Pembeli,Nama_Pembeli,Umur_Pembeli,Jk_Pembeli,Penyakit) values ('505050', 'Duwi','23','P','Demam')"
                   + "Insert into Transaksi (Id_Transaksi,Jumlah,Biaya,Id_Pembeli) values ('01','2','15.000','101010')"
                   + "Insert into Transaksi (Id_Transaksi,Jumlah,Biaya,Id_Pembeli) values ('02','1','10.000','202020')"
                   + "Insert into Transaksi (Id_Transaksi,Jumlah,Biaya,Id_Pembeli) values ('03','1','5.000','303030')"
                   + "Insert into Transaksi (Id_Transaksi,Jumlah,Biaya,Id_Pembeli) values ('04','1','10.000','404040')"
                   + "Insert into Transaksi (Id_Transaksi,Jumlah,Biaya,Id_Pembeli) values ('05','2','18.000','505050')"
                   + "Insert into Pegawai (Id_Pegawai,Gaji,Umur_Pegawai,Jk_Pegawai,Jabatan) values ('100','2.000.000','30','L','peracik obat')"
                   + "Insert into Pegawai (Id_Pegawai,Gaji,Umur_Pegawai,Jk_Pegawai,Jabatan) values ('200','2.000.000','25','P','peracik obat')"
                   + "Insert into Pegawai (Id_Pegawai,Gaji,Umur_Pegawai,Jk_Pegawai,Jabatan) values ('300','1.500.000','28','P','Penjaga kasir')"
                   + "Insert into Pegawai (Id_Pegawai,Gaji,Umur_Pegawai,Jk_Pegawai,Jabatan) values ('400','4.000.000','30','L','Manager Apotek')"
                   + "Insert into Pegawai (Id_Pegawai,Gaji,Umur_Pegawai,Jk_Pegawai,Jabatan) values ('500','2.000.000','24','P','peracik obat')"
                   + "Insert into Obat (Id_Obat,Nama_Obat,Jenis,Stok,Harga) values ('101','OBH COMBI','Obat Flu','300','7.500')"
                   + "Insert into Obat (Id_Obat,Nama_Obat,Jenis,Stok,Harga) values ('102','Ibuprofen','Obat Peredah nyeri','50','10.000')"
                   + "Insert into Obat (Id_Obat,Nama_Obat,Jenis,Stok,Harga) values ('103','promag','Obat Mag','400','5.000')"
                   + "Insert into Obat (Id_Obat,Nama_Obat,Jenis,Stok,Harga) values ('104','AntibiotikI','Obat Mengatasi bakteri','300','10.000')"
                   + "Insert into Obat (Id_Obat,Nama_Obat,Jenis,Stok,Harga) values ('105','Paracetamol','Obat demam','300','9.000')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses Menambah Data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }

        }
    }
}