## API to do List (ASP.NET)

	Uma simples api ( Lista de tarefas ) onde o usuario pode cadastrar uma tarefa e atribuir a outros usu�rios.

### Recursos

	- CRUD de usuarios
	- CRUD de tarefas

### Tecnologias utilizadas

	- C# .net
	- ASP.NET
	- Sqlite

### Rotas de acesso

	OBS: As rotas podem ser acessadas utilizando o Postman, Insomnia ou utilizando o swagger : https://localhost:7066/swagger/index.html 

	- Usu�rios:
		- "/users" Ao fazer requisi��o com metodo GET, ir� retornar todos os usu�rios cadastrados.
		- "/users" Ao fazer requisi��o com metodo POST com os seguintes campos no json ( firstName, lastName, email, password e role  ) sendo que role pode ser 0 para admin e 1 para empregado, ir� criar um usuario novo.
		- "/users" Ao fazer requisi��o com metodo PUT ( id, firstName, lastName, email, password e role  ) sendo que o id � o do usuario, ir� atualizar o usuario.
		- "/users/{id}" Ao fazer requisi��o com metodo GET substituindo o {id} pelo id do usuario, ir� retornar apenas aquele usu�rio.
		- "/users/{id}" Ao fazer requisi��o com metodo DELETE substituindo o {id} pelo id do usuario, ir� remover o usuario.

	- Tarefas
		- "/tasks" Ao fazer requisi��o com metodo GET, ir� retornar todas as tarefas cadastradas.
		- "/tasks" Ao fazer requisi��o com metodo POST com os seguintes campos no json ( name, description, note, status e userId  ) sendo que status pode ser ( 0 para "Em progresso", 1 "Finalizado", 2 "Pausado", 3 "Cancelado"), ir� criar uma nova tarefa.
		- "/tasks" Ao fazer requisi��o com metodo PUT ( id, fname, description, note, status e userId ) sendo que o id � o da tarefa, ir� atualizar a mesma.
		- "/tasks/{id}" Ao fazer requisi��o com metodo GET substituindo o {id} pelo id da tarefa, ir� retornar apenas aquela tarefa.
		- "/tasks/{id}" Ao fazer requisi��o com metodo DELETE substituindo o {id} pelo id da tarefa, ir� remover a tarefa.

### Imagens

	<img src="Image/Image.png">
	<img src="Image/Image 2.png">



