using LinkedList.Inventori;
using LinkedList.ManajemenKaryawan;
using LinkedList.Perpustakaan;

namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        // Soal Perpustakaan
        KoleksiPerpustakaan perpustakaan = new KoleksiPerpustakaan();
        perpustakaan.TambahBuku(new Perpustakaan.Buku("The Hobbit", "J.R.R. Tolkien", 1937));
        perpustakaan.TambahBuku(new Perpustakaan.Buku("1984", "George Orwell", 1949));
        perpustakaan.TambahBuku(new Perpustakaan.Buku("The Catcher in the Rye", "J.D. Salinger", 1951));
        Console.WriteLine("Data Perpustakaan:");
        perpustakaan.TampilkanKoleksi();
        Console.WriteLine();
        
        // Soal ManajemenKaryawan
        DaftarKaryawan daftarKaryawan = new DaftarKaryawan();
        daftarKaryawan.TambahKaryawan(new ManajemenKaryawan.Karyawan("001", "John Doe", "Manager"));
        daftarKaryawan.TambahKaryawan(new ManajemenKaryawan.Karyawan("002", "Jane Doe", "HR"));
        daftarKaryawan.TambahKaryawan(new ManajemenKaryawan.Karyawan("003", "Bob Smith", "IT"));
        Console.WriteLine("Data Karyawan (Urutan Tampil Terbalik):");
        daftarKaryawan.TampilkanDaftar();
        Console.WriteLine();
        
        // Soal Inventori
        ManajemenInventori inventori = new ManajemenInventori();
        inventori.TambahItem(new Inventori.Item("Apple", 50));
        inventori.TambahItem(new Inventori.Item("Orange", 30));
        inventori.TambahItem(new Inventori.Item("Banana", 20));
        Console.WriteLine("Data Inventori:");
        inventori.TampilkanInventori();
    }
}
