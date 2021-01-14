# Library

#### **01/11/2021**

## By _Eric Stratton, Constantine Yakubovski & Callie Stump_
---
## <u>**About** </u>
### 🚩 **Description**
This application is for a 

### 🐛 Known Bugs
* Initial add of a book doesn't record a copy.
* Checkout drop down displays CopyId instead of book title.

### **📖 User Stories**
<details>
<summary>Expand</summary>

* As a librarian, I want to create, read, update, delete, and list books in the catalog, so that we can keep track of our inventory.
* As a librarian, I want to search for a book by author or title, so that I can find a book when there are a lot of books in the library.
* As a librarian, I want to enter multiple authors for a book, so that I can include accurate information in my catalog. (Hint: make an authors table and a books table with a many-to-many relationship.)
* As a patron, I want to check a book out, so that I can take it home with me.
* As a patron, I want to know how many copies of a book are on the shelf, so that I can see if any are available. (Hint: make a copies table; a book should have many copies.)
* As a patron, I want to see a history of all the books I checked out, so that I can look up the name of that awesome sci-fi novel I read three years ago. (Hint: make a checkouts table that is a join table between patrons and copies.)
* As a patron, I want to know when a book I checked out is due, so that I know when to return it.
* As a librarian, I want to see a list of overdue books, so that I can call up the patron who checked them out and tell them to bring them back - OR ELSE!
</details>
<hr>

## <u>**Getting Started**</u>
### **☑️ Requirements**
* C# .Net Core v2.2.4 installed on your local machine.
* Console/Terminal access.
* Code Editor 
Ex.) [Visual Studio Code](https://code.visualstudio.com/)
* MySQL Community Server & Workbench
### 🔧 **Setup/Installation**
#### **Project Editor Setup**
1. Copy this download link: https://github.com/faustlarsen/Library.git
2. Open bash and go to the directory where you would like to store your cloned project.
3. Clone the repo.
```
git clone https://github.com/faustlarsen/Library.git
```
4. Navigate to the cloned project folder and open VS code.
```
$ cd Desktop
$ cd [known directory]
$ code .
```
5. Navigate to the testing project folder in your VS terminal initalizes dotnet.
```
dotnet restore
```
6. If you wish to see if everything is compiling correctly go to the Office directory and run the following:
```
dotnet build
```
7. To see if the program is functioning properly you can use:
```
dotnet watch run
```
This will show you if everything is compiling correctly; otherwise you be will prompt with error messages.

#### **Dont forget that in order to push any changes you need to add your own GitHub repo. to your project.**
```
git remote add origin [personal Github repo. link]
```

#### **Import Database with Entity Framework Core**
1. Navigate to the "SillyStringzFactory.Solution/Factory" directory using your terminal.
2. Run the command 'dotnet ef database update to generate the database through Entity Framework Core.
3. (Optional) To update the database with any changes to the code, run the command 'dotnet ef migrations add [MigrationsName] which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command 'dotnet ef database update' to update the database.

#### **AppSettings**
1. Create a new file in the "SillyStringzFactory.Solution/Factory" directory named appsettings.json
2. Add in the followint code snippet to the new appsettings.json file:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=firstName_lastName;uid=root;pwd=YourPassword;"
  }
}
```

#### **Import Database with MySQL Workbench**

**Note**: If you have yet to install MySql Workbench follow [this link](https://dev.mysql.com/doc/mysql-getting-started/en/).
1. Open MySql Workbench and enter your password.
2. Go to the nav bar at the top, click on Server > Data Import.
3. Use the option 'Import from Self-Contained File'.
4. Set the 'Default Target Schema' or create a new schema.
5. Select all Schema Objects you wish to import.
6. At the bottom, ensure the option 'Dump Structure and Data' is selected.
7. Click 'Start Import'

#### **Note**: Do this is your main parent directory. You do not want to have git initialized in any other places.

## **SQL Schema**
```
```

## **Technologies Used**
* Visual Studio Code 1.52.1
* C# V:7.3
* .NET Core V: 2.2.0
* ASP.NET Core MVC
* ASP.NET Core Razor Pages
* MySQL WorkBench V: 8.0
* Entity Framework Core V: 2.2.6
* dotnet script, REPL

------------------------------
## �  ontributors

| Author | Email |
|--------|:-----:|
| [Callie Stump](https://www.linkedin.com/in/callie-stump/) | [callie@stu.mp](mailto:callie@stu.mp) |
| [Eric Stratton](https://www.linkedin.com/in/eric-j-stratton/) | [strattonericj@gmail.com](mailto:strattonericj@gmail.com) |
| [Constantine Yakubovski](https://www.linkedin.com/in/constantine-yakubovski/) | [faustlarsene@gmail.com](mailto:faustlarsene@gmail.com) |
------------------------------

## 📝 Legal
```
MIT License

Copyright (c) 2021 Eric Stratton, Constantine Yakubovski & Callie Stump

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```
<center><a href="#">Return to Top</a></center>







