# MvcProjeKampi

> Eğitmen --------------> https://www.linkedin.com/in/murat-y%C3%BCceda%C4%9F-186933149/

> Youtube Kanalı -------> https://www.youtube.com/user/YazilimHerYerde

> Eğitim Tarihi --------> 19/09/2022

# Eğitim Notları

* Proje türü ASP.Net Web Application (.Net Framework) - Visual C#
* Projenin ismininde olduğu katmana **user interface** ya da **presentation layer** denir.

> MVC 3 temel yapıdan oluşuyor;
> * **Model** veri tabanına ait **entity** denilen kavramların tanımlandığı kısımdır.
> * **View** işin tasarım Front End kısmının yapıldığı alandır.
> * **Controller** işin Backend kısmının yapıldığı alandır. (HomeController.cs)

> Bir yapının metod olduğunu sonunda parantez açılıp kapandığından anlayabilir.
> Örneğin; Index(), About(), Contact()
> * **Index** metodu genellikle listeleme işlemi için kullanılır. Veriler listelenirken index isminde bir metod ile listeleniyor.
> * **About** metodu uygulama ile ilgili bilgileri için kullanılan metottur.
> * **Contact** metodu iletişim bilgileri için kullanılan metottur.
> * Tanımlanan metodların tamamının Views tarafında mutlaka bir karşılığı olmalıdır.

> Controllers altında tanımlı veya tarafımızca tanımlanacak olan metodların Views > Home dizini altında ayrı ayrı karşıklarının var olması gerekir. 
> * Örneğin About.cshtml olana tıkladığımızda karşımıza gelen sayfa işin HTML yani Front End tarafının yazıldığı kısımdır. Web sayfası açıldığında karşımıza çıkan menülerdir.

> Web sayfaları değişse bile sabit kalan kısıma **Layout** - eski teknolojiler ismi **Master Page**, HTML kısmında ise bizi N - ayrıca bir diğer sabit kalan kısım ise **footer** diye adlandırılan alt kısımdır yıl değeriyle başlayan, değişen kısıma ise **Content** denir. 

> **br** ifadesi bir boşluk bırakır.
> **h6** yüksekliği temsil ediyor. h1 en yüksek, h6 ise en düşüktür.

> Metot tanımlamaların türleri vardır. 
> * Örneğin **ActionResult** gibi. String, integer vb. gibi veri tipleri tanımlanabilir. Metot yayınlama türü olarak *public* yani herkese açık bir örneğidir.

> Her metot bir sayfa döndürür. Bu sebeple controllers üzerinde tanımlanan metoda sağ tıklayıp **Add View** diyerek *Views* yapısı üzerinde bir sayfaya attach edilir. Bu işlem sırasında sayfasımızı bir Layout a bağlı olarak çalıştırmak istediğimizde çıkan pencerede ... ya basılır ve Views > Shared a gidilir. 

> Bir metot tanımlanıp Views kısmında bir Layout a bağlandıktan sonra görüntülemek için mevcut sayfanın yenilenmesi yetmez, değişiklikler yapıldıktan sonra derlemek gerekir. Sağ tıklayıp view in browser seçilmelidir. 

> SOLID prensipleri gereği, projede yapılacak her bir menü alanı bir controllerda tutulacaktır. Başlıklar, kullanıcılar, yazılar, admin vb.

> Bir controller tanımlandığında bize otomatik olarak sunulan Index metodunu bir View oluşturmak için kullanırız. Öncesinde ise bir Layout tanımlanır. 
> Views > Shared altında bir view tanımladığımızda herhangi bir layout u kullanmazsa kendisi bir layout olur. Bu sayfayı sağ tık ile browserda açamayız. Bunun için bir controllerda tanımlı olması gerekir.

> **RenderBody çağırılmadı hatası** oluşturmuş olduğumuz layout un içerisine sayfaları yüklerken ben bu sayfaları layout un hangi kısmına getireceğim sorusunun cevabını vermediğimiz için bu hatayı alırız. 
> * Örneğin div lerin arasına getir diyebiliriz. Bunu RenderBody metoduyla razer syntax ı ile yapabiliriz. Yani HTML tarafında C# komutları girebiliriz. Bunu ise komutların başına @ sembolü ekleriz. 
> * Front End tarafında yapılan değişiklikler sayfa yenileyerek gözlemlenebilirken, Backend kısmında bu durum söz konusu değildir.

> Browser sekmesinde mevcut görüntülenen isim HTML kodun içerisindeki title kısmında saklanıyor. Değişiklik oradan yapılabilir.

> n katmanlı mimarı katmanları;
> * 1- **Entity Layer** - Projenin SQL tarafındaki tabloların ve bu tabloların içerisinde yer alacak sütunların tanımlanacağı ve bunların C# tarafındaki adı property ve class olarak karşımıza gelecek olan yapıyı tutacak kısımdır. Başlıklar Entity sinin içinde yer olan propertyler örneğin; başlık id, başlık isim, başlık tarihi, başlık yazar. Burada Başlıklar bir tablo ve örnek verilenler ise sütunlar olacak. Tabloların ismi C# tarafında sınıf, sütünlar ise property olarak adlandırılacaktır.. 
> * 2- **Data Access Layer** - *Crud* -Create, Read, Update, Delete- işlemlerinin temeli bu katmanda tanımlanır.
> * 3- **Business Layer** - Business Layer E Ticaret sitesi üzerinden örnek verecek olursak sunum katmanına veriler çıkmadan önce bu verilerle ilgili olarak ürün adı maksimum 20 karakter olsun, ürün ekleme, çıkarma veya değişiklik yapma işlerini şu kişi yapabilsin vb. işlerin yapıldığı katmandır.
> * 4- **Presentation Layer** - UI - User Interface
> * Bu katmanlar Solution + Proje adı kısmına gelip add dedikten sonra Class Library (.Net Framework) seçilerek eklenir. İsimlendirme ilk harfler büyük ve birleşik olmasına dikkat edin.
 
> n katmanlı mimaride üzerinde somut olarak tutulan ifadeler *Concrete* klasörü - bu klasörü entity katmanında oluşturduk - üzerinde tutulurlar. Soyut ifadeler ise *Abstract* klasörü içerisinde tutulur.

> Oluşturmuş olduğumuz sınıfa diğer alanlardan yani diğer katmanlardan diğer sınıflardan vb. erişim sağlayabilmek için *class Heading* kodunun başına *Access Modify* denilen erişim belirleyici tür olarak **public** yazılmalıdır.

> Classlarda bulundukları alanlara göre propertyler verilir. Heading ID, Heading Name vb.

> Durum aktif ya da pasif olma işlemi için *public bool CategoryStatus { get; set; }* kullanılabilir. Silmek yerine pasif yapma tercih edilmesinin sebebi silindiği zaman farklı kategorilerde bulunan verilerde silinir. Pasif yapıldığında ise sayfada kullanıcı göremeyecektir. Ekstra olarak bu durum ileride içerik modify edilip tekrar aktif hale getirilip kullanılabilir.

> **Code First** ----> Veritabanı ile Programlama dili arasında bağ kuran bir tekniktir. Projenizde veritabanı işlemlerinizi mümkün mertebe Visual Studio tarafında kod yazarak gerçekleştirmenizi sağlayan bir yaklaşımdır. Bu yaklaşım sayesinde veritabanı arayüzü ile yazılımcı arasında ilişki minimize edilmektedir.

> Resimler dosya yolu şeklinde tutulur. Resimler sunucuya yüklenmez ayrı bir yere yüklenir ve dosya yolları veri tabanına çekilir.

> İlişkilendirme yöntemini açıklamak için örnek olarak;
> * Category, Heading, Content ve Writer Tablolarımız olsun ve ilişkilendirmeler de şu şekilde olsun. 
>     * Category ve Heading tablosu arasında bir ilişkimiz olsun ve bu ilişkiyi şöyle düşünebiliriz. Heading, Category tablosunun bir alt başlığı gibi. Bire çok ilişki.
>         * Category sınıfına gelip **property** tanımlayacağız. *public ICollection <Heading> Headings { get; set; }* 
>         * Heading sınıfına gelip iki tane daha **property** daha tanımlanır. *public int CategoryID { get; set; } ve public virtual Category Category { get; set; }*
> * Heading ve Content tablosu arasında bir ilişkimiz olsun. 
>     * Aynı mantıkla;
>         * Heading sınıfına gelip *public ICollection <Content> Contents { get; set; }*
>         * Content sınıfına gelip *public int HeadingID { get; set; }* ve *public virtual Heading Heading { get; set; }*
> * Writer ve Heading tablosu arasında bir ilişkimiz olsun. 
>     * Aynı mantıkla;
>         * Writer sınıfına gelip *public ICollection <Heading> Headings { get; set; }* ve *public ICollection<Content> Contents { get; set; }
>         * Heading sınıfına gelip *public int WriterID { get; set; }* ve *public virtual Writer Writer { get; set; }*
>         * Content sınıfına gelip *public int WriterID { get; set; }* ve *public virtual Writer Writer { get; set; }*
> * Kod yapısı şu şekildedir. *public* - tüm sınıflardan erişim mevcut - *ICollection* - ben ilişki kuracağım - <*Hangi sınıfla ilişki kuracağım*> *Property adı* -İlişki kurulacak sınıfın adının sonuna 's takısı getirilerek kullanılır - { get; set; }
> * Bir diğer ilişkilendirme kod yapısı da şu şekildedir. *public* *int* *Property adı* - Bu ad ilişki kurulan sınıfın ilişki kurduğu sınıfın id adı olmalıdır. - 
>      * Örneğin; CategoryID 
> * Bir diğer ilişkilendirme kod yapısı şu şekildedir. *public* *virtual* - bir başka sınıftan değer alacağım demektir. - *Sınıf adı* - hangi sınıftan değer alacağım demektir. - *Propery adı* - sınıfın adı yazılır. -



 




