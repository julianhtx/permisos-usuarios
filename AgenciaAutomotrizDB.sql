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
    fk_idUsuario INT,
    FOREIGN KEY(fk_idUsuario) REFERENCES Usuarios(idUsuarios),
    permiso ENUM('Lectura', 'Escritura', 'Eliminacion', 'Actualizacion')
);

ALTER TABLE Permisos
ADD nombre_User VARCHAR(255);

ALTER TABLE Permisos
ADD password VARCHAR(255);

--* CRUD DE USUARIOS
--! CREAR E INSERTAR
DROP PROCEDURE IF EXISTS p_InsertarUsuarios;
CREATE PROCEDURE p_InsertarUsuarios(
    IN _idUsuarios INT,
    IN _password VARCHAR(255),
    IN _nombre VARCHAR(255),
    IN _apellidoP VARCHAR(255),
    IN _apellidoM VARCHAR(255),
    IN _fechanacimiento DATE,
    IN _rfc VARCHAR(20)
)
BEGIN
    INSERT INTO Usuarios ( idUsuarios, password, nombre, apellidoP, apellidoM, fechanacimiento, rfc ) VALUES(
         _idUsuarios, _password, _nombre, _apellidoP, _apellidoM, _fechanacimiento, _rfc
    );
END;

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