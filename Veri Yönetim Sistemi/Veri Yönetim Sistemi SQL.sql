--Veri tabaný oluþturuyoruz
create database VeriYonetimSistemi

--Çalýþacaðýmýz veritabanýný seçiyoruz
use VeriYonetimSistemi

--Kullanýcý tablosu oluþturuyoruz
CREATE TABLE Kullanici(
	KullaniciIdPk int IDENTITY(2,2) NOT NULL,
	Ad varchar(50) NOT NULL,
	Soyad varchar(50) NOT NULL,
	KullaniciAd varchar(50) NOT NULL,
	KullaniciSifre nvarchar(64) NOT NULL,
	KullaniciTuru varchar(30) NOT NULL
)

