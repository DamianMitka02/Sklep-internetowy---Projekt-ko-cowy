Zainstaluj Pakiety :
Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter, 
Microsoft.AspNetCore.Identity.EntityFrameworkCore, 
Microsoft.AspNetCore.Identity.UI, 
Microsoft.EntityFrameworkCore, 
Microsoft.EntityFrameworkCore.Design, 
Microsoft.EntityFrameworkCore.Relational, 
Microsoft.EntityFrameworkCore.Sqlite, 
Microsoft.EntityFrameworkCore.SqlServer, 
Microsoft.EntityFrameworkCore.Tools, 
Microsoft.VisualStudio.Web.CodeGeneration.Design, 


Przed uruchomieniem projektu ustaw połączenie z bazą danych w pliku "appsettings.json" oraz utwórz bazę danych o nazwie "SklepInternetowy".
Po stworzeniu bazy danych wpisz następujące komendy w konsoli menedżera pakietów:
1. add-migration "Initial Create"
2. update-database

Admin, użytkownik testowy oraz odpowiadające im role zostaną automatycznie utworzone po uruchomieniu projektu.

Dane logowania:
Admin: email:"admin@admin.com", hasło:"123Asd!"
Użytkownik testowy: email:"test@test.com", hasło:"Asd123!"


Niezarejestrowany użytkownik może przeglądać produkty oraz sprawdzać ich detale.

Zarejestrowany użytkownik może dodatkowo zakupić dany produkt.

Admin może wykonywać wszystkie czynności takie jak dodawanie, usuwanie lub edycja produktu.
