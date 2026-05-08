using System;
using System.Collections.Generic;

// a. Kelas Orang
class Orang
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Orang(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual void Aktivitas()
    {
        Console.WriteLine(Nama + " sedang beraktivitas umum.");
    }

    public void InfoOrang()
    {
        Console.WriteLine("Nama: " + Nama + ", Umur: " + Umur);
    }
}

// b. Kelas Siswa
class Siswa : Orang
{
    public string Kelas { get; set; }

    public Siswa(string nama, int umur, string kelas)
        : base(nama, umur)
    {
        Kelas = kelas;
    }

    public void Belajar()
    {
        Console.WriteLine(Nama + " sedang belajar.");
    }

    public override void Aktivitas()
    {
        Console.WriteLine(Nama + " sedang belajar di kelas " + Kelas);
    }
}

// c. Kelas Guru
class Guru : Orang
{
    public string MataPelajaran { get; set; }

    public Guru(string nama, int umur, string mapel)
        : base(nama, umur)
    {
        MataPelajaran = mapel;
    }

    public void Mengajar()
    {
        Console.WriteLine(Nama + " mengajar " + MataPelajaran);
    }

    public override void Aktivitas()
    {
        Console.WriteLine(Nama + " sedang mengajar.");
    }
}

// d. SiswaSD
class SiswaSD : Siswa
{
    public SiswaSD(string nama, int umur, string kelas)
        : base(nama, umur, kelas) { }

    public void Main()
    {
        Console.WriteLine(Nama + " sedang bermain.");
    }

    public override void Aktivitas()
    {
        Console.WriteLine(Nama + " bermain dan belajar di SD.");
    }
}

// d. SiswaSMA
class SiswaSMA : Siswa
{
    public SiswaSMA(string nama, int umur, string kelas)
        : base(nama, umur, kelas) { }

    public void UjianNasional()
    {
        Console.WriteLine(Nama + " sedang mengikuti Ujian Nasional.");
    }

    public override void Aktivitas()
    {
        Console.WriteLine(Nama + " belajar untuk persiapan ujian.");
    }
}

// e. GuruMatematika
class GuruMatematika : Guru
{
    public GuruMatematika(string nama, int umur)
        : base(nama, umur, "Matematika") { }

    public void MengajarHitung()
    {
        Console.WriteLine(Nama + " mengajar berhitung.");
    }

    public override void Aktivitas()
    {
        Console.WriteLine(Nama + " mengajar matematika.");
    }
}

// e. GuruBahasa
class GuruBahasa : Guru
{
    public GuruBahasa(string nama, int umur)
        : base(nama, umur, "Bahasa") { }

    public void MengajarBahasa()
    {
        Console.WriteLine(Nama + " mengajar bahasa.");
    }

    public override void Aktivitas()
    {
        Console.WriteLine(Nama + " mengajar bahasa.");
    }
}

// f. Kelas Sekolah
class Sekolah
{
    public List<Orang> daftar = new List<Orang>();

    public void TambahOrang(Orang orang)
    {
        daftar.Add(orang);
    }

    public void DaftarOrang()
    {
        foreach (var o in daftar)
        {
            o.InfoOrang();
            o.Aktivitas();
            Console.WriteLine();
        }
    }
}

// MAIN PROGRAM
class Program
{
    static void Main(string[] args)
    {
        Sekolah sekolah = new Sekolah();

        GuruMatematika guru1 = new GuruMatematika("Yudah", 40);
        SiswaSD siswa1 = new SiswaSD("Anang", 10, "5A");
        SiswaSMA siswa2 = new SiswaSMA("Rina", 17, "12 IPA");

        sekolah.TambahOrang(guru1);
        sekolah.TambahOrang(siswa1);
        sekolah.TambahOrang(siswa2);

        sekolah.DaftarOrang();

        // Polymorphism
        Orang o = new SiswaSD("Bagas", 9, "4B");
        o.Aktivitas();

        // Method khusus
        guru1.MengajarHitung();
        siswa2.UjianNasional();
    }
}
