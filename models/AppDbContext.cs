
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class MyDbContext : DbContext
{
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        try
        {
            var connectionString = File.ReadAllText("config.txt");
            optionsBuilder.UseSqlServer(connectionString);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
            throw;
        }
    }

    public DbSet<Musteri> Musteriler { get; set; }
    public DbSet<Tedarikci> Tedarikciler{ get; set; }
    public DbSet<VerilenSiparis> VerilenSiparisler { get; set; }
    public DbSet<Siparis> Siparisler { get; set; }
    public DbSet<AlinanFatura> AlinanFaturalar { get; set; }
    public DbSet<KesilenFatura> KesilenFaturalar { get; set; }
    public DbSet<ProfilHesaplama> profilhesaplama { get; set; }



  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      
      
    }
}

// Musteri sınıfı
public class Musteri
{
    public int MusteriId { get; set; }
    public string? MusteriAdSoyad { get; set; } // Bu özelliğin tanımlı olduğundan emin olun
    public string? CariAd { get; set; }
    public string? Telefon { get; set; }
    public string? Email { get; set; }
    public string? Adres { get; set; }
    public string? VergiNo { get; set; }
    public string? VergiDairesi { get; set; }
    public string? TcKimlikNo { get; set; }
    public string? IbanBilgisi { get; set; }
    public DateTime? OlusturulmaTarihi { get; set; }
   
    
   
}
public class Tedarikci
{
    public int TedarikciID { get; set; }
    public string? TedarikciAdSoyad { get; set; } // Bu özelliğin tanımlı olduğundan emin olun
    public string? CariAd { get; set; }
    public string? Telefon { get; set; }
    public string? Email { get; set; }
    public string? Adres { get; set; }
    public string? VergiNo { get; set; }
    public string? VergiDairesi { get; set; }
    public string? TcKimlikNo { get; set; }
    public string? IbanBilgisi { get; set; }
    public DateTime? OlusturulmaTarihi { get; set; }



}

// Siparis sınıfı
public class Siparis
{
    public int SiparisID { get; set; } // SiparisID için nullable yapmaktan kaçındık
    public int? MusteriID { get; set; } // Yabancı anahtar

    // Siparis ile Musteri arasındaki ilişki
    public string? MusteriAdSoyad { get; set; } // İsteğe bağlı alan
    public string? CariAd { get; set; } // İsteğe bağlı
    public string? MakinaCalismaSaati { get; set; }
    
   
    public double? Fiyat { get; set; }
     public double? IskontoOrani { get; set; }
    public double? IskontoTutari { get; set; }
    public double? KDVOrani { get; set; }
    public double? KDVTutari { get; set; }
   
    public double? ToplamFiyat { get; set; }
    public string? SiparisDetayi { get; set; }
   
    public string? SiparisNotu { get; set; }
    public string? SiparisDurumu { get; set; }
    public DateTime SiparisAlisTarihi { get; set; } // Nullable yapılmadı
    public DateTime? SiparisTeslimTarihi { get; set; }
}
public class VerilenSiparis
{
    [Key]
    public int SiparisID { get; set; } // SiparisID için nullable yapmaktan kaçındık
    public int? TedarikciID { get; set; } // Yabancı anahtar

    // Siparis ile Musteri arasındaki ilişki
    public string? TedarikciAdSoyad { get; set; } // İsteğe bağlı alan
    public string? CariAd { get; set; } // İsteğe bağlı alan
 
   
    public double? Fiyat { get; set; }
    public double? IskontoOrani { get; set; }
    public double? IskontoTutari { get; set; }
    public double? KDVOrani { get; set; }
    public double? KDVTutari { get; set; }
    
    public double? ToplamFiyat { get; set; }

    public string? SiparisDetayi { get; set; }
    public string? SiparisNotu { get; set; }
    public string? SiparisDurumu { get; set; }
    public DateTime SiparisAlisTarihi { get; set; } // Nullable yapılmadı
    public DateTime? SiparisTeslimTarihi { get; set; }
}
public class KesilenFatura
{
    [Key]
    public int FaturaID { get; set; } // Primary key
    public string? FaturaNo { get; set; }
    public DateTime FaturaTarihi { get; set; }

    // Müşteri bilgileri
    public int? MusteriID { get; set; } // Yabancı anahtar
    public string? MusteriAdSoyad { get; set; } // İsteğe bağlı alan
    public string? CariAd { get; set; }
    public string? Tckn { get; set; }
    public string? Vkn { get; set; }
    public string? TelNo { get; set; }
    public string? Adres { get; set; }
    public string? VergiDairesi { get; set; }
    public DateTime FaturaGonderimTarihi { get; set; }
    public string? FaturaSenaryo { get; set; }
    public string? IbanBilgi { get; set; }
    public double? MalHizmetTutari { get; set; }
    public double? ToplamIskonto { get; set; }
    public double? HesaplananKdv { get; set; }
    public double? VergilerDahilTutar { get; set; }
    public double? NetTutar { get; set; }
    public string? HizmetTuru { get; set; }
    public string? Aciklama { get; set; }
    public byte[]? Belge { get; set; }
    public string? Belgeadi { get; set; }
    public string? FaturaDurumu { get; set; }   

}
// AlinanFatura sınıfı
public class AlinanFatura
{
    [Key]
    public int FaturaID { get; set; } // Primary key
    public string? FaturaNo { get; set; }
    public DateTime FaturaTarihi { get; set; }

    // Müşteri bilgileri
    public int? TedarikciID { get; set; } // Yabancı anahtar
    public string? TedarikciAdSoyad { get; set; } // İsteğe bağlı alan
    public string? CariAd { get; set; }
    public string? Tckn { get; set; }
    public string? Vkn { get; set; }
    public string? TelNo { get; set; }
    public string? Adres { get; set; }
    public string? VergiDairesi { get; set; }
    public DateTime FaturaGonderimTarihi { get; set; }
    public string? FaturaSenaryo { get; set; }
    public string? IbanBilgi { get; set; }
    public double? MalHizmetTutari { get; set; }
    public double? ToplamIskonto { get; set; }
    public double? HesaplananKdv { get; set; }
    public double? VergilerDahilTutar { get; set; }
    public double? NetTutar { get; set; }
    public string? GiderTuru { get; set; }
    public string? Aciklama { get; set; }
    public byte[]? Belge { get; set; }
    public string? Belgeadi { get; set; }
    public string? FaturaDurumu { get; set; }

}
public class ProfilHesaplama
{
    [Key]
    public int SiparisID { get; set; } // Primary key
   
    public string? MusteriAdi { get; set; }
    public string? SiparisIsmi { get; set; }
    public string? SiparisAciklamasi { get; set; }
    public string? SiparisNumarasi { get; set; }
    public double? ParcaSayi { get; set; }
    public double? DisGenislik { get; set; }
    public double? Kalinlik { get; set; }
    public double? DisYukseklik { get; set; }
    public double? KDVOrani { get; set; }
    public double? IskontoOrani { get; set; }
    public double? kdvsizindirimsiztutar     { get; set; }
    public double? MakineCalismaSaati { get; set; }
    
    public double? SaatUcreti { get; set; }
    
    public double? Uzunluk { get; set; }
    public double? IskontoTutari { get; set; } 
    public double? KDVTutari { get; set; }
    public double? nettutar { get; set; }
    public double? kdvsizindirimlitutar { get; set; }
    public double? agirlik { get; set; }
    public string? ProfilTuru { get; set; }
}