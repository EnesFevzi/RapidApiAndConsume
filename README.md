# RapidApiAndConsume

Hotel Reservation Website

![image](https://github.com/EnesFevzi/RapidApiAndConsume/assets/118919666/0f73e689-5544-4597-91dd-42b0f5444357)


![image](https://github.com/EnesFevzi/RapidApiAndConsume/assets/118919666/536f9c5a-1ef4-42be-b5a8-d22c1f40d215)



![image](https://github.com/EnesFevzi/RapidApiAndConsume/assets/118919666/9e0c5f06-a316-4387-9445-9173e32e1630)


![image](https://github.com/EnesFevzi/RapidApiAndConsume/assets/118919666/bb717eb2-2969-43bf-b92b-6bcf56780b3e)


![image](https://github.com/EnesFevzi/RapidApiAndConsume/assets/118919666/e81b7102-28b1-46f2-9a1f-ecc27f13621b)

# Hotel Rezervasyon Projesi

Hotel Rezervasyon Projesi, ASP.NET Core 6.0 ve Entity Framework Core kullanılarak geliştirilmiş bir web uygulamasıdır. Bu proje, kullanıcı dostu bir arayüz ve güçlü veri yönetimi ile otel rezervasyon deneyimini iyileştirmeyi hedefler.

## Özellikler

- Kullanıcılar, web sitesine kayıt olarak otel rezervasyonları yapabilirler.
- Kullanıcılar, arama ve filtreleme seçenekleriyle istedikleri tarih aralığında uygun otelleri bulabilirler.
- Kullanıcılar, otel detayları sayfasında otel hakkında bilgilere, fotoğraflara ve oda seçeneklerine ulaşabilirler.
- Kullanıcılar, seçtikleri odaları rezerve edebilir ve rezervasyonlarını yönetebilirler.
- Admin kullanıcıları, otelleri ve odaları yönetebilir, rezervasyonları onaylayabilir ve site ayarlarını düzenleyebilirler.

## Teknolojiler ve Araçlar

- ASP.NET Core 6.0
- Entity Framework Core
- HTML, CSS, Bootstrap
- SQL Server
- RapidAPI ve ApiConsume (API entegrasyonu için kullanıldı)

## Kurulum ve Çalıştırma

1. Depoyu bilgisayarınıza klonlayın.
2. SQL Server üzerinde bir veritabanı oluşturun.
3. appsettings.json dosyasında veritabanı bağlantı dizesini güncelleyin.
4. `dotnet ef database update` komutunu çalıştırarak veritabanı tablolarını oluşturun.
5. Projeyi çalıştırın ve web uygulamasını tarayıcınızda görüntüleyin.


## RapidAPI ve ApiConsume, API (Application Programming Interface) hizmetlerini kullanmayı kolaylaştıran araçlardır.

RapidAPI, farklı hizmet sağlayıcıların sunduğu API'leri tek bir yerden erişilebilir hale getiren bir platformdur. Bu platform, geliştiricilere geniş bir API koleksiyonuna erişme imkanı sağlar. RapidAPI üzerinden çeşitli kategorilerdeki API'lere erişebilir, bu API'lerin belgelerini ve kullanım kılavuzlarını inceleyebilir ve projelerinizde bu API'leri kullanabilirsiniz. RapidAPI'nin sunduğu avantajlardan biri, API'lere erişmek ve entegrasyonlarınızı yönetmek için tek bir arayüz sağlamasıdır. Böylece farklı API'ler için ayrı ayrı hesaplar oluşturmanıza gerek kalmaz.

ApiConsume ise, kendi API'lerinizi oluşturmanıza ve yönetmenize olanak tanıyan bir araçtır. Bu araç sayesinde, projenizde ihtiyaç duyduğunuz özel veri kaynaklarına erişmek için özelleştirilmiş API'ler oluşturabilirsiniz. ApiConsume, API endpointlerini tanımlamanıza, giriş parametrelerini ayarlamanıza ve API'den gelen verilere erişmenizi sağlar. Böylece API'lerinizi projenizin geri kalanıyla entegre edebilir ve verileri daha etkili bir şekilde kullanabilirsiniz.

Her iki araç da geliştiricilerin API'leri kolayca kullanmasına ve projelerinde veri entegrasyonunu sağlamasına yardımcı olur. RapidAPI, farklı hizmet sağlayıcıların API'lerine erişimi kolaylaştırırken, ApiConsume kendi API'lerinizi oluşturmanızı ve yönetmenizi sağlar.
