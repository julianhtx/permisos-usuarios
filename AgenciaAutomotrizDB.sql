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

CREATE TABLE Permisos (
    fk_Username VARCHAR(255),
    NombreFormulario VARCHAR(255),
    FrmLectura BIT,
    FrmEscritura BIT,
    FrmActualizacion BIT,
    FrmEliminacion BIT,
    FOREIGN KEY (fk_Username) REFERENCES Usuarios(Username)
);

drop table Permisos;

ALTER TABLE permisos
MODIFY COLUMN permiso VARCHAR(255);

--* CRUD DE USUARIOS
--! CREAR E INSERTAR
DROP PROCEDURE IF EXISTS p_insertar_usuarios
CREATE procedure p_insertar_usuarios
(
    in _username varchar(255),
    in _password varchar(255),
    in _nombre varchar(255),
    in _apellidoP varchar(255), 
    in _apellidoM varchar(255),
    in _fecha_Nacimiento DATE,
    in _rfc varchar(20)
)
begin 
    insert into usuarios (username, password, nombre, apellidop, apellidom, fechanacimiento, rfc) values 
    (_username, _password, _nombre, _apellidop, _apellidom, _fecha_Nacimiento, _rfc); 
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
DROP PROCEDURE IF EXISTS p_insertar_permisos;
CREATE PROCEDURE p_insertar_permisos(
    IN _fk_Username VARCHAR(255),
    IN _NombreFormulario VARCHAR(255),
    IN _FrmLectura BIT,
    IN _FrmEscritura BIT,
    IN _FrmActualizacion BIT,
    IN _FrmEliminacion BIT
)
BEGIN
    INSERT INTO Permisos (fk_Username, NombreFormulario, FrmLectura, FrmEscritura, FrmActualizacion, FrmEliminacion)
    VALUES (_fk_Username, _NombreFormulario, _FrmLectura, _FrmEscritura, _FrmActualizacion, _FrmEliminacion);
END;

DESCRIBE PERMISOS

--! BORRAR
DROP PROCEDURE IF EXISTS p_BorrarPermisos;
CREATE PROCEDURE p_eliminar_permisos(
    IN p_Username VARCHAR(255),
    IN p_NombreFormulario VARCHAR(255)
)
BEGIN
    DELETE FROM Permisos
    WHERE fk_Username = p_Username AND NombreFormulario = p_NombreFormulario;
END;

/*creacion procedure de validar usuario*/
DROP PROCEDURE IF EXISTS p_validar; 
CREATE PROCEDURE p_validar(
    IN _user VARCHAR(255),
    IN _pass VARCHAR(255)
)
BEGIN 
    DECLARE x INT;

    -- Contar si el usuario y la contraseña son correctos
    SELECT COUNT(*) INTO x 
    FROM Usuarios 
    WHERE Username = _user AND Password = _pass;

    -- Si hay un usuario válido
    IF x > 0 THEN
        SELECT 'Correcto' AS rs,
            p.fk_Username AS Username,
            p.NombreFormulario,
            p.FrmLectura,
            p.FrmEscritura,
            p.FrmActualizacion,
            p.FrmEliminacion
        FROM 
            Permisos p
        WHERE 
            p.fk_Username = _user;
    ELSE
        SELECT 'Error' AS rs;
    END IF;
END;

describe usuarios;
describe permisos;
select * from permisos;
select * from usuarios;

CREATE VIEW VistaUsuarioPermisos AS
SELECT 
    u.Username,
    u.password,
    u.nombre,
    u.apellidoP,
    u.apellidoM,
    u.fechanacimiento,
    u.rfc,
    p.NombreFormulario,
    p.FrmLectura,
    p.FrmEscritura,
    p.FrmActualizacion,
    p.FrmEliminacion
FROM 
    Usuarios u
LEFT JOIN 
    Permisos p ON u.Username = p.fk_Username;


insert into usuarios values ('Pepin', sha1('1234'), 'xXPepin', 'Gameplais', 'Xx', '2004-12-15', 'vetm04ert');
INSERT INTO Permisos (fk_Username, NombreFormulario, FrmLectura, FrmEscritura, FrmActualizacion, FrmEliminacion) 
VALUES ('Pepin', 'Usuarios', 1, 1, 1, 1);
INSERT INTO Permisos (fk_Username, NombreFormulario, FrmLectura, FrmEscritura, FrmActualizacion, FrmEliminacion) 
VALUES ('Pepin', 'Productos', 1, 1, 1, 1);
INSERT INTO Permisos (fk_Username, NombreFormulario, FrmLectura, FrmEscritura, FrmActualizacion, FrmEliminacion) 
VALUES ('Pepin', 'Herramientas', 1, 1, 1, 1);

insert into usuarios values ('Pepinillo', sha1('1234'), 'xXPepinillo', 'Games', 'Xx', '2004-12-15', 'vetm04');
INSERT INTO Permisos (fk_Username, NombreFormulario, FrmLectura, FrmEscritura, FrmActualizacion, FrmEliminacion) 
VALUES ('Pepinillo', 'Usuarios', 1, 1, 0, 1);
INSERT INTO Permisos (fk_Username, NombreFormulario, FrmLectura, FrmEscritura, FrmActualizacion, FrmEliminacion) 
VALUES ('Pepinillo', 'Productos', 1, 1, 0, 1);
INSERT INTO Permisos (fk_Username, NombreFormulario, FrmLectura, FrmEscritura, FrmActualizacion, FrmEliminacion) 
VALUES ('Pepinillo', 'Herramientas', 1, 1, 0, 1);

insert into usuarios values ('Pepinilla', sha1('1234'), 'xXPepinilla', 'Game', 'Xx', '2004-12-15', 'vetm');
INSERT INTO Permisos (fk_Username, NombreFormulario, FrmLectura, FrmEscritura, FrmActualizacion, FrmEliminacion) 
VALUES ('Pepinilla', 'Usuarios', 0, 0, 0, 0);
INSERT INTO Permisos (fk_Username, NombreFormulario, FrmLectura, FrmEscritura, FrmActualizacion, FrmEliminacion) 
VALUES ('Pepinilla', 'Productos', 1, 0, 0, 0);
INSERT INTO Permisos (fk_Username, NombreFormulario, FrmLectura, FrmEscritura, FrmActualizacion, FrmEliminacion) 
VALUES ('Pepinilla', 'Herramientas', 1, 0, 0, 0);

call p_validar('Pepin', sha1('1234'));

call p_insertar_usuarios('kiubo', sha1('1234'), 'LG', 'U', 'E', '2004-10-15', 'LGUE');



CALL p_insertar_permisos('username', 'nombreFormulario', 1, 0, 1, 0);
delete from usuarios where username = "Joaquin";
select * from VistaUsuarioPermisos;

