Passo a passo de configuração/execução da aplicação.

Banco de dados:

  PostgreSQL - versão 16.3-1 Windows x64 (disponível no link https://sbp.enterprisedb.com/getfile.jsp?fileid=1259019)
  
    Passo 1: Baixar/abrir o arquivo script-create.sql na raíz desse repositório
    
    Passo 2: Executar cada instrução na ordem do script (certifique-se de estar usando a database que foi criada para criação das tabelas)

Aplicação:

  Microsoft Visual Studio 2022
	
  Pacotes Nuget do projeto:
  
	    Dapper (2.1.35)
     
	    Npgsql (8.0.3)
     
	    ReportViewerCore.WinForms(15.1.19)

	    Microsoft.Extensions.DependencyInjection(8.0.0)
     
	    Microsoft.Extensions.DependencyInjection.Abstractions(8.0.1)
     
		
  Passo de configuração: Altere o arquivo app.config na raíz do projeto para mudar a string de conexão do seu banco de dados.
	
	    Normalmente rodamos local então mantenha o IP da string padrão. 
	    
	    A porta padrão do postgresql é 5432, caso tenha feito alguma alteração na instalação ajuste-a. 
	    
	    O nome da database se seguir o script será empresa_x. 
	    
	    O usuário padrão é postgres caso utilize outro altere na string também. 
	    
	    O password é configurado na instalação do postgres, coloque a senha criada.



Pontos técnicos: 
	- Optei por utilizar o Dapper para facilitar o desenvolvimento geral da aplicação, e por ser mais consolidado no mercado, outro fator é por sua boa performance em comparação a outros ORM mais robustos como o entity framework.
	- Versões de libs e programas usados estão específicados no README do repositório.

Pontos de melhoria:
	- Poderia criar um script para ser executado de uma vez, que verifica se a base de dados, as tabelas e os indíces já existem antes da sua criação (create if not exists...). Que hoje é bastante utilizado em pipelines automáticas.
	- Praticamente nenhuma validação é feita nos CRUDS. Portanto se tentar inserir alguma entidade com campo vazio receberá erros.
	- A interface poderia ser melhorada, apenas criei alguns ícones próprios na tela do menu principal e no datagridview de vendas para demonstrar o uso das dimensões corretas (pixels), formato de arquivos, importações e afins.
	- Aspectos de perfumaria foram ignoradas, por exemplo, tratar casas decimais nos valores monetários, formatação/validação de email,telefone,endereço e afins.
	- Validações no estoque de produtos não foram feitas de forma correta. É possível deixar os produtos negativos, ao lançar vendas caso você selecione o mesmo produto mais de uma vez a simples validação de consultar quantos itens possuem em estoque não funcionará corretamente. Exemplo adicionar 2 vezes o mesmo produto com 5 unidades, caso o estoque do produto seja maior que 5 e menor que 10 ele naõ vai realizar a validação e o estoque ficará negativo.
	- Caso exista vendas de um produto, ao tentar excluí-lo do CRUD receberá um erro de restrição de chave estrangeira. Para solucionar isso poderia efetuar uma exclusão lógica, desativando o item sem realizar a exclusão física da base de dados.
	- Estou lidando com as excessões ao invés de preveni-lás. Num ambiente real seria melhor fazer a prevenção dessas excessões do que tratá-las após seus lançamentos.
	- Todos os relatórios poderiam ter um formulário prévio com filtros para melhor usabilidade.
	- O relatório de vendas poderia ter filtros de Clientes, Produtos, Datas (períodos), Valores dos pedidos, entre outros. Criei apenas um onde é necessário uma query com joins de todas tabelas do sistema para demonstração.
	- A arquitetura poderia ser um pouco mais estruturado separado por projetos. Por exemplo adicionar camadas BLL, DAO, DAL. Porém por ser apenas um teste de pequena complexidade decidi fazer dessa maneira, mas caso fosse algo mais complexo e escalável seria mais adequado outra divisão lógica.

