# Lista de Comandos Utilizados em Sala

## 1. Cria a Solução

```shell
dotnet new sln -n sol
```

## 2. Cria um projeto Console Application

```shell
dotnet new console -o console
```

## 3. Adiciona o Projeto Console à Solução

```shell
dotnet sln add console
```

## 4. Executa o projeto console

```shell
dotnet run --project console
```

## 5. Cria um projeto Class Library

(Este tipo de projeto gera como saída um arquivo .dll, escondendo a implementação desenvolvida)

```shell
dotnet new Classlib -o mylib
```

## 6. Adiciona o projeto à solução

```shell
dotnet sln add mylib
```

## 7. Adiciona a referência (ddl) do projeto Clas Library ao Projeto Console

(Deste modo, o projeto console poderá acessar as implementações do projeto class library)

```shell
dotnet add console reference mylib
```

## 8 Compila toda a Solução

```shell
dotnet build
```
