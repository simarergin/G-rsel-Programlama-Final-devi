# Görsel Programlama Winform ile Okul İdare Sistemi


Bu proje **.net freamwork** ile **Windows form** uygulaması kullanılarak oluşturulmuştur. 

Model1.edmx, **ADO.NET Entity Data Model** eklenerek database bağlantısının sağlandığı ve db  diagramının gözüktüğü kısımdır.

İlk olarak Form1 projenin anasayfasıdır. Bu kısımda **menuStrip** eklenerek projemize bir navbar eklemiş oluyoruz. *Anasayfa, Ders, Personel ve Öğrenci* başlıklarından oluşmaktadır. Bu başlıkların her birinin altında *giriş* ve *listele* kısımları bulunmaktadır. Öğrenci kısmında ekstra olarak dersler bulunmaktadır. Öğrenci Dersler kısmı dersId ve ögrenciId verileri ortak olduğu için manuel değil otomatik veri çekimi sağlamaktadır. Bu yüzden sadece listeleme alanı bulunmaktadır. En başta da bulunan Anasayfa butonundan da tıklayarak çıkış sağlanabilmektedir.

Ana ekrana menuStrip altına *toolStrip* eklenmiştir. Bunun sebebi ise comboBox ile seçim yaparak gidilmesi istenilen form seçilip butona tıklanıldığında o forma yönlendirilmektedir. Bu kısım toolStrip butonu aktifleştirilerek yapılmıştır.

Son olarak Form1 e *statusStrip* eklenmiştir. Bu aracın işlevi ise sayfa durumlarını belirtmektir. Hangi sayfaya giriş yapılıyorsa alt kısımda o sayfa bildiriliyor.

Form1.cs yani kod kısmına gelecek olursak tüm menü itemleri click ile aktifleştirilmesi sağlandı. Her birinin altında *MdiParent* ile form içinde form açılması sağlanmaktadır. Ana ekranda sayfanın durumunu anlatan statusStrip’in yazdırılmasında hangi sayfa açılıyorsa o forma tıklanıldığı yazan bir text yazılıyor.

### Forms Kısmı; <br/>
DersGiris.cs <br/>
DersListe.cs <br/>
OgrenciGiris.cs <br/>
OgrenciListe.cs <br/>
OgreniDers.cs <br/>
PersonelGiris.cs <br/>
PersonelListe.cs <br/>
Bu sınıflardan oluşmaktadır.

Genel olarak bakıldığında giriş kısımlarında verilerin girileceği *textbox, combobox ve datetime* ların oluşturduğu alanlar vardır. Bu bilgilerin kaydedilmesi için **KAYDET** butonu, çıkışı sağlanması için ise **ÇIKIŞ** butonu oluşmaktadır.

Liste sınıflarında datagridview bulunmaktadır. Giriş kısmında verilen bilgiler database üzerinden kaydediliyor ve ardından datagridview de oluşturduğumuz sütunlara sırasıyla yazdırılmaktadır.

Datagridview üzerinden sütun düzenlemeden dataların *property name* kısımlarına kendi db nizde hangi isimle yazılıysa o şekilde kaydedilmelidir. Bunun sebebi ise veriler kolonlara göre ayrılıp yazılırken doğru kolonlara doğru bilgilerin kaydedilmesi içindir.

Datagridview kısımlarına veri eklenirken iki adet *button column* eklendi. **Güncelle** ve **sil** butonlarına tıklanarak veriler üzerinde değişiklik yapmamıza ya da verileri silmemize yardımcı olmaktadır.

Listeleme kısımlarında belirlenen değer aralıklarına renklendirme işlemi yapılmaktadır. Hangi kolonu seçtiğiniz ve hangi aralığın ne renk alınmasını istiyorsanız bu değerler girilip renklendirme işlemi yapılmaktadır.






