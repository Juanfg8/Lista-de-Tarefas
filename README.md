# 💻 Projeto V2: Gerenciador de Tarefas em C#

## 🎯 Descrição do Projeto
Este repositório contém o projeto prático desenvolvido para o **Trabalho V2** da disciplina, focado na aplicação da linguagem **C#**. [cite_start]O objetivo é demonstrar o entendimento e a utilização dos principais recursos e paradigmas da linguagem[cite: 5, 4].

[cite_start]O projeto é um **Sistema de Gerenciamento Simples** implementado como uma aplicação de console interativa, que simula um **Gerenciador de Tarefas (To-Do List)**[cite: 4, 40]. [cite_start]O foco não é a criação de um sistema completo, mas sim uma aplicação que demonstre o entendimento e a utilização dos principais recursos e paradigmas da linguagem estudada[cite: 5].

## ✨ Recursos de C# Explorados

[cite_start]O projeto foi planejado para evidenciar o paradigma de **Orientação a Objetos (POO)** e as características centrais do C#[cite: 5, 18, 35].

| Conceito | Aplicação no Projeto |
| :--- | :--- |
| **Classes e Objetos** | Definição das classes `Tarefa` e `GerenciadorDeTarefas`. |
| **Encapsulamento** | Uso de propriedades (`get; set;`) para controlar o acesso aos atributos da classe `Tarefa` (ex: `Descricao`, `Concluida`). |
| **Tipagem Estática** | Uso explícito de tipos (ex: `string`, `bool`, `int`, `List<T>`). |
| **Coleções** | Utilização da classe genérica `List<Tarefa>` para armazenar e manipular a lista de tarefas. |
| **Estruturas de Controle** | Implementação de lógica de menu (`while` loop, `switch-case`) e iteração (`for` ou `foreach`). |
| **Tratamento de Exceções** | Uso de blocos `try-catch` para garantir a robustez ao tratar entradas inválidas do usuário. |

## 🚀 Como Executar o Projeto

Para rodar esta aplicação de console, você precisa ter o ambiente .NET configurado.

### Requisitos Mínimos

* [cite_start]**.NET SDK:** Versão 8.0 ou superior (Utilizado para compilar e executar o projeto)[cite: 21].
* **Editor/IDE:** VSCodium (ou Visual Studio Code).

### Instruções de Uso e Execução

1.  **Clone o repositório** para sua máquina local usando a URL correta:
    ```bash
    git clone [https://github.com/Juanfg8/Lista-de-Tarefas.git](https://github.com/Juanfg8/Lista-de-Tarefas.git)
    cd Lista-de-Tarefas
    ```

2.  **Execute a aplicação** a partir do terminal no diretório raiz do projeto:
    ```bash
    dotnet run
    ```

3.  O menu interativo será iniciado, e você poderá testar as funcionalidades (Adicionar, Listar, Marcar como Concluída).

## 📝 Estrutura do Código

A aplicação é dividida em três arquivos principais para organização orientada a objetos:

* **`Tarefa.cs`**: Define o objeto **Tarefa**.
* **`GerenciadorDeTarefas.cs`**: Contém a lógica de manipulação da coleção (`List<Tarefa>`).
* **`Program.cs`**: Contém o ponto de entrada da aplicação, o loop principal e o menu de interação.

---
**Desenvolvedor:** Juan Pedro Ferreira Gomes
[cite_start]**Instituição:** Centro Universitário Farias Britn [cite: 2]
[cite_start]**Data do Seminário:** 12/11 [cite: 7]
