# .Net-CRUD-with-RazorPages

Acest proiect este o aplicație CRUD (Create, Read, Update, Delete) realizată cu ASP.NET Core și Razor Pages. Aplicația include gestionarea utilizatorilor, autentificare, zone de administrare securizate, sortare, filtrare a datelor și validare a input-urilor.

## Caracteristici

- **Autentificare și Autorizare**

  - Utilizatorii se pot autentifica folosind un sistem securizat.
  - Zona de administrare este accesibilă doar utilizatorilor cu rol de administrator.

- **Operațiuni CRUD**

  - Adăugarea, vizualizarea, editarea și ștergerea datelor.

- **Sortare și Filtrare**

  - Posibilitatea de a sorta și filtra listele de date.

- **Validare a Datelor**

  - Validare pe server utilizând data annotations.
  - Feedback vizual pentru utilizator.

## Tehnologii Utilizate

- ASP.NET Core (Razor Pages)
- Entity Framework Core
- SQL Server
- Bootstrap

## Instalare

1. **Clonarea Repozitoriului:**
   ```bash
   git clone https://github.com/Damean-Andrei-Stefan/.Net-CRUD-with-RazorPages.git
   cd .Net-CRUD-with-RazorPages
   ```
2. **Configurarea Bazei de Date:**
   - Actualizează `appsettings.json` cu conexiunea la baza de date.
3. **Aplicarea Migrațiilor:**
   ```bash
   dotnet ef database update
   ```
4. **Rularea Aplicației:**
   ```bash
   dotnet run
   ```

## Structura Proiectului

```plaintext
.Net-CRUD-with-RazorPages/
├── Data/
│   └── ApplicationDbContext.cs
├── Models/
│   └── [Entity].cs
├── Pages/
│   ├── Account/ (Logare, Logout, Registrare)
│   ├── Admin/ (Zona securizată pentru administrare)
│   ├── Shared/
│   └── _Layout.cshtml
├── wwwroot/
│   ├── css/
│   └── js/
├── appsettings.json
├── Program.cs
└── Startup.cs
```

## Contribuții

Oricine dorește să contribuie este binevenit!

## Licență

Acest proiect este licențiat sub licența MIT.

