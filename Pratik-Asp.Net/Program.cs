var builder = WebApplication.CreateBuilder(args);

// MVC servislerini uygulamaya ekler.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik dosyalar�n (CSS, JS, img vb.) wwwroot klas�r�nden servis edilmesini sa�lar.
app.UseStaticFiles();

// Gelen istekler i�in routing i�lemini etkinle�tirir.
app.UseRouting();

app.MapGet("/", () => "Hello World!");

app.Run();

/*
    Kavramlar A��klamas�:

    1. Controller:
       - MVC modelinde kullan�c�dan gelen istekleri (HTTP Request) kar��layan yap�d�r.
       - Veriyi i�leyip view'e (g�r�n�m katman�) g�ndermekten sorumludur.
       - �rne�in: HomeController i�inde "Index" metodu bir action'd�r.

    2. Action:
       - Controller i�inde yer alan ve bir i�i ger�ekle�tiren metotlara verilen add�r.
       - �rne�in, bir kullan�c�n�n istek yapt��� sayfay� d�nd�rmek veya formdan al�nan veriyi i�lemek.

    3. Model:
       - Uygulaman�n veri yap�s�n� temsil eder.
       - �rne�in: Bir ��renci i�in ad�, soyad�, ya�� gibi bilgileri bar�nd�ran bir s�n�f (class).

    4. View:
       - Kullan�c�ya g�sterilen aray�z� olu�turan katmand�r.
       - Razor syntax'�n� kullanarak dinamik HTML i�erik olu�turur.

    5. Razor:
       - C# kodunun HTML ile birlikte yaz�lmas�n� sa�layan bir syntax't�r.
       - �rne�in: @Model.Name kullanarak dinamik veri sunumu yap�labilir.

    6. Razor View:
       - Razor kullan�larak olu�turulmu� bir view dosyas�d�r.
       - �rne�in: `Views/Home/Index.cshtml`.

    7. wwwroot:
       - Statik dosyalar�n bulundu�u k�k dizindir. CSS, JavaScript, resimler gibi dosyalar buraya eklenir.
       - Bu dosyalar taray�c�lar taraf�ndan direkt olarak eri�ilebilir.

    8. builder.Build():
       - Uygulaman�n �al��t�r�labilir bir uygulamaya d�n��t�r�lmesini sa�lar.
       - Konfig�rasyonlar ve servis tan�mlamalar� tamamland�ktan sonra �a�r�l�r.

    9. app.Run():
       - Uygulamay� ba�lat�r ve gelen HTTP isteklerini dinlemeye ba�lar.
       - Uygulaman�n ana ak���n� ba�latan metottur.
*/
