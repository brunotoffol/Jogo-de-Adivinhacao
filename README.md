# Jogo de Adivinhação

## Introdução

Um jogo de adivinhação onde o jogador deve acertar um número aleatório entre 1 e 20 em um determinado número de tentativas.

### Exemplo

![](https://i.imgur.com/S9WePWG.gif)

### Funcionalidades

- Três níveis de dificuldade: Fácil (10 tentativas), Médio (5 tentativas) e díficil (3 tentativas).
- Geração de um número aleatório entre 1 e 20 a ser adivinhado pelo jogador.
- Jogador recebe uma dica caso erre o valor (maior ou menor que o número sorteado)

### Como utilizar:
1. Clone o repositório ou baixe o código fonte
2. Abre o terminal ou prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as depências do projeto

```
dotnet restore
```
4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```
5. Para Executar o projeto compilando em tempo real
```
dotnet run --project JogoAdivinhacao.ConsoleApp
```
6. Para executar o arquivo compilado, navegue até a pasta ./Calculadora.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:
```
JogoAdivinhacao.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
