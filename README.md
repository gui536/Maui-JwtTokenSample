# Projeto de Exemplo: Autenticação com JWT no .NET MAUI
## Objetivo do Projeto

Este projeto tem como objetivo demonstrar como implementar um sistema de autenticação utilizando JWT (JSON Web Token), integrando um backend ASP.NET Core com um aplicativo cliente desenvolvido em .NET MAUI.

A ideia principal é mostrar aos alunos como proteger APIs, gerenciar tokens de autenticação e consumi-los no cliente.

## Descrição do Projeto
### Frontend (MAUI)

    O cliente realiza o login enviando as credenciais do usuário para o backend.
    O token JWT recebido é armazenado no dispositivo usando o SecureStorage, garantindo segurança.
    Em requisições subsequentes, o token é enviado automaticamente no cabeçalho para consumir APIs protegidas.

## Por que usar JWT?

    Autenticação Stateless: O JWT elimina a necessidade de o servidor armazenar informações de sessão, melhorando a escalabilidade.
    Segurança: Os dados do token são assinados digitalmente, garantindo que ele não foi alterado.
    Flexibilidade: Pode ser usado em diferentes linguagens e plataformas, facilitando a integração entre sistemas.

## Fluxo de Autenticação

    O usuário envia suas credenciais para o backend via um endpoint /api/auth/login.
    O backend valida as credenciais e, se forem válidas, gera um token JWT.
    O cliente armazena o token de forma segura usando SecureStorage.
    Em requisições futuras, o cliente inclui o token no cabeçalho Authorization: Bearer {token}.
    O backend valida o token antes de responder à requisição.

## Tecnologias Utilizadas

### Frontend

    .NET MAUI
    HttpClient para consumo de APIs
    SecureStorage para armazenamento seguro do token

## Estrutura do Código

### Frontend (MAUI)

    Services
        JwtTokenHandler: Gerencia a inclusão automática do token em requisições.
    Armazenamento
        O token JWT é armazenado localmente usando SecureStorage.
