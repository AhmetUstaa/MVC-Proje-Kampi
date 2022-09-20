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

> Metot tanımlamaların türleri vardır. Örneğin **ActionResult** gibi. String, integer vb. gibi veri tipleri tanımlanabilir. Metot yayınlama türü olarak *public* yani herkese açık bir örneğidir.

> Her metot bir sayfa döndürür. Bu sebeple controllers üzerinde tanımlanan metoda sağ tıklayıp **Add View** diyerek *Views* yapısı üzerinde bir sayfaya attach edilir. Bu işlem sırasında sayfasımızı bir Layout a bağlı olarak çalıştırmak istediğimizde çıkan pencerede ... ya basılır ve Views > Shared a gidilir. 

> Bir metot tanımlanıp Views kısmında bir Layout a bağlandıktan sonra görüntülemek için mevcut sayfanın yenilenmesi yetmez, değişiklikler yapıldıktan sonra derlemek gerekir. Sağ tıklayıp view in browser seçilmelidir. 

> SOLID prensipleri gereği, projede yapılacak her bir menü alanı bir controllerda tutulacaktır. Başlıklar, kullanıcılar, yazılar, admin vb.

> Bir controller tanımlandığında bize otomatik olarak sunulan Index metodunu bir View oluşturmak için kullanırız. Öncesinde ise bir Layout tanımlanır. 
> Views > Shared altında bir view tanımladığımızda herhangi bir layout u kullanmazsa kendisi bir layout olur. Bu sayfayı sağ tık ile browserda açamayız. Bunun için bir controllerda tanımlı olması gerekir.

> **RenderBody çağırılmadı hatası** oluşturmuş olduğumuz layout un içerisine sayfaları yüklerken ben bu sayfaları layout un hangi kısmına getireceğim sorusunun cevabını vermediğimiz için bu hatayı alırız. 
> * Örneğin div lerin arasına getir diyebiliriz. Bunu RenderBody metoduyla razer syntax ı ile yapabiliriz. Yani HTML tarafında C# komutları girebiliriz. Bunu ise komutların başına @ sembolü ekleriz. 
> * Front End tarafında yapılan değişiklikler sayfa yenileyerek gözlemlenebilirken, Backend kısmında bu durum söz konusu değildir.









