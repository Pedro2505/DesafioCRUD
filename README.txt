Funcionamento do codigo: temos as pastas Entites, Migrations, Controller e Properties
temos as classes Tarefa que é a entidade principal para colocar as tasks e a classe TasksController onde é o codigo principal onde esta os metodos do CRUD e buscar por id da tarefa

Rodando o Codigo: abrirá o swagger para poder adicionar as tarefas editar remover ou buscar por id, para adicionar basta clicar em "try it out" apagar a parte string e aicionar a descricao da tarefa
msm coisa para editar e etc, buscar por id, e remover por id
antes de rodar o codigo temos q criar o banco(ja esta criado no meu pc)
basta escrever Add-Migration (nome da tabela) e depois dar um Update-Database para criar o banco de dados

Onde eu escrevo isso?: basta ir em ferramentas no visual stuio e abrir o gerenciador de pacotes nuget e abrir o console

Quais pacotes tenho q ter instalado?: 
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityframeworkCore.SqlServer
