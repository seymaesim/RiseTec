# .NetCore WepAPI Project

Rehber uygulamasında 2 ayrı Service ve Unit Test yer almaktadır.
CRUD işlemlerinin olduğu service ve Rapor işlemlerinin olduğu servis olarak ikiye ayrılmaktadır.


## Projeyi Çalıştırmak

Aşağıda ki bilgiler, geliştirme ve test etme amaçları için yerel makinenizde çalışır durumda olan projenin bir kopyasını almanızı sağlayacaktır.
Projenin canlı bir sistemde nasıl dağıtılacağına**(Kalın Örnek) ilişkin notlar için dağıtıma bakın.

### Ön Koşullar

linkten uygulamayı indirmeniz gerekmektedir.

```
https://github.com/seymaesim/ResiTec.git
```

### Yüklenmesi gereken kütüphaneler

Proje c# 2022 .NetCore 7.0 framework kullanıldı.

Katmanların hepsi için güncel kütphaneler aşağıdaki gibidir.

```
Microsoft.EntityFrameworkCore.Design 7.0.2
Microsoft.EntityFrameworkCore.Tools 7.0.2
Microsoft.EntityFrameworkCore 7.0.2
Npgsql.EntityFrameworkCore.PostgreSQL
Npgsql

```
Unit Test için yüklenmesi gereken kütphaneler aşağıdaki gibidir.

```
FakeItEasy 7.3.1
FluentAssertions 6.9.0
Microsoft.NET.Test.Sdk 17.3.2
NUnit 3.13.3
xunit 2.4.2
xunit.runner.visualstudio 2.4.5

```


## Gerekli data bilgileri

Sistem API ile CRUD işlemlerini yaparken muhakkak iletişim tipi(Kinds) verileri dolu olmalıdır.
İletişim tiplerine göre CRUD işlemleriniz gerçekleşecektir.

### Örnek Kinds


```
Telefon Numarası
E-Mail

```
İletişim tiplerinize göre çoğaltabilirsiniz.
CRUD işlemlerinizi başarılı bir şekilde yapabilirsiniz.

### Kodlama

Projede dikkat ettiğim konular,tanımlar ve prensibler


```
SOLID
N-Tier 
Unit Of Work Desing Pattern
Entity Framework
LinQ
PostgreSQL
HTTP Durum Kodları
HTTP Request
SqlInjection

```


## API Dönüşleri

* [422](https://www.restapitutorial.com/httpstatuscodes.html) - Kişi bilgileri rehberde mevcuttur.
* [203](https://www.restapitutorial.com/httpstatuscodes.html) - Dependency Management
* [200](https://www.restapitutorial.com/httpstatuscodes.html) - Başarılı
* [400](https://www.restapitutorial.com/httpstatuscodes.html) - Başarısız


## Gerekli versiyon

.NetCore [7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) için versiyon.

## Authors

* **Şeyma Yılmaz** - *WepAPI ilk çalışma* - [RiseTec](https://github.com/seymaesim/ResiTec.git)


## Teşekkürler

* Kodu kullanan herkese

