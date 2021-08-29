CREATE TABLE Cliente(
    Id INTEGER NOT NULL,
    Nome VARCHAR(250) NOT NULL,
    Telefone VARCHAR(20),
    Celular VARCHAR(20),
    Ativo CHAR NOT NULL,
CONSTRAINT PK_Id_Cliente PRIMARY KEY(Id)
);
CREATE GENERATOR GT_A_Inc_Cliente;

SET TERM ^ ;
CREATE TRIGGER TR_A_INC_Cliente FOR Cliente ACTIVE
BEFORE INSERT POSITION 0
AS
BEGIN 
    new.ID = gen_id(GT_A_Inc_Cliente,1);
END^
SET TERM ; ^

CREATE TABLE Produto(
    Id INTEGER NOT NULL,
    Data DATE NOT NULL,
    Descricao VARCHAR(250) NOT NULL,
    Valor DECIMAL(10,2) NOT NULL,
    Ativo CHAR NOT NULL,
CONSTRAINT PK_Id_Produto PRIMARY KEY(Id)
);

CREATE GENERATOR GT_A_INC_Produto;

SET TERM ^ ;
CREATE TRIGGER TR_A_INC_Produto FOR Produto ACTIVE
BEFORE INSERT POSITION 0
AS
BEGIN 
    new.ID = gen_id(GT_A_Inc_Produto,1);
END^
SET TERM ; ^



CREATE TABLE Venda(
    Id INTEGER NOT NULL,
    Cliente_Id INTEGER NOT NULL,
    Produto_Id INTEGER NOT NULL,
    Data DATE NOT NULL,
    Quantidade INTEGER NOT NULL,
    Valor DECIMAL(10,2) NOT NULL,
CONSTRAINT PK_Id_Venda PRIMARY KEY(Id),
CONSTRAINT FK_Cli_Ven FOREIGN KEY(Cliente_Id) REFERENCES Cliente(Id),
CONSTRAINT FK_Pro_Ven FOREIGN KEY(Produto_Id) REFERENCES Produto(Id)
);

CREATE GENERATOR GT_A_INC_Venda;

SET TERM ^ ;
CREATE TRIGGER TR_A_INC_Venda FOR Venda ACTIVE
BEFORE INSERT POSITION 0
AS
BEGIN 
    new.ID = gen_id(GT_A_Inc_Venda,1);
END^
SET TERM ; ^

CREATE TABLE Retirada(
    Id INTEGER NOT NULL,
    Cliente_Id INTEGER NOT NULL,
    Produto_Id INTEGER NOT NULL,
    Data DATE NOT NULL,
    Quantidade INTEGER NOT NULL ,
    Valor DECIMAL(10,2) NOT NULL,

CONSTRAINT PK_Id_Retirada PRIMARY KEY(Id),
CONSTRAINT FK_Cli_Ret FOREIGN KEY(Cliente_Id) REFERENCES Cliente(Id),
CONSTRAINT FK_Pro_Ret FOREIGN KEY(Produto_Id) REFERENCES Produto(Id)    

);

CREATE GENERATOR GT_A_INC_Retirada;

SET TERM ^ ;
CREATE TRIGGER TR_A_INC_Retirada FOR Retirada ACTIVE
BEFORE INSERT POSITION 0
AS
BEGIN 
    new.ID = gen_id(GT_A_Inc_Retirada,1);
END^
SET TERM ; ^

CREATE VIEW Saldo_Cliente(
    CLIENTE_ID, 
    Nome, 
    PRODUTO_ID, 
    Descricao, 
    Saldo, 
    Valor, 
    Total
)
AS 
SELECT CLIENTE_ID, Nome, PRODUTO_ID, Descricao, SUM(Venda - Retirada) AS Saldo, Valor, (Valor * SUM(Venda - Retirada)) AS Total
FROM (
    SELECT V.CLIENTE_ID, C.Nome, V.PRODUTO_ID, P.Descricao, 0 AS Retirada, SUM( V.QUANTIDADE) AS Venda, V.VALOR
    FROM VENDA V
    INNER JOIN Cliente C ON V.Cliente_Id = C.Id
    INNER JOIN Produto P ON V.Produto_Id = P.Id
    GROUP BY V.CLIENTE_ID, C.Nome, V.PRODUTO_ID, P.Descricao, Retirada,   V.VALOR

    UNION

    SELECT R.CLIENTE_ID, C.Nome, R.PRODUTO_ID, P.Descricao, SUM( R.QUANTIDADE), 0 AS Venda, R.VALOR
    FROM RETIRADA R
    INNER JOIN Cliente C ON R.Cliente_Id = C.Id
    INNER JOIN Produto P ON R.Produto_Id = P.Id
    GROUP BY R.CLIENTE_ID, C.Nome, R.PRODUTO_ID, P.Descricao, Venda, R.VALOR
)
GROUP BY CLIENTE_ID, Nome, PRODUTO_ID, Descricao, Valor;

GRANT ALL ON Cliente TO Rango;
GRANT ALL ON Produto TO Rango;
GRANT ALL ON Retirada TO Rango;
GRANT ALL ON Venda TO Rango;
GRANT ALL ON Saldo_Cliente TO Rango;