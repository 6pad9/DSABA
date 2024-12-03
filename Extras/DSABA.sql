IF EXISTS (SELECT * FROM sys.databases WHERE name = 'DSABA')
    DROP DATABASE DSABA;
GO
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'DSABA')
BEGIN
    CREATE DATABASE DSABA;
END;
GO
USE DSABA;
GO

CREATE TABLE Category (
    Id int  NOT NULL IDENTITY(1, 1),
    Name varchar(100)  NOT NULL,
    Description varchar(100)  NULL,
    IsDeleted bit  NOT NULL,
    CreatedBy varchar(100)  NOT NULL,
    CreatedAt datetime  NOT NULL,
    UpdatedBy varchar(100)  NOT NULL,
    UpdatedAt datetime  NOT NULL,
    CONSTRAINT Category_pk PRIMARY KEY  (Id)
);

-- Table: Client
CREATE TABLE Client (
    Id int  NOT NULL IDENTITY(1, 1),
    Name varchar(100)  NOT NULL,
    Password varchar(100)  NOT NULL,
    Role varchar(100)  NOT NULL,
    Offset varchar(10)  NOT NULL,
    IsDeleted bit  NOT NULL,
    CreatedBy varchar(100)  NOT NULL,
    CreatedAt datetime  NOT NULL,
    UpdatedBy varchar(100)  NOT NULL,
    UpdatedAt datetime  NOT NULL,
    CONSTRAINT Client_pk PRIMARY KEY  (Id)
);

-- Table: InventoryMovement
CREATE TABLE InventoryMovement (
    Id int  NOT NULL IDENTITY(1, 1),
    Order_Id int NULL,
    Product_Id int  NOT NULL,
    Quantity int  NOT NULL,
    TypeMovement varchar(100)  NOT NULL,
	Remarks varchar(100)  NOT NULL,
    MovementDate datetime  NOT NULL,
    IsDeleted bit  NOT NULL,
    CreatedBy varchar(100)  NOT NULL,
    CreatedAt datetime  NOT NULL,
    UpdatedBy varchar(100)  NOT NULL,
    UpdatedAt datetime  NOT NULL,
    CONSTRAINT InventoryMovement_pk PRIMARY KEY  (Id)
);

-- Table: Order
CREATE TABLE "Order" (
    Id int  NOT NULL IDENTITY(1, 1),
    Shipper_Id int  NOT NULL,
    Code varchar(100)  NOT NULL,
    Status varchar(100)  NOT NULL,
    Description varchar(100)  NULL,
    DateReceipt datetime  NOT NULL,
    IsDeleted bit  NOT NULL,
    CreatedBy varchar(100)  NOT NULL,
    CreatedAt datetime  NOT NULL,
    UpdatedBy varchar(100)  NOT NULL,
    UpdatedAt datetime  NOT NULL,
    CONSTRAINT Order_pk PRIMARY KEY  (Id)
);

-- Table: OrderDetail
CREATE TABLE OrderDetail (
    Id int  NOT NULL IDENTITY(1, 1),
    Order_Id int  NOT NULL,
    Product_Id int  NOT NULL,
    Quantity int  NOT NULL,
    DateReceipt datetime  NOT NULL,
    Price decimal(18, 2) NOT NULL, -- Usa decimal para precisión específica
    IsDeleted bit  NOT NULL,
    CreatedBy varchar(100)  NOT NULL,
    CreatedAt datetime  NOT NULL,
    UpdatedBy varchar(100)  NOT NULL,
    UpdatedAt datetime  NOT NULL,
    CONSTRAINT OrderDetail_pk PRIMARY KEY  (Id)
);

-- Table: Product
CREATE TABLE Product (
    Id int  NOT NULL IDENTITY(1, 1),
    Category_Id int  NOT NULL,
    Name varchar(100)  NOT NULL,
    Description varchar(100)  NULL,
    Quantity int  NOT NULL,
    Price decimal(18, 2) NOT NULL, -- Usa decimal para precisión específica
    MinimumStock int  NOT NULL,
    IsDeleted bit  NOT NULL,
    CreatedBy varchar(100)  NOT NULL,
    CreatedAt datetime  NOT NULL,
    UpdatedBy varchar(100)  NOT NULL,
    UpdatedAt datetime  NOT NULL,
    CONSTRAINT Product_pk PRIMARY KEY  (Id)
);

-- Table: ProductSupplier
CREATE TABLE ProductSupplier (
    Id int  NOT NULL IDENTITY(1, 1),
    Product_Id int  NOT NULL,
    Supplier_Id int  NOT NULL,
    Detail varchar(100)  NULL,
    IsDeleted bit  NOT NULL,
    CreatedBy varchar(100)  NOT NULL,
    CreatedAt datetime  NOT NULL,
    UpdatedBy varchar(100)  NOT NULL,
    UpdatedAt datetime  NOT NULL,
    CONSTRAINT ProductSupplier_pk PRIMARY KEY  (Id)
);

-- Table: Shipper
CREATE TABLE Shipper (
    Id int  NOT NULL IDENTITY(1, 1),
    CompanyName varchar(100)  NOT NULL,
    Phone varchar(100)  NOT NULL,
    IsDeleted bit  NOT NULL,
    CreatedBy varchar(100)  NOT NULL,
    CreatedAt datetime  NOT NULL,
    UpdatedBy varchar(100)  NOT NULL,
    UpdatedAt datetime  NOT NULL,
    CONSTRAINT Shipper_pk PRIMARY KEY  (Id)
);

-- Table: Supplier
CREATE TABLE Supplier (
    Id int  NOT NULL IDENTITY(1, 1),
    Name varchar(100)  NOT NULL,
    Phone varchar(100)  NOT NULL,
    IsDeleted bit  NOT NULL,
    CreatedBy varchar(100)  NOT NULL,
    CreatedAt datetime  NOT NULL,
    UpdatedBy varchar(100)  NOT NULL,
    UpdatedAt datetime  NOT NULL,
    CONSTRAINT Supplier_pk PRIMARY KEY  (Id)
);

-- foreign keys
-- Reference: InventoryMovement_Order (table: InventoryMovement)
ALTER TABLE InventoryMovement ADD CONSTRAINT InventoryMovement_Order
    FOREIGN KEY (Order_Id)
    REFERENCES "Order" (Id);

-- Reference: InventoryMovement_Product (table: InventoryMovement)
ALTER TABLE InventoryMovement ADD CONSTRAINT InventoryMovement_Product
    FOREIGN KEY (Product_Id)
    REFERENCES Product (Id);

-- Reference: OrderDetail_Order (table: OrderDetail)
ALTER TABLE OrderDetail ADD CONSTRAINT OrderDetail_Order
    FOREIGN KEY (Order_Id)
    REFERENCES "Order" (Id);

-- Reference: OrderDetail_Product (table: OrderDetail)
ALTER TABLE OrderDetail ADD CONSTRAINT OrderDetail_Product
    FOREIGN KEY (Product_Id)
    REFERENCES Product (Id);

-- Reference: Order_Shipper (table: Order)
ALTER TABLE "Order" ADD CONSTRAINT Order_Shipper
    FOREIGN KEY (Shipper_Id)
    REFERENCES Shipper (Id);

-- Reference: ProductDetail_Product (table: ProductSupplier)
ALTER TABLE ProductSupplier ADD CONSTRAINT ProductDetail_Product
    FOREIGN KEY (Product_Id)
    REFERENCES Product (Id);

-- Reference: ProductDetail_Supplier (table: ProductSupplier)
ALTER TABLE ProductSupplier ADD CONSTRAINT ProductDetail_Supplier
    FOREIGN KEY (Supplier_Id)
    REFERENCES Supplier (Id);

-- Reference: Product_Category (table: Product)
ALTER TABLE Product ADD CONSTRAINT Product_Category
    FOREIGN KEY (Category_Id)
    REFERENCES Category (Id);

-- Carga de Datos

-- Tabla: Category
INSERT INTO Category (Name, Description, IsDeleted, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES
('Electrónica', 'Dispositivos y gadgets', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Hogar', 'Artículos para el hogar', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Ropa', 'Prendas de vestir', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Libros', 'Libros y material educativo', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Juguetes', 'Juguetes y juegos', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE());

-- Tabla: Client
INSERT INTO Client (Name, Password, Role, Offset, IsDeleted, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES
('Juan Pérez', 'pass1234', 'Administrador', '+00:00', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Ana López', 'pass2345', 'Trabajador', '+00:00', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Carlos García', 'pass3456', 'Trabajador', '+00:00', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('María González', 'pass4567', 'Administrador', '+00:00', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Lucía Fernández', 'pass5678', 'Trabajador', '+00:00', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE());

-- Tabla: Shipper
INSERT INTO Shipper (CompanyName, Phone, IsDeleted, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES
('Transporte Rápido', '123456789', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Logística Nacional', '987654321', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Envíos Express', '456123789', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Paquetería Segura', '321654987', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Courier Universal', '789456123', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE());

-- Tabla: Supplier
INSERT INTO Supplier (Name, Phone, IsDeleted, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES
('Proveedor Uno', '111222333', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Proveedor Dos', '222333444', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Proveedor Tres', '333444555', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Proveedor Cuatro', '444555666', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
('Proveedor Cinco', '555666777', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE());

-- Tabla: Product
INSERT INTO Product (Category_Id, Name, Description, Quantity, Price, MinimumStock, IsDeleted, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES
(1, 'Teléfono Inteligente', 'Última generación de smartphone', 50, 899.99, 10, 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(2, 'Sofá', 'Sofá cómodo de 3 plazas', 20, 499.99, 5, 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(3, 'Camisa Casual', 'Camisa de manga larga', 100, 29.99, 20, 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(4, 'Libro de Ciencia', 'Libro educativo de ciencias', 200, 15.99, 50, 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(5, 'Muñeca', 'Muñeca para niños', 150, 19.99, 30, 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE());

-- Tabla: Order
INSERT INTO "Order" (Shipper_Id, Code, Status, Description, DateReceipt, IsDeleted, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES
(1, 'ORD001', 'Pendiente', 'Pedido de productos electrónicos', GETUTCDATE(), 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(2, 'ORD002', 'Enviado', 'Pedido de artículos para el hogar', GETUTCDATE(), 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(3, 'ORD003', 'Completado', 'Pedido de ropa', GETUTCDATE(), 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(4, 'ORD004', 'Cancelado', 'Pedido de libros', GETUTCDATE(), 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(5, 'ORD005', 'Pendiente', 'Pedido de juguetes', GETUTCDATE(), 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE());

-- Tabla: InventoryMovement
INSERT INTO InventoryMovement (Order_Id, Product_Id, Quantity, TypeMovement, Remarks, MovementDate, IsDeleted, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES
(null, 1, 10, 'Entrada', 'Entrada de Teléfono Inteligente', GETUTCDATE(), 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(2, 2, 5, 'Salida', 'Salida de productos por orden con código ORD002', GETUTCDATE(), 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(null, 3, 20, 'Entrada', 'Entrada de Camisa Casual', GETUTCDATE(), 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(4, 4, 15, 'Salida', 'Salida de productos por orden con código ORD004',GETUTCDATE(), 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(null, 5, 25, 'Entrada', 'Entrada de Muñecas', GETUTCDATE(), 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE());

-- Tabla: OrderDetail
INSERT INTO OrderDetail (Order_Id, Product_Id, Quantity, DateReceipt, Price, IsDeleted, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES
(1, 1, 2, GETUTCDATE(), 899.99, 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(2, 2, 1, GETUTCDATE(), 499.99, 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(3, 3, 3, GETUTCDATE(), 29.99, 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(4, 4, 4, GETUTCDATE(), 15.99, 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(5, 5, 5, GETUTCDATE(), 19.99, 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE());

-- Tabla: ProductSupplier
INSERT INTO ProductSupplier (Product_Id, Supplier_Id, Detail, IsDeleted, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES
(1, 1, 'Proveedor de smartphones', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(2, 2, 'Proveedor de muebles', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(3, 3, 'Proveedor de ropa', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(4, 4, 'Proveedor de libros', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE()),
(5, 5, 'Proveedor de juguetes', 0, 'Admin', GETUTCDATE(), 'Admin', GETUTCDATE());