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
/*****************************************************************************************/
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
/*****************************************************************************************/
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
/*****************************************************************************************/
CREATE TABLE Credito(
    Id INTEGER NOT NULL,
    Cliente_Id INTEGER NOT NULL,
    Data DATE NOT NULL,
    Valor DECIMAL(10,2) NOT NULL,
CONSTRAINT PK_Id_Credito PRIMARY KEY(Id),
CONSTRAINT FK_Cli_Cre FOREIGN KEY(Cliente_Id) REFERENCES Cliente(Id)
);

CREATE GENERATOR GT_A_INC_Credito;

SET TERM ^ ;
CREATE TRIGGER TR_A_INC_Credito FOR Credito ACTIVE
BEFORE INSERT POSITION 0
AS
BEGIN 
    new.ID = gen_id(GT_A_INC_Credito, 1);
END^
SET TERM ; ^
/*****************************************************************************************/
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
/*****************************************************************************************/
CREATE TABLE Debito(
    Id INTEGER NOT NULL,
    Cliente_Id INTEGER NOT NULL,
    Produto_Id INTEGER NOT NULL,
    Data DATE NOT NULL,
    Quantidade INTEGER NOT NULL ,
    Valor DECIMAL(10,2) NOT NULL,

CONSTRAINT PK_Id_Debito PRIMARY KEY(Id),
CONSTRAINT FK_Cli_Deb FOREIGN KEY(Cliente_Id) REFERENCES Cliente(Id),
CONSTRAINT FK_Pro_Dev FOREIGN KEY(Produto_Id) REFERENCES Produto(Id)    

);

CREATE GENERATOR GT_A_INC_Debito;

SET TERM ^ ;
CREATE TRIGGER TR_A_INC_Debito FOR Debito ACTIVE
BEFORE INSERT POSITION 0
AS
BEGIN 
    new.ID = gen_id(GT_A_Inc_Debito,1);
END^
SET TERM ; ^
/*****************************************************************************************/
CREATE VIEW Saldo_Cliente(
    CLIENTE_ID, Nome, PRODUTO_ID, Descricao, Saldo, Valor, Total
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
/*****************************************************************************************/
CREATE VIEW Saldo_Credito_Debito
(
Cliente_Id, Nome, Credito, Debito, Saldo
)
AS
SELECT Cliente_Id, Nome, SUM(Credito) AS Credito, SUM(Debito) AS Debito, (SUM(Credito) - SUM(Debito)) AS Saldo
FROM (
SELECT D.Cliente_Id, C.Nome, SUM(D.Quantidade * D.Valor) AS Debito, 0 AS Credito 
FROM Debito D
INNER JOIN Cliente C ON D.Cliente_Id = C.Id
INNER JOIN Produto P ON D.Produto_Id = P.Id
GROUP BY D.Cliente_Id, C.Nome, D.Valor, Credito 

UNION 

SELECT CR.Cliente_Id,C.Nome, 0 AS G, SUM(CR.Valor) AS Credito
FROM Credito CR
INNER JOIN Cliente C ON CR.Cliente_Id = C.Id
GROUP BY CR.Cliente_Id,C.Nome, G
)
GROUP BY Cliente_Id, Nome;
/*****************************************************************************************/
CREATE VIEW Extrato_Produto(
    Cliente_Id, Nome, Produto_Id, Descricao, Data, Retirada, Venda, Valor, Total, Info
)
AS

SELECT V.CLIENTE_ID, C.Nome, V.PRODUTO_ID, P.Descricao, V.Data, 0 AS Retirada, SUM( V.QUANTIDADE) AS Venda, V.VALOR, SUM( V.QUANTIDADE) * V.Valor AS Total, 'Venda' AS Info
FROM VENDA V
INNER JOIN Cliente C ON V.Cliente_Id = C.Id
INNER JOIN Produto P ON V.Produto_Id = P.Id
GROUP BY V.CLIENTE_ID, C.Nome, V.PRODUTO_ID, P.Descricao, V.Data, Retirada, V.VALOR

UNION ALL

SELECT R.CLIENTE_ID, C.Nome, R.PRODUTO_ID, P.Descricao, R.Data, SUM( R.QUANTIDADE), 0 AS Venda, R.VALOR, SUM( R.QUANTIDADE) * R.Valor AS Total, 'Retirada' AS Info
FROM RETIRADA R
INNER JOIN Cliente C ON R.Cliente_Id = C.Id
INNER JOIN Produto P ON R.Produto_Id = P.Id
GROUP BY R.CLIENTE_ID, C.Nome, R.PRODUTO_ID, P.Descricao, R.Data, Venda, R.VALOR, Info;
/*****************************************************************************************/
CREATE VIEW Extrato_CD(
    Cliente_Id, Data, Nome, Produto_Id, Descricao, Credito, Debito, Saldo, Info
)
AS
SELECT Cliente_Id, Data, Nome, Produto_Id, Descricao, SUM(Credito) AS Credito, SUM(Debito) AS Debito, (SUM(Credito) - SUM(Debito)) AS Saldo, Info
FROM
  (
    SELECT D.Cliente_Id, D.Data, C.Nome, D.Produto_Id, P.Descricao, SUM(D.Quantidade * D.Valor) AS Debito, 0 AS Credito, 'Débito' AS Info
    FROM Debito D
    INNER JOIN Cliente C ON D.Cliente_Id = C.Id
    INNER JOIN Produto P ON D.Produto_Id = P.Id
    GROUP BY D.Cliente_Id, D.Data, C.Nome, D.Produto_Id, P.Descricao, D.Valor, Credito, Info
UNION 
    SELECT CR.Cliente_Id, CR.Data, C.Nome, 0 AS P, 'Entrada de Crédito' AS D, 0 AS G, SUM(CR.Valor) AS Credito, 'Crédito' AS Info
                
    FROM Credito CR
    INNER JOIN Cliente C ON CR.Cliente_Id = C.Id
    GROUP BY CR.Cliente_Id, CR.Data, C.Nome, P, D, G, Info)
    
GROUP BY Cliente_Id, Data, Nome, Produto_Id, Descricao, Info;
/*****************************************************************************************/
GRANT ALL ON Extrato_CD TO rango;
GRANT ALL ON Extrato_Produto TO rango;
GRANT ALL ON Cliente TO rango;
GRANT ALL ON Produto TO rango;
GRANT ALL ON Retirada TO rango;
GRANT ALL ON Venda TO rango;
GRANT ALL ON Saldo_Cliente TO rango;
GRANT ALL ON Credito TO rango;
GRANT ALL ON Debito TO rango;
GRANT ALL ON Saldo_Credito_Debito TO rango;
