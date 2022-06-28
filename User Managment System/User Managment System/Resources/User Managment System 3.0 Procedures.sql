Delimiter //
Create procedure Insert_Registration
(
	In _Email varchar(128),
	In _Password varchar(128),
	In _Firstname varchar(64),
	In _Lastname varchar(64),
    In _Information text,
	In _PicPath varchar(255),
	In _Birthdate Date,
	In _Server int,
    In _Roles int
)
BEGIN
	insert into Registration_Request(Email, Password, Firstname, Lastname,Information,PicPath, Birthdate, Server_ID, Roles_ID)
    values
    (_Email, _Password, _Firstname, _Lastname,_Information, _PicPath, _Birthdate, _Server, _Roles);
    
END //

-- ---------------------------------------------------------------------------------------------------------------------

Delimiter //
Create procedure Update_Registration
(
	In _Email varchar(128),
    In _Bann bool
)
BEGIN
    Update Registration_Request
    set
    Available = _Bann
    where Email = _Email;
END //

-- ---------------------------------------------------------------------------------------------------------------------

Delimiter //
Create procedure Insert_New_User
(
	In _Email varchar(128),
	In _Password varchar(64),
	In _Firstname varchar(64),
	In _Lastname varchar(64),
    In _Information text,
	In _PicPath varchar(255),
	In _Birthdate Date,
	In _Server int,
    In _Roles varchar(64)
)
BEGIN
	declare _Role_Name varchar(64);
    declare _Role_ID int;
	declare _Server_Name varchar(64);
	declare _Server_Type varchar(20);

	select Database_Name into _Server_Name from Servers where ID = _Server;
	select Database_Typ into _Server_Type from Servers where ID = _Server;
	select ID into _Role_ID from Roles where Role_name = _Roles;
	select Role_Name into _Role_Name from Roles where Role_name = _Roles;
    
    -- Löscht den User aus der Tabelle
    Delete from Registration_Request where Email = _Email;
    
	insert into Registered_Users(Email, Password, Firstname, Lastname,Information, PicPath, Birthdate, Server_ID, Roles_ID)
    values
    (_Email, _Password, _Firstname, _Lastname, _Information, _PicPath, _Birthdate, _Server, _Role_iD);
    
	-- ---------------------------------------------------------------------------------------------------------------------
    
    
    -- ---------------------------------------------------------------------------------------------------------------------
    -- Erstellt den User in Mysql.User
    SET @createUser = concat('CREATE USER ''', _Email, '''@''', _Server_Type, ''' IDENTIFIED BY ''', _Password, ''';');
    PREPARE createUserStatement FROM @createUser;
    EXECUTE createUserStatement;
    DEALLOCATE PREPARE createUserStatement;   
    
    -- ---------------------------------------------------------------------------------------------------------------------
    -- Gibt dem User, User Rechte Select,Insert,Update
    SET @GrantUser = concat('Grant ',_Role_Name,'@''',_Server_Type,''' to ',_Email,'@''',_Server_Type,''';');
    PREPARE GrantUserStatement FROM @GrantUser;
    EXECUTE GrantUserStatement;
    DEALLOCATE PREPARE GrantUserStatement;  
    
    -- ---------------------------------------------------------------------------------------------------------------------
    -- Setzt die Rolle des Users auf User_Rolle
    SET @RoleUser = concat('SET DEFAULT ROLE ',_Role_Name,'@''',_Server_Type,''' TO ',_Email,'@''',_Server_Type,''';');
    PREPARE RoleUserStatement FROM @RoleUser;
    EXECUTE RoleUserStatement;
    DEALLOCATE PREPARE RoleUserStatement;
END; //

-- Bann UnBann User

Delimiter //
Create Procedure Bann
(
	In _Email varchar(128),
    In _Available bool
)
Begin
declare _Server_ID int;
declare _Server_Typ varchar(64);
declare Bann varchar(20);

select Database_Typ into _Server_Typ from Servers where ID = 
(select Server_ID from Registered_Users where Email = _Email);

if _Available is true then
		set Bann = 'unlock';
	else
		set Bann = 'lock';
	End if;
    
    Update Registered_Users
    set
    Available = _Available
    where Email = _Email;
    
    SET @BannUser = concat('Alter user if exists ''',_Email,'''@''',_Server_Typ,''' Account ',Bann,';');
    PREPARE BannUserStatement FROM @BannUser;
    EXECUTE BannUserStatement;
    DEALLOCATE PREPARE BannUserStatement; 

End; //

-- Update User Procedure

Delimiter //
Create Procedure Update_User
(
	In _OldEmail varchar(128),
	In New_Email varchar(128),
	In _Password varchar(64),
	In _Firstname varchar(64),
	In _Lastname varchar(64),
    In _Information text,
	In _PicPath varchar(255),
	In _Birthdate Date,
	In _Server int,
    In _Roles int,
	In _Available bool
)
Begin
	declare Bann varchar(20);
    
    declare _ID int;
    
    declare Old_Role_Name varchar(64);
	declare Old_Server_Name varchar(64);
	declare Old_Server_Type varchar(20);
    
    declare New_Role_Name varchar(64);
	declare New_Server_Name varchar(64);
	declare New_Server_Type varchar(20);
    
    select ID into _ID from Registered_Users where Email = _OldEmail;
    
    select Database_Name into Old_Server_Name from Servers where ID = (select Server_ID from Registered_Users where ID = _ID);
	select Database_Typ into Old_Server_Type from Servers where ID = (select Server_ID from Registered_Users where ID = _ID);
	select Role_Name into Old_Role_Name from Roles where ID = (select Roles_ID from Registered_Users where ID = _ID);

	select Database_Name into New_Server_Name from Servers where ID = _Server;
	select Database_Typ into New_Server_Type from Servers where ID = _Server;
	select Role_Name into New_Role_Name from Roles where ID = _Roles;
    
    if _Available is true then
		set Bann = 'unlock';
	else
		set Bann = 'lock';
	End if;
    
    -- Update User
    
	Update Registered_Users
    set
    Email = New_Email,
    Password = _Password,
    Firstname = _Firstname,
    Lastname = _Lastname,
    Information = _Information,
    PicPath = PicPath,
    Birthdate = _Birthdate,
    Server_ID = _Server,
    Roles_ID = _Roles,
    Available = _Available
    where Email = _OldEmail;
    
	-- ---------------------------------------------------------------------------------------------------------------------
    -- Revoke Rechte
    SET @RevokeUser = concat('Revoke ''',Old_Server_Name,'_',Old_Role_Name,'''@''',Old_Server_Type,''' from ''',_OldEmail,'''@''',Old_Server_Type,''';');
    PREPARE RevokeUserStatement FROM @RevokeUser;
    EXECUTE RevokeUserStatement;
    DEALLOCATE PREPARE RevokeUserStatement; 
    
    -- Ändert den Namen des Users
    SET @RenameUser = concat('Rename User ''',_OldEmail,'''@''',Old_Server_Type,''' To ''',New_Email,'''@''',New_Server_Type,''';');
    PREPARE RenameUserStatement FROM @RenameUser;
    EXECUTE RenameUserStatement;
    DEALLOCATE PREPARE RenameUserStatement; 
    
	-- ---------------------------------------------------------------------------------------------------------------------
    -- Ändert das Passwort
    
	SET @ChangePassword = concat('Alter user if exists ''',New_Email,'''@''',New_Server_Type,''' Identified by ''',_Password,''';');
    PREPARE ChangePasswordStatement FROM @ChangePassword;
    EXECUTE ChangePasswordStatement;
    DEALLOCATE PREPARE ChangePasswordStatement; 
    
	-- ---------------------------------------------------------------------------------------------------------------------
    -- Locked oder Unlocked den User
    
    SET @BannUser = concat('Alter user if exists ''',New_Email,'''@''',New_Server_Type,''' Account ',Bann,';');
    PREPARE BannUserStatement FROM @BannUser;
    EXECUTE BannUserStatement;
    DEALLOCATE PREPARE BannUserStatement; 
    
    -- Gibt dem User neue Rechte
    SET @GrantUser = concat('Grant ',New_Server_Name,'_',New_Role_Name,'@''',New_Server_Type,''' to ',New_Email,'@''',New_Server_Type,''';');
    PREPARE GrantUserStatement FROM @GrantUser;
    EXECUTE GrantUserStatement;
    DEALLOCATE PREPARE GrantUserStatement;  
    
    -- ---------------------------------------------------------------------------------------------------------------------
    -- Setzt die Rolle des Users auf User_Rolle
    SET @RoleUser = concat('SET DEFAULT ROLE ',New_Server_Name,'_',New_Role_Name,'@''',New_Server_Type,''' TO ',New_Email,'@''',New_Server_Type,''';');
    PREPARE RoleUserStatement FROM @RoleUser;
    EXECUTE RoleUserStatement;
    DEALLOCATE PREPARE RoleUserStatement;
End; //

-- Delete User Procedure

Delimiter //
Create Procedure Delete_User
(
	In _Email varchar(128),
    In _Server int
)
Begin
	declare _Server_Type varchar(20);
    
    select Database_Typ into _Server_Type from Servers where ID = _Server;
    
     -- ---------------------------------------------------------------------------------------------------------------------
    -- Löscht den User
    
    Delete from Registered_Users where Email = _Email;
    
	SET @DropUser = concat('DROP USER if exists ''',_Email,'''@''',_Server_Type,''';');
    PREPARE DropUserStatement FROM @DropUser;
    EXECUTE DropUserStatement;
    DEALLOCATE PREPARE DropUserStatement;
End; //

-- Insert New Server
Delimiter //
Create Procedure Create_Database
(
	In _Database_Name varchar(128),
    In _Database_Type varchar(128)
)
Begin
	declare DBExist bool;
	
    SET @DropDatabase = concat('Drop Database if exists ',_Database_Name,';');
    PREPARE DropDatabaseStatement FROM @DropDatabase;
    EXECUTE DropDatabaseStatement;
    DEALLOCATE PREPARE DropDatabaseStatement;
    
    SET @CreateDatabase = concat('Create Database ',_Database_Name,';');
    PREPARE CreateDatabaseStatement FROM @CreateDatabase;
    EXECUTE CreateDatabaseStatement;
    DEALLOCATE PREPARE CreateDatabaseStatement;
    
    Select exists(select ID from UMS2.Servers where Database_Name = _Database_Name) into DBExist;
    
    if DBExist is true then
		Update Servers set Database_Typ = _Database_Type where Database_Name = _Database_Name;
	else
		Insert Into Servers(Database_Name, Database_Typ) values (_Database_Name, _Database_Type);
	End if;
End; //

-- Create Table
Delimiter //
Create Procedure Create_Tables
(
	In _Table_Name varchar(128),
    In _Create_Statement varchar(255)
)
Begin
	declare _id int;
    select id into _id from Servers where Database_Name = _Table_Name;

	SET @CreateTable = _Create_Statement;
    PREPARE CreateTableStatement FROM @CreateTable;
    EXECUTE CreateTableStatement;
    DEALLOCATE PREPARE CreateTableStatement;
    
    insert into Server_Tables(Database_ID, Tables_Name) value (_ID, _Table_Name);
End; //


Delimiter //
Create Procedure Create_Roles
(
	In _Database_ID int,
    In _Role varchar(64),
    In _Privileges varchar(128)
)
Begin
    declare RoleExist bool;
    
	Select exists(select ID from UMS2.Roles where Database_ID = _Database_ID and Role_Name = _Role) into RoleExist;

	if RoleExist is true then
		Update Roles set Role_Privileges = _Privileges where Database_ID = _Database_ID;
	else
		insert into Roles(Database_ID,Role_Name,Role_Privileges) values (_Database_ID,_Role, _Privileges);
	End if;
End; //