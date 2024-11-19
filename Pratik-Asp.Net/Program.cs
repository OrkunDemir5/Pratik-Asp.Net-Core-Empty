var builder = WebApplication.CreateBuilder(args);

// MVC servislerini uygulamaya ekler.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik dosyalarýn (CSS, JS, img vb.) wwwroot klasöründen servis edilmesini saðlar.
app.UseStaticFiles();

// Gelen istekler için routing iþlemini etkinleþtirir.
app.UseRouting();

app.MapGet("/", () => "Hello World!");

app.Run();

/*
    Kavramlar Açýklamasý:

    1. Controller:
       - MVC modelinde kullanýcýdan gelen istekleri (HTTP Request) karþýlayan yapýdýr.
       - Veriyi iþleyip view'e (görünüm katmaný) göndermekten sorumludur.
       - Örneðin: HomeController içinde "Index" metodu bir action'dýr.

    2. Action:
       - Controller içinde yer alan ve bir iþi gerçekleþtiren metotlara verilen addýr.
       - Örneðin, bir kullanýcýnýn istek yaptýðý sayfayý döndürmek veya formdan alýnan veriyi iþlemek.

    3. Model:
       - Uygulamanýn veri yapýsýný temsil eder.
       - Örneðin: Bir öðrenci için adý, soyadý, yaþý gibi bilgileri barýndýran bir sýnýf (class).

    4. View:
       - Kullanýcýya gösterilen arayüzü oluþturan katmandýr.
       - Razor syntax'ýný kullanarak dinamik HTML içerik oluþturur.

    5. Razor:
       - C# kodunun HTML ile birlikte yazýlmasýný saðlayan bir syntax'týr.
       - Örneðin: @Model.Name kullanarak dinamik veri sunumu yapýlabilir.

    6. Razor View:
       - Razor kullanýlarak oluþturulmuþ bir view dosyasýdýr.
       - Örneðin: `Views/Home/Index.cshtml`.

    7. wwwroot:
       - Statik dosyalarýn bulunduðu kök dizindir. CSS, JavaScript, resimler gibi dosyalar buraya eklenir.
       - Bu dosyalar tarayýcýlar tarafýndan direkt olarak eriþilebilir.

    8. builder.Build():
       - Uygulamanýn çalýþtýrýlabilir bir uygulamaya dönüþtürülmesini saðlar.
       - Konfigürasyonlar ve servis tanýmlamalarý tamamlandýktan sonra çaðrýlýr.

    9. app.Run():
       - Uygulamayý baþlatýr ve gelen HTTP isteklerini dinlemeye baþlar.
       - Uygulamanýn ana akýþýný baþlatan metottur.
*/
