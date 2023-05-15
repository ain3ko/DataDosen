using System;

class Dosen
{
    public string Matakuliah { get; set; }
    public string Nama { get; set; }
    public int Nik { get; set; }

    public Dosen()
    {
        // Default constructor
    }

    public void SetDosen(int nik, string nama)
    {
        Nik = nik;
        Nama = nama;
    }

    public void SetMatakuliah(string matakuliah)
    {
        Matakuliah = matakuliah;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dosen dosen = new Dosen();

        // Input data dosen
        Console.Write("Masukkan NIK dosen: ");
        int nik = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nama dosen: ");
        string nama = Console.ReadLine();
        dosen.SetDosen(nik, nama);

        // Input data matakuliah
        Console.Write("Masukkan nama matakuliah: ");
        string matakuliah = Console.ReadLine();
        dosen.SetMatakuliah(matakuliah);

        // Output data dosen dan matakuliah
        Console.WriteLine("\nData dosen dan matakuliah:");
        Console.WriteLine("NIK: " + dosen.Nik);
        Console.WriteLine("Nama: " + dosen.Nama);
        Console.WriteLine("Matakuliah: " + dosen.Matakuliah);

        Console.ReadKey();
    }
}
