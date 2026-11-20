# SE Lab 4 - ASP.NET Web Forms with 3-Tier Architecture

Student: Hua Nguyen Thanh Trong - 524H0200

## Included requirements

- Exercise 1: Customer CRUD using DAL, BLL and WebUI.
- Exercise 2: Login implemented through all three tiers.
- Exercise 3: Successful login opens the main page, with links to Customer, Product and Supplier modules.
- Homework: Lab 2 School Management rebuilt with Web Forms and 3-Tier Architecture.

## Run the project

1. Open SQL Server Management Studio and execute `Database.sql` on `(localdb)\MSSQLLocalDB`.
2. Open `Lab04WebForms.sln` in Visual Studio.
3. Set `WebUI` as the startup project and `Login.aspx` as the start page.
4. Build the solution and press F5.
5. Sign in with `admin` / `123456`.

If your SQL Server instance is different, update `Lab4ConnectionString` in `WebUI/Web.config`.

## Architecture

- `DAL`: Entity Framework models, DbContext and repositories.
- `BLL`: validation and business services.
- `WebUI`: ASP.NET Web Forms pages and responsive presentation.

Passwords are plain text only because the supplied lab demonstrates a basic login flow. A production application must store salted password hashes.
