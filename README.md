# DotNetEnglishP7
Student repo for Project 7 of the Back-end developer: .NET path

The project requires the creation of a database using the Entity Framework Code-First approach. 

Create the entities as outlined in the PDF linked in the Project 7 Course details. Then use Entity Framework's Code-First approach to create the database and all tables required. 

In order for the database to be correctly created, you must meet the prerequisites below and change the connection strings to point to the MSSQL Server running on you your local PC.

**Prerequisites**: MSSQL Developer 2019 or Express 2019 has been installed along with Microsoft SQL Server Management Studio (SSMS).

MSSQL: https://www.microsoft.com/en-us/sql-server/sql-server-downloads

SSMS: https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

*Note: earlier versions of MSSQL Server should work fine, but have not been tested.

*In the P7CreateRestApi project, open the appsettings.json file.*

You will see the ConnectionStrings section which defines the connection strings for the database used in this application.

      "ConnectionStrings":
      {
        "DefaultConnection": "Server=.;Database=YOUR DATABASE NAME;Trusted_Connection=True;MultipleActiveResultSets=true"
      }

There are different versions of MSSQL (please use MSSQL for this project and not another database) and when setting up the database server, there are different options that will change the configuration, so the connection strings defined may not work.

The connection strings defined in the project are setup for MSSQL Server Standard 2019. The installation has not created an instance name, so the server is just referred to as "." which means the default instance of MSSQL server running on the current machine. The built in Windows user which should be setup in MSSQL server by default during installation.

If you have installed MSSQL Express, the value to use for Server is most likely .\SQLEXPRESS, so for example, your database  connection string would be: -

    "DefaultConnection": "Server=.\SQLEXPRESS;Database=YOUR DATABASE NAME;Trusted_Connection=True;MultipleActiveResultSets=true"


You will need to implement **JWT Authentication** and **Authorization** using **Microsoft Identity**. 

If you have trouble connecting, first try to connection using Microsoft SQL Server Management Studio (make sure authentication type  is "Windows Authentication"), or refer to https://sqlserver-help.com/2011/06/19/help-whats-my-sql-server-name/.
If you still have trouble, please ask your mentor for assistance.
