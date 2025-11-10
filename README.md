# 💻 Projeto V2: Gerenciador de Tarefas em C#

## 🎯 Descrição do Projeto
Este repositório contém o projeto prático desenvolvido para o **Trabalho V2** da disciplina, focado na aplicação da linguagem **C#**. O objetivo é demonstrar o entendimento e a utilização dos principais recursos e paradigmas da linguagem.

O projeto é um **Sistema de Gerenciamento Simples** implementado como uma aplicação de console interativa, que simula um **Gerenciador de Tarefas (To-Do List)**. O foco principal é demonstrar o domínio dos conceitos de **Orientação a Objetos (POO)**.

## ✨ Recursos de C# Explorados

O projeto foi planejado para evidenciar o paradigma de **Orientação a Objetos (POO)** e as características centrais do C#.

| Conceito | Aplicação no Projeto |
| :--- | :--- |
| **Classes e Objetos** | Definição das classes `Tarefa` e `GerenciadorDeTarefas`. |
| **Encapsulamento** | Uso de propriedades (`get; set;`) para controlar o acesso aos atributos da classe `Tarefa` (ex: `Descricao`, `Concluida`). |
| **Tipagem Estática** | Uso explícito de tipos (ex: `string`, `bool`, `int`, `List<T>`). |
| **Coleções** | Utilização da classe genérica `List<Tarefa>` para armazenar e manipular a lista de tarefas. |
| **Estruturas de Controle** | Implementação de lógica de menu (`while` loop, `switch-case`) e iteração (`for` ou `foreach`). |
| **Tratamento de Exceções** | Uso de blocos `try-catch` para garantir a robustez ao tratar entradas inválidas do usuário. |

## 🚀 Como Executar o Projeto

Para rodar esta aplicação de console, você precisa ter o ambiente .NET SDK configurado.

### Requisitos Mínimos

* **.NET SDK:** Versão 8.0 ou superior (Necessário para compilar e executar o projeto).
* **Editor/IDE:** VSCodium (ou Visual Studio Code).

### Instruções de Uso e Execução

O código está estruturado para ser executado diretamente pelo CLI do .NET.

1.  **Clone o repositório** para sua máquina local usando o comando abaixo:
    ```bash
    git clone https://github.com/Juanfg8/Lista-de-Tarefas.git
    ```

2.  **Acesse o diretório** do projeto:
    ```bash
    cd Lista-de-Tarefas
    ```

3.  **Execute a aplicação** a partir do terminal no diretório raiz do projeto:
    ```bash
    dotnet run
    ```

4.  O menu interativo será iniciado, permitindo testar as funcionalidades (Adicionar, Listar, Marcar como Concluída).

## 📝 Estrutura do Código

A aplicação segue o padrão de POO, dividida em arquivos lógicos:

* **`Tarefa.cs`**: Define o objeto **Tarefa**.
* **`GerenciadorDeTarefas.cs`**: Contém a lógica de manipulação da coleção (`List<Tarefa>`).
* **`Program.cs`**: Contém o ponto de entrada da aplicação, o loop principal e o menu de interação.

---
**Desenvolvedor:** Juan Pedro Ferreira Gomes
**Instituição:** Centro Universitário Farias Britn
**Data do Seminário:** 12/11
