
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/26/2018 13:43:02
-- Generated from EDMX file: C:\Users\vanph\source\repos\Day1\Model\SakilaDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[fk_address_city]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[address] DROP CONSTRAINT [fk_address_city];
GO
IF OBJECT_ID(N'[dbo].[fk_city_country]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[city] DROP CONSTRAINT [fk_city_country];
GO
IF OBJECT_ID(N'[dbo].[fk_customer_address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[customer] DROP CONSTRAINT [fk_customer_address];
GO
IF OBJECT_ID(N'[dbo].[fk_customer_store]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[customer] DROP CONSTRAINT [fk_customer_store];
GO
IF OBJECT_ID(N'[dbo].[fk_film_actor_actor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[film_actor] DROP CONSTRAINT [fk_film_actor_actor];
GO
IF OBJECT_ID(N'[dbo].[fk_film_actor_film]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[film_actor] DROP CONSTRAINT [fk_film_actor_film];
GO
IF OBJECT_ID(N'[dbo].[fk_film_category_category]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[film_category] DROP CONSTRAINT [fk_film_category_category];
GO
IF OBJECT_ID(N'[dbo].[fk_film_category_film]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[film_category] DROP CONSTRAINT [fk_film_category_film];
GO
IF OBJECT_ID(N'[dbo].[fk_film_language]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[film] DROP CONSTRAINT [fk_film_language];
GO
IF OBJECT_ID(N'[dbo].[fk_film_language_original]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[film] DROP CONSTRAINT [fk_film_language_original];
GO
IF OBJECT_ID(N'[dbo].[fk_inventory_film]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fk_inventory_film];
GO
IF OBJECT_ID(N'[dbo].[fk_inventory_store]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fk_inventory_store];
GO
IF OBJECT_ID(N'[dbo].[fk_payment_customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[payment] DROP CONSTRAINT [fk_payment_customer];
GO
IF OBJECT_ID(N'[dbo].[fk_payment_rental]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[payment] DROP CONSTRAINT [fk_payment_rental];
GO
IF OBJECT_ID(N'[dbo].[fk_payment_staff]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[payment] DROP CONSTRAINT [fk_payment_staff];
GO
IF OBJECT_ID(N'[dbo].[fk_rental_customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[rental] DROP CONSTRAINT [fk_rental_customer];
GO
IF OBJECT_ID(N'[dbo].[fk_rental_inventory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[rental] DROP CONSTRAINT [fk_rental_inventory];
GO
IF OBJECT_ID(N'[dbo].[fk_rental_staff]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[rental] DROP CONSTRAINT [fk_rental_staff];
GO
IF OBJECT_ID(N'[dbo].[fk_staff_address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[staff] DROP CONSTRAINT [fk_staff_address];
GO
IF OBJECT_ID(N'[dbo].[fk_staff_store]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[staff] DROP CONSTRAINT [fk_staff_store];
GO
IF OBJECT_ID(N'[dbo].[fk_store_address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[store] DROP CONSTRAINT [fk_store_address];
GO
IF OBJECT_ID(N'[dbo].[fk_store_staff]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[store] DROP CONSTRAINT [fk_store_staff];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[actor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[actor];
GO
IF OBJECT_ID(N'[dbo].[address]', 'U') IS NOT NULL
    DROP TABLE [dbo].[address];
GO
IF OBJECT_ID(N'[dbo].[category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[category];
GO
IF OBJECT_ID(N'[dbo].[city]', 'U') IS NOT NULL
    DROP TABLE [dbo].[city];
GO
IF OBJECT_ID(N'[dbo].[country]', 'U') IS NOT NULL
    DROP TABLE [dbo].[country];
GO
IF OBJECT_ID(N'[dbo].[customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[customer];
GO
IF OBJECT_ID(N'[dbo].[film]', 'U') IS NOT NULL
    DROP TABLE [dbo].[film];
GO
IF OBJECT_ID(N'[dbo].[film_actor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[film_actor];
GO
IF OBJECT_ID(N'[dbo].[film_category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[film_category];
GO
IF OBJECT_ID(N'[dbo].[film_text]', 'U') IS NOT NULL
    DROP TABLE [dbo].[film_text];
GO
IF OBJECT_ID(N'[dbo].[inventory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[inventory];
GO
IF OBJECT_ID(N'[dbo].[language]', 'U') IS NOT NULL
    DROP TABLE [dbo].[language];
GO
IF OBJECT_ID(N'[dbo].[payment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[payment];
GO
IF OBJECT_ID(N'[dbo].[rental]', 'U') IS NOT NULL
    DROP TABLE [dbo].[rental];
GO
IF OBJECT_ID(N'[dbo].[staff]', 'U') IS NOT NULL
    DROP TABLE [dbo].[staff];
GO
IF OBJECT_ID(N'[dbo].[store]', 'U') IS NOT NULL
    DROP TABLE [dbo].[store];
GO
IF OBJECT_ID(N'[dbo].[Tranee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tranee];
GO
IF OBJECT_ID(N'[sakilaModelStoreContainer].[MSreplication_options]', 'U') IS NOT NULL
    DROP TABLE [sakilaModelStoreContainer].[MSreplication_options];
GO
IF OBJECT_ID(N'[sakilaModelStoreContainer].[spt_fallback_db]', 'U') IS NOT NULL
    DROP TABLE [sakilaModelStoreContainer].[spt_fallback_db];
GO
IF OBJECT_ID(N'[sakilaModelStoreContainer].[spt_fallback_dev]', 'U') IS NOT NULL
    DROP TABLE [sakilaModelStoreContainer].[spt_fallback_dev];
GO
IF OBJECT_ID(N'[sakilaModelStoreContainer].[spt_fallback_usg]', 'U') IS NOT NULL
    DROP TABLE [sakilaModelStoreContainer].[spt_fallback_usg];
GO
IF OBJECT_ID(N'[sakilaModelStoreContainer].[spt_monitor]', 'U') IS NOT NULL
    DROP TABLE [sakilaModelStoreContainer].[spt_monitor];
GO
IF OBJECT_ID(N'[sakilaModelStoreContainer].[spt_values]', 'U') IS NOT NULL
    DROP TABLE [sakilaModelStoreContainer].[spt_values];
GO
IF OBJECT_ID(N'[sakilaModelStoreContainer].[customer_list]', 'U') IS NOT NULL
    DROP TABLE [sakilaModelStoreContainer].[customer_list];
GO
IF OBJECT_ID(N'[sakilaModelStoreContainer].[film_list]', 'U') IS NOT NULL
    DROP TABLE [sakilaModelStoreContainer].[film_list];
GO
IF OBJECT_ID(N'[sakilaModelStoreContainer].[sales_by_film_category]', 'U') IS NOT NULL
    DROP TABLE [sakilaModelStoreContainer].[sales_by_film_category];
GO
IF OBJECT_ID(N'[sakilaModelStoreContainer].[sales_by_store]', 'U') IS NOT NULL
    DROP TABLE [sakilaModelStoreContainer].[sales_by_store];
GO
IF OBJECT_ID(N'[sakilaModelStoreContainer].[staff_list]', 'U') IS NOT NULL
    DROP TABLE [sakilaModelStoreContainer].[staff_list];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'actors'
CREATE TABLE [dbo].[actors] (
    [actor_id] int IDENTITY(1,1) NOT NULL,
    [first_name] varchar(45)  NOT NULL,
    [last_name] varchar(45)  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'addresses'
CREATE TABLE [dbo].[addresses] (
    [address_id] int IDENTITY(1,1) NOT NULL,
    [address1] varchar(50)  NOT NULL,
    [address2] varchar(50)  NULL,
    [district] varchar(20)  NOT NULL,
    [city_id] int  NOT NULL,
    [postal_code] varchar(10)  NULL,
    [phone] varchar(20)  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'categories'
CREATE TABLE [dbo].[categories] (
    [category_id] tinyint IDENTITY(1,1) NOT NULL,
    [name] varchar(25)  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'cities'
CREATE TABLE [dbo].[cities] (
    [city_id] int IDENTITY(1,1) NOT NULL,
    [city1] varchar(50)  NOT NULL,
    [country_id] smallint  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'countries'
CREATE TABLE [dbo].[countries] (
    [country_id] smallint IDENTITY(1,1) NOT NULL,
    [country1] varchar(50)  NOT NULL,
    [last_update] datetime  NULL
);
GO

-- Creating table 'customers'
CREATE TABLE [dbo].[customers] (
    [customer_id] int IDENTITY(1,1) NOT NULL,
    [store_id] int  NOT NULL,
    [first_name] varchar(45)  NOT NULL,
    [last_name] varchar(45)  NOT NULL,
    [email] varchar(50)  NULL,
    [address_id] int  NOT NULL,
    [active] char(1)  NOT NULL,
    [create_date] datetime  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'films'
CREATE TABLE [dbo].[films] (
    [film_id] int IDENTITY(1,1) NOT NULL,
    [title] varchar(255)  NOT NULL,
    [description] varchar(max)  NULL,
    [release_year] varchar(4)  NULL,
    [language_id] tinyint  NOT NULL,
    [original_language_id] tinyint  NULL,
    [rental_duration] tinyint  NOT NULL,
    [rental_rate] decimal(4,2)  NOT NULL,
    [length] smallint  NULL,
    [replacement_cost] decimal(5,2)  NOT NULL,
    [rating] varchar(10)  NULL,
    [special_features] varchar(255)  NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'film_actor'
CREATE TABLE [dbo].[film_actor] (
    [actor_id] int  NOT NULL,
    [film_id] int  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'film_category'
CREATE TABLE [dbo].[film_category] (
    [film_id] int  NOT NULL,
    [category_id] tinyint  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'film_text'
CREATE TABLE [dbo].[film_text] (
    [film_id] smallint  NOT NULL,
    [title] varchar(255)  NOT NULL,
    [description] varchar(max)  NULL
);
GO

-- Creating table 'inventories'
CREATE TABLE [dbo].[inventories] (
    [inventory_id] int IDENTITY(1,1) NOT NULL,
    [film_id] int  NOT NULL,
    [store_id] int  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'languages'
CREATE TABLE [dbo].[languages] (
    [language_id] tinyint IDENTITY(1,1) NOT NULL,
    [name] char(20)  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'payments'
CREATE TABLE [dbo].[payments] (
    [payment_id] int IDENTITY(1,1) NOT NULL,
    [customer_id] int  NOT NULL,
    [staff_id] tinyint  NOT NULL,
    [rental_id] int  NULL,
    [amount] decimal(5,2)  NOT NULL,
    [payment_date] datetime  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'rentals'
CREATE TABLE [dbo].[rentals] (
    [rental_id] int IDENTITY(1,1) NOT NULL,
    [rental_date] datetime  NOT NULL,
    [inventory_id] int  NOT NULL,
    [customer_id] int  NOT NULL,
    [return_date] datetime  NULL,
    [staff_id] tinyint  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'staffs'
CREATE TABLE [dbo].[staffs] (
    [staff_id] tinyint IDENTITY(1,1) NOT NULL,
    [first_name] varchar(45)  NOT NULL,
    [last_name] varchar(45)  NOT NULL,
    [address_id] int  NOT NULL,
    [picture] varbinary(max)  NULL,
    [email] varchar(50)  NULL,
    [store_id] int  NOT NULL,
    [active] bit  NOT NULL,
    [username] varchar(16)  NOT NULL,
    [password] varchar(40)  NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'stores'
CREATE TABLE [dbo].[stores] (
    [store_id] int IDENTITY(1,1) NOT NULL,
    [manager_staff_id] tinyint  NOT NULL,
    [address_id] int  NOT NULL,
    [last_update] datetime  NOT NULL
);
GO

-- Creating table 'Tranees'
CREATE TABLE [dbo].[Tranees] (
    [TraineeID] int IDENTITY(1,1) NOT NULL,
    [Full_Name] nvarchar(50)  NOT NULL,
    [Birth_Date] datetime  NULL,
    [Gender] bit  NULL,
    [ET_IQ] int  NULL,
    [ET_Gmath] int  NULL,
    [ET_English] int  NULL,
    [Training_Class] nvarchar(50)  NULL,
    [Evaluation_Notes] nvarchar(max)  NULL
);
GO

-- Creating table 'MSreplication_options'
CREATE TABLE [dbo].[MSreplication_options] (
    [optname] nvarchar(128)  NOT NULL,
    [value] bit  NOT NULL,
    [major_version] int  NOT NULL,
    [minor_version] int  NOT NULL,
    [revision] int  NOT NULL,
    [install_failures] int  NOT NULL
);
GO

-- Creating table 'spt_fallback_db'
CREATE TABLE [dbo].[spt_fallback_db] (
    [xserver_name] varchar(30)  NOT NULL,
    [xdttm_ins] datetime  NOT NULL,
    [xdttm_last_ins_upd] datetime  NOT NULL,
    [xfallback_dbid] smallint  NULL,
    [name] varchar(30)  NOT NULL,
    [dbid] smallint  NOT NULL,
    [status] smallint  NOT NULL,
    [version] smallint  NOT NULL
);
GO

-- Creating table 'spt_fallback_dev'
CREATE TABLE [dbo].[spt_fallback_dev] (
    [xserver_name] varchar(30)  NOT NULL,
    [xdttm_ins] datetime  NOT NULL,
    [xdttm_last_ins_upd] datetime  NOT NULL,
    [xfallback_low] int  NULL,
    [xfallback_drive] char(2)  NULL,
    [low] int  NOT NULL,
    [high] int  NOT NULL,
    [status] smallint  NOT NULL,
    [name] varchar(30)  NOT NULL,
    [phyname] varchar(127)  NOT NULL
);
GO

-- Creating table 'spt_fallback_usg'
CREATE TABLE [dbo].[spt_fallback_usg] (
    [xserver_name] varchar(30)  NOT NULL,
    [xdttm_ins] datetime  NOT NULL,
    [xdttm_last_ins_upd] datetime  NOT NULL,
    [xfallback_vstart] int  NULL,
    [dbid] smallint  NOT NULL,
    [segmap] int  NOT NULL,
    [lstart] int  NOT NULL,
    [sizepg] int  NOT NULL,
    [vstart] int  NOT NULL
);
GO

-- Creating table 'spt_monitor'
CREATE TABLE [dbo].[spt_monitor] (
    [lastrun] datetime  NOT NULL,
    [cpu_busy] int  NOT NULL,
    [io_busy] int  NOT NULL,
    [idle] int  NOT NULL,
    [pack_received] int  NOT NULL,
    [pack_sent] int  NOT NULL,
    [connections] int  NOT NULL,
    [pack_errors] int  NOT NULL,
    [total_read] int  NOT NULL,
    [total_write] int  NOT NULL,
    [total_errors] int  NOT NULL
);
GO

-- Creating table 'spt_values'
CREATE TABLE [dbo].[spt_values] (
    [name] nvarchar(35)  NULL,
    [number] int  NOT NULL,
    [type] nchar(3)  NOT NULL,
    [low] int  NULL,
    [high] int  NULL,
    [status] int  NULL
);
GO

-- Creating table 'customer_list'
CREATE TABLE [dbo].[customer_list] (
    [ID] int  NOT NULL,
    [name] varchar(91)  NOT NULL,
    [address] varchar(50)  NOT NULL,
    [zip_code] varchar(10)  NULL,
    [phone] varchar(20)  NOT NULL,
    [city] varchar(50)  NOT NULL,
    [country] varchar(50)  NOT NULL,
    [notes] varchar(6)  NOT NULL,
    [SID] int  NOT NULL
);
GO

-- Creating table 'film_list'
CREATE TABLE [dbo].[film_list] (
    [FID] int  NULL,
    [title] varchar(255)  NULL,
    [description] varchar(max)  NULL,
    [category] varchar(25)  NOT NULL,
    [price] decimal(4,2)  NULL,
    [length] smallint  NULL,
    [rating] varchar(10)  NULL,
    [actors] varchar(91)  NOT NULL
);
GO

-- Creating table 'sales_by_film_category'
CREATE TABLE [dbo].[sales_by_film_category] (
    [category] varchar(25)  NOT NULL,
    [total_sales] decimal(38,2)  NULL
);
GO

-- Creating table 'sales_by_store'
CREATE TABLE [dbo].[sales_by_store] (
    [store_id] int  NOT NULL,
    [store] varchar(101)  NOT NULL,
    [manager] varchar(91)  NOT NULL,
    [total_sales] decimal(38,2)  NULL
);
GO

-- Creating table 'staff_list'
CREATE TABLE [dbo].[staff_list] (
    [ID] tinyint  NOT NULL,
    [name] varchar(91)  NOT NULL,
    [address] varchar(50)  NOT NULL,
    [zip_code] varchar(10)  NULL,
    [phone] varchar(20)  NOT NULL,
    [city] varchar(50)  NOT NULL,
    [country] varchar(50)  NOT NULL,
    [SID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [actor_id] in table 'actors'
ALTER TABLE [dbo].[actors]
ADD CONSTRAINT [PK_actors]
    PRIMARY KEY CLUSTERED ([actor_id] ASC);
GO

-- Creating primary key on [address_id] in table 'addresses'
ALTER TABLE [dbo].[addresses]
ADD CONSTRAINT [PK_addresses]
    PRIMARY KEY CLUSTERED ([address_id] ASC);
GO

-- Creating primary key on [category_id] in table 'categories'
ALTER TABLE [dbo].[categories]
ADD CONSTRAINT [PK_categories]
    PRIMARY KEY CLUSTERED ([category_id] ASC);
GO

-- Creating primary key on [city_id] in table 'cities'
ALTER TABLE [dbo].[cities]
ADD CONSTRAINT [PK_cities]
    PRIMARY KEY CLUSTERED ([city_id] ASC);
GO

-- Creating primary key on [country_id] in table 'countries'
ALTER TABLE [dbo].[countries]
ADD CONSTRAINT [PK_countries]
    PRIMARY KEY CLUSTERED ([country_id] ASC);
GO

-- Creating primary key on [customer_id] in table 'customers'
ALTER TABLE [dbo].[customers]
ADD CONSTRAINT [PK_customers]
    PRIMARY KEY CLUSTERED ([customer_id] ASC);
GO

-- Creating primary key on [film_id] in table 'films'
ALTER TABLE [dbo].[films]
ADD CONSTRAINT [PK_films]
    PRIMARY KEY CLUSTERED ([film_id] ASC);
GO

-- Creating primary key on [actor_id], [film_id] in table 'film_actor'
ALTER TABLE [dbo].[film_actor]
ADD CONSTRAINT [PK_film_actor]
    PRIMARY KEY CLUSTERED ([actor_id], [film_id] ASC);
GO

-- Creating primary key on [film_id], [category_id] in table 'film_category'
ALTER TABLE [dbo].[film_category]
ADD CONSTRAINT [PK_film_category]
    PRIMARY KEY CLUSTERED ([film_id], [category_id] ASC);
GO

-- Creating primary key on [film_id] in table 'film_text'
ALTER TABLE [dbo].[film_text]
ADD CONSTRAINT [PK_film_text]
    PRIMARY KEY CLUSTERED ([film_id] ASC);
GO

-- Creating primary key on [inventory_id] in table 'inventories'
ALTER TABLE [dbo].[inventories]
ADD CONSTRAINT [PK_inventories]
    PRIMARY KEY CLUSTERED ([inventory_id] ASC);
GO

-- Creating primary key on [language_id] in table 'languages'
ALTER TABLE [dbo].[languages]
ADD CONSTRAINT [PK_languages]
    PRIMARY KEY CLUSTERED ([language_id] ASC);
GO

-- Creating primary key on [payment_id] in table 'payments'
ALTER TABLE [dbo].[payments]
ADD CONSTRAINT [PK_payments]
    PRIMARY KEY CLUSTERED ([payment_id] ASC);
GO

-- Creating primary key on [rental_id] in table 'rentals'
ALTER TABLE [dbo].[rentals]
ADD CONSTRAINT [PK_rentals]
    PRIMARY KEY CLUSTERED ([rental_id] ASC);
GO

-- Creating primary key on [staff_id] in table 'staffs'
ALTER TABLE [dbo].[staffs]
ADD CONSTRAINT [PK_staffs]
    PRIMARY KEY CLUSTERED ([staff_id] ASC);
GO

-- Creating primary key on [store_id] in table 'stores'
ALTER TABLE [dbo].[stores]
ADD CONSTRAINT [PK_stores]
    PRIMARY KEY CLUSTERED ([store_id] ASC);
GO

-- Creating primary key on [TraineeID] in table 'Tranees'
ALTER TABLE [dbo].[Tranees]
ADD CONSTRAINT [PK_Tranees]
    PRIMARY KEY CLUSTERED ([TraineeID] ASC);
GO

-- Creating primary key on [optname], [value], [major_version], [minor_version], [revision], [install_failures] in table 'MSreplication_options'
ALTER TABLE [dbo].[MSreplication_options]
ADD CONSTRAINT [PK_MSreplication_options]
    PRIMARY KEY CLUSTERED ([optname], [value], [major_version], [minor_version], [revision], [install_failures] ASC);
GO

-- Creating primary key on [xserver_name], [xdttm_ins], [xdttm_last_ins_upd], [name], [dbid], [status], [version] in table 'spt_fallback_db'
ALTER TABLE [dbo].[spt_fallback_db]
ADD CONSTRAINT [PK_spt_fallback_db]
    PRIMARY KEY CLUSTERED ([xserver_name], [xdttm_ins], [xdttm_last_ins_upd], [name], [dbid], [status], [version] ASC);
GO

-- Creating primary key on [xserver_name], [xdttm_ins], [xdttm_last_ins_upd], [low], [high], [status], [name], [phyname] in table 'spt_fallback_dev'
ALTER TABLE [dbo].[spt_fallback_dev]
ADD CONSTRAINT [PK_spt_fallback_dev]
    PRIMARY KEY CLUSTERED ([xserver_name], [xdttm_ins], [xdttm_last_ins_upd], [low], [high], [status], [name], [phyname] ASC);
GO

-- Creating primary key on [xserver_name], [xdttm_ins], [xdttm_last_ins_upd], [dbid], [segmap], [lstart], [sizepg], [vstart] in table 'spt_fallback_usg'
ALTER TABLE [dbo].[spt_fallback_usg]
ADD CONSTRAINT [PK_spt_fallback_usg]
    PRIMARY KEY CLUSTERED ([xserver_name], [xdttm_ins], [xdttm_last_ins_upd], [dbid], [segmap], [lstart], [sizepg], [vstart] ASC);
GO

-- Creating primary key on [lastrun], [cpu_busy], [io_busy], [idle], [pack_received], [pack_sent], [connections], [pack_errors], [total_read], [total_write], [total_errors] in table 'spt_monitor'
ALTER TABLE [dbo].[spt_monitor]
ADD CONSTRAINT [PK_spt_monitor]
    PRIMARY KEY CLUSTERED ([lastrun], [cpu_busy], [io_busy], [idle], [pack_received], [pack_sent], [connections], [pack_errors], [total_read], [total_write], [total_errors] ASC);
GO

-- Creating primary key on [number], [type] in table 'spt_values'
ALTER TABLE [dbo].[spt_values]
ADD CONSTRAINT [PK_spt_values]
    PRIMARY KEY CLUSTERED ([number], [type] ASC);
GO

-- Creating primary key on [ID], [name], [address], [phone], [city], [country], [notes], [SID] in table 'customer_list'
ALTER TABLE [dbo].[customer_list]
ADD CONSTRAINT [PK_customer_list]
    PRIMARY KEY CLUSTERED ([ID], [name], [address], [phone], [city], [country], [notes], [SID] ASC);
GO

-- Creating primary key on [category], [actors] in table 'film_list'
ALTER TABLE [dbo].[film_list]
ADD CONSTRAINT [PK_film_list]
    PRIMARY KEY CLUSTERED ([category], [actors] ASC);
GO

-- Creating primary key on [category] in table 'sales_by_film_category'
ALTER TABLE [dbo].[sales_by_film_category]
ADD CONSTRAINT [PK_sales_by_film_category]
    PRIMARY KEY CLUSTERED ([category] ASC);
GO

-- Creating primary key on [store_id], [store], [manager] in table 'sales_by_store'
ALTER TABLE [dbo].[sales_by_store]
ADD CONSTRAINT [PK_sales_by_store]
    PRIMARY KEY CLUSTERED ([store_id], [store], [manager] ASC);
GO

-- Creating primary key on [ID], [name], [address], [phone], [city], [country], [SID] in table 'staff_list'
ALTER TABLE [dbo].[staff_list]
ADD CONSTRAINT [PK_staff_list]
    PRIMARY KEY CLUSTERED ([ID], [name], [address], [phone], [city], [country], [SID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [actor_id] in table 'film_actor'
ALTER TABLE [dbo].[film_actor]
ADD CONSTRAINT [fk_film_actor_actor]
    FOREIGN KEY ([actor_id])
    REFERENCES [dbo].[actors]
        ([actor_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [city_id] in table 'addresses'
ALTER TABLE [dbo].[addresses]
ADD CONSTRAINT [fk_address_city]
    FOREIGN KEY ([city_id])
    REFERENCES [dbo].[cities]
        ([city_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_address_city'
CREATE INDEX [IX_fk_address_city]
ON [dbo].[addresses]
    ([city_id]);
GO

-- Creating foreign key on [address_id] in table 'customers'
ALTER TABLE [dbo].[customers]
ADD CONSTRAINT [fk_customer_address]
    FOREIGN KEY ([address_id])
    REFERENCES [dbo].[addresses]
        ([address_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_customer_address'
CREATE INDEX [IX_fk_customer_address]
ON [dbo].[customers]
    ([address_id]);
GO

-- Creating foreign key on [address_id] in table 'staffs'
ALTER TABLE [dbo].[staffs]
ADD CONSTRAINT [fk_staff_address]
    FOREIGN KEY ([address_id])
    REFERENCES [dbo].[addresses]
        ([address_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_staff_address'
CREATE INDEX [IX_fk_staff_address]
ON [dbo].[staffs]
    ([address_id]);
GO

-- Creating foreign key on [address_id] in table 'stores'
ALTER TABLE [dbo].[stores]
ADD CONSTRAINT [fk_store_address]
    FOREIGN KEY ([address_id])
    REFERENCES [dbo].[addresses]
        ([address_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_store_address'
CREATE INDEX [IX_fk_store_address]
ON [dbo].[stores]
    ([address_id]);
GO

-- Creating foreign key on [category_id] in table 'film_category'
ALTER TABLE [dbo].[film_category]
ADD CONSTRAINT [fk_film_category_category]
    FOREIGN KEY ([category_id])
    REFERENCES [dbo].[categories]
        ([category_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_film_category_category'
CREATE INDEX [IX_fk_film_category_category]
ON [dbo].[film_category]
    ([category_id]);
GO

-- Creating foreign key on [country_id] in table 'cities'
ALTER TABLE [dbo].[cities]
ADD CONSTRAINT [fk_city_country]
    FOREIGN KEY ([country_id])
    REFERENCES [dbo].[countries]
        ([country_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_city_country'
CREATE INDEX [IX_fk_city_country]
ON [dbo].[cities]
    ([country_id]);
GO

-- Creating foreign key on [store_id] in table 'customers'
ALTER TABLE [dbo].[customers]
ADD CONSTRAINT [fk_customer_store]
    FOREIGN KEY ([store_id])
    REFERENCES [dbo].[stores]
        ([store_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_customer_store'
CREATE INDEX [IX_fk_customer_store]
ON [dbo].[customers]
    ([store_id]);
GO

-- Creating foreign key on [customer_id] in table 'payments'
ALTER TABLE [dbo].[payments]
ADD CONSTRAINT [fk_payment_customer]
    FOREIGN KEY ([customer_id])
    REFERENCES [dbo].[customers]
        ([customer_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_payment_customer'
CREATE INDEX [IX_fk_payment_customer]
ON [dbo].[payments]
    ([customer_id]);
GO

-- Creating foreign key on [customer_id] in table 'rentals'
ALTER TABLE [dbo].[rentals]
ADD CONSTRAINT [fk_rental_customer]
    FOREIGN KEY ([customer_id])
    REFERENCES [dbo].[customers]
        ([customer_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_rental_customer'
CREATE INDEX [IX_fk_rental_customer]
ON [dbo].[rentals]
    ([customer_id]);
GO

-- Creating foreign key on [film_id] in table 'film_actor'
ALTER TABLE [dbo].[film_actor]
ADD CONSTRAINT [fk_film_actor_film]
    FOREIGN KEY ([film_id])
    REFERENCES [dbo].[films]
        ([film_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_film_actor_film'
CREATE INDEX [IX_fk_film_actor_film]
ON [dbo].[film_actor]
    ([film_id]);
GO

-- Creating foreign key on [film_id] in table 'film_category'
ALTER TABLE [dbo].[film_category]
ADD CONSTRAINT [fk_film_category_film]
    FOREIGN KEY ([film_id])
    REFERENCES [dbo].[films]
        ([film_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [language_id] in table 'films'
ALTER TABLE [dbo].[films]
ADD CONSTRAINT [fk_film_language]
    FOREIGN KEY ([language_id])
    REFERENCES [dbo].[languages]
        ([language_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_film_language'
CREATE INDEX [IX_fk_film_language]
ON [dbo].[films]
    ([language_id]);
GO

-- Creating foreign key on [original_language_id] in table 'films'
ALTER TABLE [dbo].[films]
ADD CONSTRAINT [fk_film_language_original]
    FOREIGN KEY ([original_language_id])
    REFERENCES [dbo].[languages]
        ([language_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_film_language_original'
CREATE INDEX [IX_fk_film_language_original]
ON [dbo].[films]
    ([original_language_id]);
GO

-- Creating foreign key on [film_id] in table 'inventories'
ALTER TABLE [dbo].[inventories]
ADD CONSTRAINT [fk_inventory_film]
    FOREIGN KEY ([film_id])
    REFERENCES [dbo].[films]
        ([film_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_inventory_film'
CREATE INDEX [IX_fk_inventory_film]
ON [dbo].[inventories]
    ([film_id]);
GO

-- Creating foreign key on [store_id] in table 'inventories'
ALTER TABLE [dbo].[inventories]
ADD CONSTRAINT [fk_inventory_store]
    FOREIGN KEY ([store_id])
    REFERENCES [dbo].[stores]
        ([store_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_inventory_store'
CREATE INDEX [IX_fk_inventory_store]
ON [dbo].[inventories]
    ([store_id]);
GO

-- Creating foreign key on [inventory_id] in table 'rentals'
ALTER TABLE [dbo].[rentals]
ADD CONSTRAINT [fk_rental_inventory]
    FOREIGN KEY ([inventory_id])
    REFERENCES [dbo].[inventories]
        ([inventory_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_rental_inventory'
CREATE INDEX [IX_fk_rental_inventory]
ON [dbo].[rentals]
    ([inventory_id]);
GO

-- Creating foreign key on [rental_id] in table 'payments'
ALTER TABLE [dbo].[payments]
ADD CONSTRAINT [fk_payment_rental]
    FOREIGN KEY ([rental_id])
    REFERENCES [dbo].[rentals]
        ([rental_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_payment_rental'
CREATE INDEX [IX_fk_payment_rental]
ON [dbo].[payments]
    ([rental_id]);
GO

-- Creating foreign key on [staff_id] in table 'payments'
ALTER TABLE [dbo].[payments]
ADD CONSTRAINT [fk_payment_staff]
    FOREIGN KEY ([staff_id])
    REFERENCES [dbo].[staffs]
        ([staff_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_payment_staff'
CREATE INDEX [IX_fk_payment_staff]
ON [dbo].[payments]
    ([staff_id]);
GO

-- Creating foreign key on [staff_id] in table 'rentals'
ALTER TABLE [dbo].[rentals]
ADD CONSTRAINT [fk_rental_staff]
    FOREIGN KEY ([staff_id])
    REFERENCES [dbo].[staffs]
        ([staff_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_rental_staff'
CREATE INDEX [IX_fk_rental_staff]
ON [dbo].[rentals]
    ([staff_id]);
GO

-- Creating foreign key on [store_id] in table 'staffs'
ALTER TABLE [dbo].[staffs]
ADD CONSTRAINT [fk_staff_store]
    FOREIGN KEY ([store_id])
    REFERENCES [dbo].[stores]
        ([store_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_staff_store'
CREATE INDEX [IX_fk_staff_store]
ON [dbo].[staffs]
    ([store_id]);
GO

-- Creating foreign key on [manager_staff_id] in table 'stores'
ALTER TABLE [dbo].[stores]
ADD CONSTRAINT [fk_store_staff]
    FOREIGN KEY ([manager_staff_id])
    REFERENCES [dbo].[staffs]
        ([staff_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_store_staff'
CREATE INDEX [IX_fk_store_staff]
ON [dbo].[stores]
    ([manager_staff_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------