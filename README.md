# aspnet_webapp
A ASP .NET MVC Webapp Demo

### MySQL (or MariaDB) setup 

First, initialize MySQL before you start the service.

```
sudo mariadb-install-db --user=mysql --basedir=/usr --datadir=/var/lib/mysql
```

Setup mariadb and login info.
```
sudo mariadb-secure-installation
```

Start the service
```
sudo systemctl start mariadb
```

Login to mariadb to create the database to be used in the demo app.
```
mariadb -u root -p
```

create the database 
```
create database dotnetapp;
```

configure the database login info so the app can access it in `appsettings.json`

### .NET Database setup

Make sure you have the ef tool package to connect it to your database and so you can run migrations.
```
dotnet tool install --global dotnet-ef
```

To initialize first migration:
```
dotnet ef migrations add init
```

Then update your local database:
```
dotnet ef database update
```