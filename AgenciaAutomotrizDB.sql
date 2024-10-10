CREATE DATABASE AutomotrizDB;
USE AutomotrizDB;

CREATE TABLE Usuarios(
    idUsuarios INT PRIMARY KEY,
    password VARCHAR(255),
    nombre VARCHAR(255),
    apellidoP VARCHAR(255),
    apellidoM VARCHAR(255),
    fechanacimiento DATE,
    rfc VARCHAR(20) UNIQUE
);

ALTER TABLE Usuarios 
CHANGE COLUMN idUsuarios Username VARCHAR(255);

CREATE TABLE Refacciones(
    CodigoBarras INT PRIMARY KEY,
    nombre VARCHAR(255),
    descripcion VARCHAR(255),
    marca VARCHAR(255)
);

CREATE TABLE Taller(
    codigoHerramienta INT PRIMARY KEY,
    nombre VARCHAR(255),
    medida DECIMAL(5,2),
    marca VARCHAR(255),
    descripcion VARCHAR(255)
);

CREATE TABLE Permisos(
    fk_Username varchar(255),
    nombre_form varchar(255),
    permisos varchar(255),
    FOREIGN KEY(fk_Username) REFERENCES Usuarios(Username)
);
<<<<<<< HEAD
describe permisos;
=======

ALTER TABLE permisos
MODIFY COLUMN permiso VARCHAR(255);

>>>>>>> 1dc07c0e1496d8ab867eef1f3bb1376c47256e4f
--* CRUD DE USUARIOS
--! CREAR E INSERTAR
DROP PROCEDURE IF EXISTS p_InsertarUsuarios;
CREATE procedure p_insertar_usuarios
(
    in _username varchar(255),
    in _password varchar(255),
    in _nombre varchar(255),
    in _apellidoP varchar(255), 
    in _apellidoM DATE,
    in _fecha_Nacimiento VARCHAR(13),
    in _rfc varchar(20),
    in _nombre_form varchar(255),
    in _permisos varchar(255)
)
begin 
    declare nuevo_usuario int; 
    insert into usuarios (username, password, nombre, apellidop, apellidom, fecha_nacimiento, rfc) values 
    (_username, _password, _nombre, _apellidop, _apellidom, _fecha_nacimiento, _rfc);
    set nuevo_usuario = last_insert_id(); 
    insert into permisos(fk_username, nombre_form, permisos) values 
    (nuevo_usuario, _nombre_form, _permisos); 
end;

--! MODIFICAR
DROP PROCEDURE IF EXISTS p_ModificarUsuarios;
CREATE PROCEDURE p_ModificarUsuarios(
    IN _idUsuarios INT,
    IN _password VARCHAR(255),
    IN _nombre VARCHAR(255),
    IN _apellidoP VARCHAR(255),
    IN _apellidoM VARCHAR(255),
    IN _fechanacimiento DATE,
    IN _rfc VARCHAR(20)
)
BEGIN
    UPDATE Usuarios
    SET
        password = _password,
        nombre = _nombre,
        apellidoP = _apellidoP,
        apellidoM = _apellidoM,
        fechanacimiento = _fechanacimiento,
        rfc = _rfc
    WHERE
        idUsuarios = _idUsuarios;
END;

--! ELIMINAR
DROP PROCEDURE IF EXISTS p_EliminarUsuarios;
CREATE PROCEDURE p_EliminarUsuarios(
    IN _idUsuarios INT
)
BEGIN
    DELETE FROM Usuarios
    WHERE idUsuarios = _idUsuarios;
END;

--*CRUD DE REFACCIONES
--! CREAR E INSERTAR
DROP PROCEDURE IF EXISTS p_InsertarRefacciones;
CREATE PROCEDURE p_InsertarRefacciones(
    IN _CodigoBarras INT,
    IN _nombre VARCHAR(255),
    IN _descripcion VARCHAR(255),
    IN _marca VARCHAR(255)
)
BEGIN
    INSERT INTO Refacciones (CodigoBarras, nombre, descripcion, marca) VALUES (
        _CodigoBarras, _nombre, _descripcion, _marca
    );
END;

--! MODIFICAR
DROP PROCEDURE IF EXISTS p_ModificarRefacciones;
CREATE PROCEDURE p_ModificarRefacciones(
    IN _CodigoBarras INT,
    IN _nombre VARCHAR(255),
    IN _descripcion VARCHAR(255),
    IN _marca VARCHAR(255)
)
BEGIN
    UPDATE Refacciones
    SET
        nombre = _nombre,
        descripcion = _descripcion,
        marca = _marca
    WHERE
        CodigoBarras = _CodigoBarras;
END;

--! ELIMINAR
DROP PROCEDURE IF EXISTS p_EliminarRefacciones;
CREATE PROCEDURE p_EliminarRefacciones(
    IN _CodigoBarras INT
)
BEGIN
    DELETE FROM Refacciones
    WHERE CodigoBarras = _CodigoBarras;
END;


--* CRUD DE TALLER
--! CREAR E INSERTAR
DROP PROCEDURE IF EXISTS p_InsertarTaller;
CREATE PROCEDURE p_InsertarTaller(
    IN _codigoHerramienta INT,
    IN _nombre VARCHAR(255),
    IN _medida DECIMAL(5,2),
    IN _marca VARCHAR(255),
    IN _descripcion VARCHAR(255)
)
BEGIN
    INSERT INTO Taller (codigoHerramienta, nombre, medida, marca, descripcion) VALUES (
        _codigoHerramienta, _nombre, _medida, _marca, _descripcion
    );
END;

--! MODIFICAR
DROP PROCEDURE IF EXISTS p_ModificarTaller;
CREATE PROCEDURE p_ModificarTaller(
    IN _codigoHerramienta INT,
    IN _nombre VARCHAR(255),
    IN _medida DECIMAL(5,2),
    IN _marca VARCHAR(255),
    IN _descripcion VARCHAR(255)
)
BEGIN
    UPDATE Taller
    SET
        nombre = _nombre,
        medida = _medida,
        marca = _marca,
        descripcion = _descripcion
    WHERE
        codigoHerramienta = _codigoHerramienta;
END;

--! ELIMINAR
DROP PROCEDURE IF EXISTS p_EliminarTaller;
CREATE PROCEDURE p_EliminarTaller(
    IN _codigoHerramienta INT
)
BEGIN
    DELETE FROM Taller
    WHERE codigoHerramienta = _codigoHerramienta;
END;

<<<<<<< HEAD
DROP procedure if exists p_Validar; 
create procedure p_Validar
=======
--* CRUD DE PERMISOS
--! CREAR E INSERTAR
DROP PROCEDURE IF EXISTS p_InsertarPermisos;
CREATE PROCEDURE p_InsertarPermisos(
    IN _fk_idUsuario INT,
    IN _permiso VARCHAR(255)
)
BEGIN
    INSERT INTO Permisos (fk_idUsuario, permiso) VALUES (
        _fk_idUsuario, _permiso
    );
END;

--! LEER DATO (INSERT)
DROP PROCEDURE IF EXISTS p_ObtenerPermisos;
CREATE PROCEDURE p_ObtenerPermisos(
    IN _fk_idUsuario INT
)
BEGIN
    SELECT * FROM Permisos WHERE fk_idUsuario = _fk_idUsuario;
END;

--! MODIFICAR
DROP PROCEDURE IF EXISTS p_ActualizarPermisos;
CREATE PROCEDURE p_ActualizarPermisos(
    IN _fk_idUsuario INT,
    IN _permiso VARCHAR(255)
)
BEGIN
    UPDATE Permisos SET
        permiso = _permiso
    WHERE fk_idUsuario = _fk_idUsuario;
END;

--! BORRAR
DROP PROCEDURE IF EXISTS p_BorrarPermisos;
CREATE PROCEDURE p_BorrarPermisos(
    IN _fk_idUsuario INT
)
BEGIN
    DELETE FROM Permisos WHERE fk_idUsuario = _fk_idUsuario;
END;

/*creacion procedure de validar usuario*/
DROP procedure if exists p_validar; 
create procedure p_validar
>>>>>>> 1dc07c0e1496d8ab867eef1f3bb1376c47256e4f
(
	in _user INT,
	in _pass varchar(255)
)
begin 
<<<<<<< HEAD

	DECLARE x INT;
	SELECT COUNT(*) FROM usuarios WHERE idUsuarios = _user AND password = _pass INTO x;
	if x > 0 then
		SELECT 'Correcto' AS rs, (SELECT permiso FROM Permisos WHERE fk_idUsuario = _user) AS Permisos;
	ELSE
		SELECT 'Error' AS rs, "" AS Nivel;
	END if;
END;

CREATE TABLE Permisos(
    fk_idUsuario INT,
    FOREIGN KEY(fk_idUsuario) REFERENCES Usuarios(idUsuarios),
    permiso ENUM('Lectura', 'Escritura', 'Eliminacion', 'Actualizacion')
);

CREATE TABLE Usuarios(
    idUsuarios INT PRIMARY KEY,
    password VARCHAR(255),
    nombre VARCHAR(255),
    apellidoP VARCHAR(255),
    apellidoM VARCHAR(255),
    fechanacimiento DATE,
    rfc VARCHAR(20) UNIQUE
);
=======
	DECLARE x INT;
	SELECT COUNT(*) FROM usuarios WHERE idUsuarios = _user AND password = _pass INTO x;
	if x > 0 then
		SELECT 'Correcto' AS rs, (SELECT Permiso FROM permisos WHERE fk_idUsuario = _user) AS Permisos;
	ELSE
		SELECT 'Error' AS rs, 0 AS Nivel;
	END if;
END;

describe Permisos;

call p_InsertarUsuarios (1 ,
    sha('1234'),
    'xXpepin',
    'gameplais',
    'Xx',
    '2024-09-09',
    'JHTM090507HJC');
SELECT * FROM usuarios;

call p_validar(1, sha1('1234'));
>>>>>>> 1dc07c0e1496d8ab867eef1f3bb1376c47256e4f
