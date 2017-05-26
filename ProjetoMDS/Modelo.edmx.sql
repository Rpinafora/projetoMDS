
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/26/2017 12:59:22
-- Generated from EDMX file: C:\Users\User\Desktop\projetoMDS\Prototipo Não Funcional MDS\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [basedadosMDS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ConsultasPacientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultasSet] DROP CONSTRAINT [FK_ConsultasPacientes];
GO
IF OBJECT_ID(N'[dbo].[FK_DoutoresConsultas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultasSet] DROP CONSTRAINT [FK_DoutoresConsultas];
GO
IF OBJECT_ID(N'[dbo].[FK_DoutoresEspecializacoes_Doutores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DoutoresEspecializacoes] DROP CONSTRAINT [FK_DoutoresEspecializacoes_Doutores];
GO
IF OBJECT_ID(N'[dbo].[FK_DoutoresEspecializacoes_Especializacoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DoutoresEspecializacoes] DROP CONSTRAINT [FK_DoutoresEspecializacoes_Especializacoes];
GO
IF OBJECT_ID(N'[dbo].[FK_Pacientes_inherits_Pessoas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Pacientes] DROP CONSTRAINT [FK_Pacientes_inherits_Pessoas];
GO
IF OBJECT_ID(N'[dbo].[FK_Utilizadores_inherits_Pessoas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Utilizadores] DROP CONSTRAINT [FK_Utilizadores_inherits_Pessoas];
GO
IF OBJECT_ID(N'[dbo].[FK_Doutores_inherits_Utilizadores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Doutores] DROP CONSTRAINT [FK_Doutores_inherits_Utilizadores];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PessoasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet];
GO
IF OBJECT_ID(N'[dbo].[ConsultasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultasSet];
GO
IF OBJECT_ID(N'[dbo].[EspecializacoesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EspecializacoesSet];
GO
IF OBJECT_ID(N'[dbo].[PessoasSet_Pacientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet_Pacientes];
GO
IF OBJECT_ID(N'[dbo].[PessoasSet_Utilizadores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet_Utilizadores];
GO
IF OBJECT_ID(N'[dbo].[PessoasSet_Doutores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet_Doutores];
GO
IF OBJECT_ID(N'[dbo].[DoutoresEspecializacoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DoutoresEspecializacoes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PessoasSet'
CREATE TABLE [dbo].[PessoasSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [dataNascimento] datetime  NOT NULL,
    [numTelefone] int  NULL,
    [nif] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ConsultasSet'
CREATE TABLE [dbo].[ConsultasSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [obs] nvarchar(max)  NULL,
    [sintomas] nvarchar(max)  NOT NULL,
    [diagonostico] nvarchar(max)  NOT NULL,
    [PacientesId] int  NOT NULL,
    [DoutoresId] int  NOT NULL
);
GO

-- Creating table 'EspecializacoesSet'
CREATE TABLE [dbo].[EspecializacoesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [obs] nvarchar(max)  NULL
);
GO

-- Creating table 'PessoasSet_Pacientes'
CREATE TABLE [dbo].[PessoasSet_Pacientes] (
    [peso] decimal(18,0)  NOT NULL,
    [altura] decimal(18,0)  NOT NULL,
    [obsClinicas] nvarchar(max)  NULL,
    [tipoSanguineo] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'PessoasSet_Utilizadores'
CREATE TABLE [dbo].[PessoasSet_Utilizadores] (
    [email] nvarchar(max)  NULL,
    [password] nvarchar(max)  NOT NULL,
    [funcao] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'PessoasSet_Doutores'
CREATE TABLE [dbo].[PessoasSet_Doutores] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'DoutoresEspecializacoes'
CREATE TABLE [dbo].[DoutoresEspecializacoes] (
    [Doutores_Id] int  NOT NULL,
    [Especializacoes_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PessoasSet'
ALTER TABLE [dbo].[PessoasSet]
ADD CONSTRAINT [PK_PessoasSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConsultasSet'
ALTER TABLE [dbo].[ConsultasSet]
ADD CONSTRAINT [PK_ConsultasSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EspecializacoesSet'
ALTER TABLE [dbo].[EspecializacoesSet]
ADD CONSTRAINT [PK_EspecializacoesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PessoasSet_Pacientes'
ALTER TABLE [dbo].[PessoasSet_Pacientes]
ADD CONSTRAINT [PK_PessoasSet_Pacientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PessoasSet_Utilizadores'
ALTER TABLE [dbo].[PessoasSet_Utilizadores]
ADD CONSTRAINT [PK_PessoasSet_Utilizadores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PessoasSet_Doutores'
ALTER TABLE [dbo].[PessoasSet_Doutores]
ADD CONSTRAINT [PK_PessoasSet_Doutores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Doutores_Id], [Especializacoes_Id] in table 'DoutoresEspecializacoes'
ALTER TABLE [dbo].[DoutoresEspecializacoes]
ADD CONSTRAINT [PK_DoutoresEspecializacoes]
    PRIMARY KEY CLUSTERED ([Doutores_Id], [Especializacoes_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PacientesId] in table 'ConsultasSet'
ALTER TABLE [dbo].[ConsultasSet]
ADD CONSTRAINT [FK_ConsultasPacientes]
    FOREIGN KEY ([PacientesId])
    REFERENCES [dbo].[PessoasSet_Pacientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultasPacientes'
CREATE INDEX [IX_FK_ConsultasPacientes]
ON [dbo].[ConsultasSet]
    ([PacientesId]);
GO

-- Creating foreign key on [DoutoresId] in table 'ConsultasSet'
ALTER TABLE [dbo].[ConsultasSet]
ADD CONSTRAINT [FK_DoutoresConsultas]
    FOREIGN KEY ([DoutoresId])
    REFERENCES [dbo].[PessoasSet_Doutores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoutoresConsultas'
CREATE INDEX [IX_FK_DoutoresConsultas]
ON [dbo].[ConsultasSet]
    ([DoutoresId]);
GO

-- Creating foreign key on [Doutores_Id] in table 'DoutoresEspecializacoes'
ALTER TABLE [dbo].[DoutoresEspecializacoes]
ADD CONSTRAINT [FK_DoutoresEspecializacoes_Doutores]
    FOREIGN KEY ([Doutores_Id])
    REFERENCES [dbo].[PessoasSet_Doutores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Especializacoes_Id] in table 'DoutoresEspecializacoes'
ALTER TABLE [dbo].[DoutoresEspecializacoes]
ADD CONSTRAINT [FK_DoutoresEspecializacoes_Especializacoes]
    FOREIGN KEY ([Especializacoes_Id])
    REFERENCES [dbo].[EspecializacoesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoutoresEspecializacoes_Especializacoes'
CREATE INDEX [IX_FK_DoutoresEspecializacoes_Especializacoes]
ON [dbo].[DoutoresEspecializacoes]
    ([Especializacoes_Id]);
GO

-- Creating foreign key on [Id] in table 'PessoasSet_Pacientes'
ALTER TABLE [dbo].[PessoasSet_Pacientes]
ADD CONSTRAINT [FK_Pacientes_inherits_Pessoas]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PessoasSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PessoasSet_Utilizadores'
ALTER TABLE [dbo].[PessoasSet_Utilizadores]
ADD CONSTRAINT [FK_Utilizadores_inherits_Pessoas]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PessoasSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PessoasSet_Doutores'
ALTER TABLE [dbo].[PessoasSet_Doutores]
ADD CONSTRAINT [FK_Doutores_inherits_Utilizadores]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PessoasSet_Utilizadores]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------