# DesafioOscar

### Objetivo
* Receber um arquvito.txt e passar seus dados para um Banco de Dados, e mostrá-los em um DataGridView.

* 	Para que o programe funcione corretamente você terá que adicionar a conncetionString do seu Banco de dados.
	Com a connectionString em mãos substitua pela que se encontra no arquivo Form1.cs na linha 19.
	
## Banco de Dados
* 	Deixei o comando SQL que usei para criar o Banco de Dados de forma local, caso queira utilizar:
	CREATE TABLE Dados
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Comprador] VARCHAR(50) NULL, 
    [Descricao] VARCHAR(50) NULL, 
    [PrecoUnitario] FLOAT NULL, 
    [Quantidade] INT NULL, 
    [Endereco] VARCHAR(50) NULL, 
    [Fornecedor] VARCHAR(50) NULL
)
