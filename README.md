## API to do List (ASP.NET)

	Uma simples api ( Lista de tarefas ) onde o usuario pode cadastrar uma tarefa e atribuir a outros usuários.

### Recursos

	- CRUD de usuarios
	- CRUD de tarefas

### Tecnologias utilizadas

	- C# .net
	- ASP.NET
	- Sqlite

### Rotas de acesso

	OBS: As rotas podem ser acessadas utilizando o Postman, Insomnia ou utilizando o swagger : https://localhost:7066/swagger/index.html 

	- Usuários:
		- "/users" Ao fazer requisição com metodo GET, irá retornar todos os usuários cadastrados.
		- "/users" Ao fazer requisição com metodo POST com os seguintes campos no json ( firstName, lastName, email, password e role  ) sendo que role pode ser 0 para admin e 1 para empregado, irá criar um usuario novo.
		- "/users" Ao fazer requisição com metodo PUT ( id, firstName, lastName, email, password e role  ) sendo que o id é o do usuario, irá atualizar o usuario.
		- "/users/{id}" Ao fazer requisição com metodo GET substituindo o {id} pelo id do usuario, irá retornar apenas aquele usuário.
		- "/users/{id}" Ao fazer requisição com metodo DELETE substituindo o {id} pelo id do usuario, irá remover o usuario.

	- Tarefas
		- "/tasks" Ao fazer requisição com metodo GET, irá retornar todas as tarefas cadastradas.
		- "/tasks" Ao fazer requisição com metodo POST com os seguintes campos no json ( name, description, note, status e userId  ) sendo que status pode ser ( 0 para "Em progresso", 1 "Finalizado", 2 "Pausado", 3 "Cancelado"), irá criar uma nova tarefa.
		- "/tasks" Ao fazer requisição com metodo PUT ( id, fname, description, note, status e userId ) sendo que o id é o da tarefa, irá atualizar a mesma.
		- "/tasks/{id}" Ao fazer requisição com metodo GET substituindo o {id} pelo id da tarefa, irá retornar apenas aquela tarefa.
		- "/tasks/{id}" Ao fazer requisição com metodo DELETE substituindo o {id} pelo id da tarefa, irá remover a tarefa.

### Imagens

	<img src="Image/Image.png">
	<img src="Image/Image 2.png">



