### Gelecek Varlık Full Stack Developer Bootcamp **Week5**

<br>
<br>

#### 4. Hafta hazırladığım projenin üzerine bazı özellikler ekledim.

<br>

<ul>
  <li>Memory cache kavramı işlenip projeye dahil edildi.</li>
  <li>Ürün tablosundaki ürünlere müdehale etmek için kullanıcının giriş yapmış olması ve yetkili olması gerekiyor. Bunu sağlamak için bir LoginFilter tanımlandı.</li>
  <li>Yetkili olmayan kişi kesinlikle işlem yapamaz. Eğer yetkisi var ve işlem yapmak istiyorsa önce giriş yapmalı.</li>
  <li>Ürünlerin listelenmesini daha efektif hale getirdim. Filtreleme(isme göre), sıralama(ürün ismi veya fiyata göre), sayfalama(istenilen ürün sayısı ve sayfa sayısına göre ürünlerin çağırılması) sağlandı.</li>
  <li>Projenin ilk haline göz atmak isterseniz linke tıklayınız => <a href="https://github.com/kemiksizt/Gelecek-Varlik-Bootcamp/tree/master/Week3">Week3</a></li>
  <li>Projeye MemoryCache yerine DistributedCache eklendi.</li>
  <li>Projenin Web katmanında çalışması için bir arayüz oluşturuldu. View içerisinden sayfalara ulaşabilirsiniz.</li>
  <li>API katmanında yapılan tüm işlemler Web katmanında da çalıştırıldı.</li>
  <li>Login sonrasında veri belirli bir süre Cache de tutulur. Bu süre içerisinde tekrar siteye giriş yapılırsa login olmadan direkt ürünlerin listelendiği sayfaya ulaşılır.</li>
  <li>Login işleminden sonra ürün listeleme sayfasında kullanıcı eğer yetkili ise ekleme, güncelleme ve silme butonlarını görebilir ve işlemleri gerçekleştirebilir.</li>
  <li>Kullanıcı admin değil ise yalnızca ürünleri görüntüleyebilir. Hiçbir işlem yapamaz ! </li>
  <li></li>
</ul>