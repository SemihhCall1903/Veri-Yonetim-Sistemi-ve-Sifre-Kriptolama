--Veri taban� olu�turuyoruz
create database VeriYonetimSistemi

--�al��aca��m�z veritaban�n� se�iyoruz
use VeriYonetimSistemi

--Kullan�c� tablosu olu�turuyoruz
CREATE TABLE Kullanici(
	KullaniciIdPk int IDENTITY(2,2) NOT NULL,
	Ad varchar(50) NOT NULL,
	Soyad varchar(50) NOT NULL,
	KullaniciAd varchar(50) NOT NULL,
	KullaniciSifre nvarchar(64) NOT NULL,
	KullaniciTuru varchar(30) NOT NULL
)

