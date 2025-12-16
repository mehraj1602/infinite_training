
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/16/2025 11:17:44
-- Generated from EDMX file: C:\Users\mehrajf\Infinite_training\practise ques\ModelFirstDemo\ModelFirstDemo\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPizzadb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pizzas'
CREATE TABLE [dbo].[Pizzas] (
    [PizzaId] int  NOT NULL,
    [PizzaName] varchar(30)  NOT NULL,
    [Description] varchar(50)  NOT NULL,
    [Price] float  NOT NULL,
    [Type] varchar(30)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PizzaId] in table 'Pizzas'
ALTER TABLE [dbo].[Pizzas]
ADD CONSTRAINT [PK_Pizzas]
    PRIMARY KEY CLUSTERED ([PizzaId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------