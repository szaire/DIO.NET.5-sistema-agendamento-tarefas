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
| Verbo  | Endpoint                | Parâmetro | Implementado? |
|--------|-------------------------|-----------|---------------|
| GET    | /Tarefa/{id}            | id        |      [⏳]     |
| PUT    | /Tarefa/{id}            | id        |      [⏳]     |
| DELETE | /Tarefa/{id}            | id        |      [⏳]     |
| GET    | /Tarefa/ObterTodos      | N/A       |      [✅]     |
| GET    | /Tarefa/ObterPorTitulo  | titulo    |      [⛔]     |
| GET    | /Tarefa/ObterPorData    | data      |      [⛔]     |
| GET    | /Tarefa/ObterPorStatus  | status    |      [⛔]     |
| POST   | /Tarefa                 | N/A       |      [⏳]     |
