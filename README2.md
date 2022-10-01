> * Verileri SQL serverdan çekerken;
>   * Presentation Layer da reference lara business, data access ve entity layers eklenir.
>   * CategoryController içerisine metodlar tanımlanır.
>   * Metodlar içerisinde **var** türünde değişken oluşturulur. Sebebi ise farklı veri türlerinde veriler olabileceği için. var değişkeni hepsini kapsar.
>   * CategoryManager sınıfını çağırırız. CategoryManager cm = new CategoryManager();
>   * Eklemiş olduğumuz return değerine bir view eklenir.
>   * Presentation Layer a Entity Framework yüklenir.
	
	
> * SQL den verileri çekerken foreach döngüsü kullanabiliriz.
>	  * Bunun için öncelikle 2 komut tanımlanmalıdır.
>		  * @using EntityLayer.Concrete ----> HTML sayfasına Concrete dizini dahil olur.
>		  * @model List<Category> ----------> Verileri listelemek için kullanılacak olan bileşene model denir. Liste olarak kategori değerlerini tutacak.
> 	* Son olarakta foreach döngüsünü yazarız.
	
> * **Razor Syntax** ---> HTML içerisinde C# komutlarını yazabilmek için kullanılan yöntemdir. Başına @ ifadesi yazarak kullanırız.

> * Foreach döngüsünün 4 tane parametresi vardır.
> 	* Değişkenin türü. var
>	* Değişkenin verilen isim. item
> 	* in komutu. in
>	* Değerlerin alınacağı dizinin ismi. Model
>		* @foreach(var item in Model) 

> * **Break Point** işlemi için istenilen satır numarası arkasına tıklanır ve işaretçi çıkarılır. Start butonu ile çalıştırılır. F11 butonu ile diğer adıma geçilir.
	
> * **Ekleme işleminde geçerli olmak üzere**, ekleme işlemi yaparken sayfa yüklendiğinde bir post işlemide gerçekleşiyor. Sayfa yüklenir yüklenmez controllerdaki ilgili komutlar devreye giriyor. ilgili tabloya eklenebilecek herhangi bir değer olmadığı için SQL de ilgili tabloya değerler NULL ve False olarak ekleniyor. Varsa return olarak tanımlı action ifadesine geri dönülüyor ve döngü sonlanıyor. **Böylelikle sayfa yüklenir yüklenmez ekleme yapma hatası ortaya çıkıyor**. Bu hatanın önüne geçmek için sayfada bir buton tanımlaması yapabilir ve butona tıklanınca bu işlemler gerçekleşecek şekilde ayarlanabilir. Burada **HTTP GET ve POST** attribute leri kullanabiliriz.
> * İlgili kategoriye gelip ve ilgili actionresult ın üzerine gelerek *[HttpPost]* attribute unu ekleriz. Bu bize HTTP POST devreye girdiği zaman çalışacak bir Action özelliği kazandıracak. 
> * Sayfa yüklendiği zaman çalışacak attribute ise *[HttpGet]* attribute udür. Bunu ise post olanın üzerine tekrar aynı action result tanımlandıktan sonra return olarak sadece view metodu eklenerek yazılır. 
> * Böylelikle sayfa yüklendiği zaman ilgili action için get attribute ü devreye girecek ve kullanıcı eğer o sayfada bir butona tıklarsa o zamanda ilgili diğer action ile post attribute ü devreye girer. Son olarakta sayfa yüklenir yüklenmez veri kaydetme işlemi olmayacak. 

> * form class diyip belirledikten sonra **method="post"** yazdığımızda şu demek oluyor form tag i içerisinde yazan ifadeler ne zaman çalışsın? Sayfada bir post işlemi olduğu zaman çalışsın.
	
> * IIS EXPRESS HATASI -----> http://localhost:34111 başka bir uygulama tarafından kullanılıyor gibi bir hata alırsanız komut istemini açın ve şu iki komutu sırayla yazın tekrar deneyin. **net stop winnat** , **net start winnat**
	
> * Visual Studio da kod satırlarını düzenlemek için CTRL + K + D kullanılır.

> * Business Layer da olabildiğince new kullanmaktan kaçınarak bağımlılıkları minimize etmek gerekir.
	
> * Validation Rules ları Entity Layer Category içerisinde tanımlamak yerine Business Layer Validation Rules klasörü oluşturup burada class lar ile tanımlamak daha doğru bir yöntemdir. Bunun için öncelikle ilgili katmana Fluent Validation Framework yüklenir.
> * Entity Layer Concrete klasörü içerisindeki her bir class için ayrı ayrı validator class ları oluşturulup içerisine constructor lar ile kurallar tanımlanır.

> * Validation Result tanımlarken **Fluent Validation** Framework ü yüklenmelidir.
	
> * @using(Html.BeginForm())-----> Ekleme ve güncelleme işlemleri sırasında kullanılan bir HTML yardımcısıdır.
	
> * Tema UI katmanına eklenir.
	
> * RenderBody() -----> Layout a bağlı olarak çalışacak sayfaların, sayfanın hangi konumunda yer alacağını tutuyor. Kullanılmadığında RenderBody hatası alınıyor. Ve herhangi bir yerde kullanabiliyoruz.
	
> * **EntityState** metotları *added*, *deleted*, *detached*, *modified*, *unchanged*. //_object.Add(p); e ihtiyaç kalmıyor.
	
> * Yapılan değiklikleri database e aktarmak için migration yapılır. 
> * *add-migration mig_writer_edit* *update-database
> * Çıkan edit class ında **public override void Up()** yapılan değişiklikleri, down ise değişiklik öncesi halini verir.













  

	

	


	




 




