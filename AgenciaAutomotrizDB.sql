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