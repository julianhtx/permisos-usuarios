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
describe usuarios
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
    FrmUsuarios_Lectura bit,
    FrmUsuarios_Escritura bit,
    FrmUsuarios_Actualizacion bit,
    FrmUsuarios_Eliminacion bit,
    FrmProducto_Lectura bit,
    FrmProducto_Escritura bit,
    FrmProducto_Eliminacion bit,
    FrmProducto_Actualizacion bit,
    FrmHerramientas_Lectura bit,
    FrmHerramientas_Escritura bit,
    FrmHerramientas_Eliminacion bit,
    FrmHerramientas_Actualizacion bit,
    FOREIGN KEY(fk_Username) REFERENCES Usuarios(Username)
);

drop table Permisos;

ALTER TABLE permisos
MODIFY COLUMN permiso VARCHAR(255);

--* CRUD DE USUARIOS
--! CREAR E INSERTAR
DROP PROCEDURE IF EXISTS p_InsertarUsuarios;
CREATE procedure p_insertar_usuarios
(
    in _username varchar(255),
    in _password varchar(255),
    in _nombre varchar(255),
    in _apellidoP varchar(255), 
    in _apellidoM varchar(255),
    in _fecha_Nacimiento DATE,
    in _rfc varchar(20),
    in _nombre_form varchar(255),
    in _permisos varchar(255)
)
begin 
    declare nuevo_usuario varchar(255); 
    insert into usuarios (username, password, nombre, apellidop, apellidom, fecha_nacimiento, rfc) values 
    (_username, _password, _nombre, _apellidop, _apellidom, _fecha_nacimiento, _rfc);
    set nuevo_usuario = _username; 
    insert into permisos(fk_username, nombre_form, permisos) values 
    (nuevo_usuario, _nombre_form, _permisos); 
end;

describe permisos;

--! MODIFICAR
DROP PROCEDURE IF EXISTS p_ModificarUsuarios;
CREATE PROCEDURE p_ModificarUsuarios(
    IN _Username varchar(255),
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
        username = _username;
END;

--! ELIMINAR
DROP PROCEDURE IF EXISTS p_EliminarUsuarios;
CREATE PROCEDURE p_EliminarUsuarios(
    IN _username INT
)
BEGIN
    DELETE FROM Usuarios
    WHERE username = _username;
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

--* CRUD DE PERMISOS
--! CREAR E INSERTAR


--! ARREGLAR SI O SI

DROP PROCEDURE IF EXISTS p_InsertarPermisos;
CREATE PROCEDURE p_InsertarPermisos(
    IN _fk_username VARCHAR(255),
    IN _nombre_form VARCHAR(255),
    IN _permiso VARCHAR(255)
)
BEGIN
    INSERT INTO Permisos (fk_idUsuario, permiso) VALUES (
        _fk_idUsuario, _permiso
    );
END;
DESCRIBE PERMISOS
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
(
	in _user varchar(255),
	in _pass varchar(255)
)
begin 
	DECLARE x INT;
	SELECT COUNT(*) FROM usuarios WHERE username = _user AND password = _pass INTO x;
	if x > 0 then
		SELECT 'Correcto' AS rs, username, password, 
            FrmUsuarios_Lectura, FrmUsuarios_Escritura, FrmUsuarios_Eliminacion, FrmUsuarios_Actualizacion,
            FrmProducto_Lectura, FrmProducto_Escritura, FrmProducto_Eliminacion, FrmProducto_Actualizacion,
            FrmHerramientas_Lectura, FrmHerramientas_Escritura, FrmHerramientas_Eliminacion, FrmHerramientas_Actualizacion
             FROM v_UsuariosPermisos WHERE Username = _user;
	ELSE
		SELECT 'Error' AS rs, "" AS Nivel;
	END if;
END;

drop view if exists v_UsuariosPermisos;
CREATE VIEW v_UsuariosPermisos AS
SELECT 
    u.Username,
    u.password,
    p.FrmUsuarios_Lectura,
    p.FrmUsuarios_Escritura,
    p.FrmUsuarios_Eliminacion,
    p.FrmUsuarios_Actualizacion,
    p.FrmProducto_Lectura,
    p.FrmProducto_Escritura,
    p.FrmProducto_Eliminacion,
    p.FrmProducto_Actualizacion,
    p.FrmHerramientas_Lectura,
    p.FrmHerramientas_Escritura,
    p.FrmHerramientas_Eliminacion,
    p.FrmHerramientas_Actualizacion
FROM 
    Usuarios u
JOIN 
    Permisos p ON u.Username = p.fk_Username;

describe v_UsuariosPermisos;
describe usuarios;
describe permisos;
select * from permisos;
select * from usuarios;

insert into usuarios values ('Pepin', sha1('1234'), 'xXPepin', 'Gameplais', 'Xx', '2004-12-15', 'vetm04ert');
insert into permisos values ('Pepin', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
insert into usuarios values ('Pepinillo', sha1('1234'), 'xXPepinillo', 'Games', 'Xx', '2004-12-15', 'vetm04');
insert into permisos values ('Pepinillo', 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0);
insert into usuarios values ('Pepinilla', sha1('1234'), 'xXPepinilla', 'Game', 'Xx', '2004-12-15', 'vetm');
insert into permisos values ('Pepinilla', 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0);

call p_validar('Pepin', sha1('1234'));

