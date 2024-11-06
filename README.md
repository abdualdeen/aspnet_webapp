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
