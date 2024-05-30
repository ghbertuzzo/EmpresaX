Passo a passo de configuração/execução da aplicação.

Banco de dados:

  PostgreSQL - versão 16.3-1 Windows x64 (disponível no link https://sbp.enterprisedb.com/getfile.jsp?fileid=1259019)
	
  IDE pgAdmin 4 (opcional)
  
    Passo 1: Baixar/abrir o arquivo script-create.sql na raíz desse repositório
    
    Passo 2: Executar cada instrução na ordem do script (certifique-se de estar usando a database que foi criada para criação das tabelas)

Aplicação:

  Microsoft Visual Studio 2022
	
  Pacotes Nuget do projeto:
  
	    Dapper (2.1.35)
     
	    Npgsql (8.0.3)
     
	    ReportViewerCore.WinForms(15.1.19)
     
		
  Passo de configuração: Altere o arquivo app.config na raíz do projeto para mudar a string de conexão do seu banco de dados.
	
	    Normalmente rodamos local então mantenha o IP da string padrão. 
	    
	    A porta padrão do postgresql é 5432, caso tenha feito alguma alteração na instalação ajuste-a. 
	    
	    O nome da database se seguir o script será empresa_x. 
	    
	    O usuário padrão é postgres caso utilize outro altere na string também. 
	    
	    O password é configurado na instalação do postgres, coloque a senha criada.


