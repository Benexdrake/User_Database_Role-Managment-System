Drop database if exists UMS2;

-- ---------------------------------------------------------------------------------------------------------------------

Create database UMS2;

-- ---------------------------------------------------------------------------------------------------------------------

Use UMS2;

-- ---------------------------------------------------------------------------------------------------------------------
Create Table Servers
(
	ID int primary key auto_increment,
    Database_Name varchar(128) not null unique,
    Database_Typ varchar(64) not null
);

Create Table Roles
(
	ID int primary key auto_increment,
    Database_ID int not null,
    Role_Name varchar(64) not null,
    Role_privileges varchar(128) not null,
    constraint fk_Database_Roles foreign key(Database_ID)references Servers(ID)
);

Create Table Registration_Request -- User die sich im Cocktail Manager registriert haben, landen hier
(
	ID int not null primary key auto_increment,
    Email varchar(128) not null unique,
    Password varchar(64) not null,
    Firstname varchar(64) not null,
    Lastname varchar(64) not null,
    Information text null,
    PicPath varchar(255) null,
    Birthdate Date not null,
    Register_Date datetime null default Now(),
    Server_ID int not null,
    Roles_ID int not null,
    Available bool default false,
    constraint fk_Reg_Servers foreign key(Server_ID) references Servers(ID),
    constraint fk_Reg_Roles foreign key(Roles_ID) references Roles(ID)
);

-- ---------------------------------------------------------------------------------------------------------------------

Create Table Registered_Users -- User die vom Admin abgearbeitet wurden, landen hier und werden oben entfernt
(
	ID int not null primary key auto_increment,
    Email varchar(128) not null unique,
    Password varchar(64) not null,
    Firstname varchar(64) not null,
    Lastname varchar(64) not null,
    Information text null,
    PicPath varchar(255) null,
    Birthdate Date not null,
    Register_Date datetime default Now(),
    Server_ID int not null,
    Roles_ID int not null,
    Available bool default true,
    constraint fk_RegUsers_Servers foreign key(Server_ID) references Servers(ID),
    constraint fk_RegUsers_Roles foreign key(Roles_ID) references Roles(ID)
);

-- ---------------------------------------------------------------------------------------------------------------------

