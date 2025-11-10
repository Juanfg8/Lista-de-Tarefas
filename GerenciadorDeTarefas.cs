using System.Collections.Generic; // Necessário para List<T>
using System.Linq; // Necessário para métodos de LINQ (ex: Any)

namespace ToDoListApp
{
    // Classe que gerencia a lista de tarefas (Explorando Coleções)
    public class GerenciadorDeTarefas
    {
        // Coleção (List<T>) para armazenar os objetos Tarefa
        private List<Tarefa> _tarefas = new List<Tarefa>();

        // Método para adicionar uma nova tarefa
        public void AdicionarTarefa(string descricao)
        {
            Tarefa novaTarefa = new Tarefa(descricao);
            _tarefas.Add(novaTarefa);
            Console.WriteLine($"\n> Tarefa '{descricao}' adicionada com sucesso!");
        }

        // Método para listar todas as tarefas
        public void ListarTarefas()
        {
            if (!_tarefas.Any()) // Estrutura de Controle (if/else)
            {
                Console.WriteLine("\n> Nenhuma tarefa na lista.");
                return;
            }

            Console.WriteLine("\n--- Lista de Tarefas ---");
            for (int i = 0; i < _tarefas.Count; i++) // Estrutura de Controle (for loop)
            {
                // Uso do método ToString() da classe Tarefa
                Console.WriteLine($"{i + 1}. {_tarefas[i].ToString()}");
            }
            Console.WriteLine("------------------------");
        }

        // Método para marcar uma tarefa como concluída
        public void MarcarComoConcluida(int indice)
        {
            // Validação de índice (Tratamento de Exceção Lógica)
            if (indice > 0 && indice <= _tarefas.Count)
            {
                _tarefas[indice - 1].Concluida = true;
                Console.WriteLine($"\n> Tarefa {indice} marcada como concluída!");
            }
            else
            {
                Console.WriteLine("\n> Índice de tarefa inválido.");
            }
        }
    }
}