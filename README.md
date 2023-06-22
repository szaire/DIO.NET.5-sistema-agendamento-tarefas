# DIO.NET.5-sistema-agendamento-tarefas
Repositório feito para manter o projeto final do Módulo 5 do curso .NET Developer ofertado pela DIO

# Ferramentas utilizadas
- ASP.NET MVC (Alternativo a Web API)
- SQL Server (Docker)
- DBeaver (Visualização do Banco de Dados)
- EntityFramework

# Observações
Como desenvolvo em plataformas Linux, minha Connection String estará um pouco diferente da que foi mostrada no curso, pois este deu seguimento em um ambiente Windows, o qual já possui certificação para validar o acesso ao host local. Sistemas Operacionais baseados em Linux não o possuem, logo, é necessário autenticar utilizando o login e senha do Banco de Dados

# Lista de Funcionalidades:
| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| GET    | /Tarefa/{id}            | id        | N/A           |
| PUT    | /Tarefa/{id}            | id        | Schema Tarefa |
| DELETE | /Tarefa/{id}            | id        | N/A           |
| GET    | /Tarefa/ObterTodos      | N/A       | N/A           |
| GET    | /Tarefa/ObterPorTitulo  | titulo    | N/A           |
| GET    | /Tarefa/ObterPorData    | data      | N/A           |
| GET    | /Tarefa/ObterPorStatus  | status    | N/A           |
| POST   | /Tarefa                 | N/A       | Schema Tarefa |
