# Task Management API

API desenvolvida como parte do desafio prático da trilha .NET da DIO, com foco na construção de uma aplicação CRUD utilizando ASP.NET Core, Entity Framework e banco de dados relacional.

O projeto consiste em um sistema gerenciador de tarefas, permitindo cadastrar, atualizar, consultar e remover tarefas através de endpoints REST documentados com Swagger.

Durante o desenvolvimento foram aplicados conceitos de Web API, Entity Framework Core, migrations, manipulação de dados e arquitetura backend em .NET.

## Objetivo do Projeto

O principal objetivo do projeto foi praticar o desenvolvimento de APIs RESTful utilizando .NET e Entity Framework, implementando operações CRUD completas e integração com banco de dados.

Além disso, o desafio também teve como foco a utilização de boas práticas de desenvolvimento backend e documentação de endpoints.

## Tecnologias Utilizadas

* ASP.NET Core
* .NET
* Entity Framework Core
* C#
* SQL Server
* Swagger/OpenAPI
* REST API
* Git/GitHub

## Funcionalidades

### Gerenciamento de Tarefas

* Cadastro de tarefas
* Atualização de tarefas
* Remoção de tarefas
* Consulta de tarefas por ID
* Listagem de todas as tarefas

### Filtros de Consulta

* Busca por título
* Busca por data
* Busca por status

### Documentação da API

* Swagger/OpenAPI para visualização e testes de endpoints
* Estrutura RESTful para comunicação entre cliente e servidor

## Endpoints Implementados

* GET `/Tarefa/{id}`
* PUT `/Tarefa/{id}`
* DELETE `/Tarefa/{id}`
* GET `/Tarefa/ObterTodos`
* GET `/Tarefa/ObterPorTitulo`
* GET `/Tarefa/ObterPorData`
* GET `/Tarefa/ObterPorStatus`
* POST `/Tarefa`

## Banco de Dados

O projeto utiliza Entity Framework Core para persistência de dados, incluindo:

* Configuração de DbContext
* Criação de migrations
* Atualização automática da estrutura do banco
* Mapeamento da entidade Tarefa

## Estrutura da Entidade

A entidade principal do sistema contém:

* Id
* Título
* Descrição
* Data
* Status

## Conceitos Aplicados

* Desenvolvimento de APIs REST
* CRUD com Entity Framework Core
* Migrations
* Manipulação de banco de dados
* Arquitetura backend em .NET
* Documentação de APIs com Swagger
* Organização de controllers e models
* Persistência de dados

## Aprendizados

Durante o desenvolvimento do projeto foram aplicados conceitos relacionados a:

* Construção de APIs utilizando ASP.NET Core
* Integração com banco de dados utilizando Entity Framework
* Criação de endpoints RESTful
* Estruturação de projetos backend
* Manipulação de migrations
* Documentação e testes de APIs com Swagger



## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
