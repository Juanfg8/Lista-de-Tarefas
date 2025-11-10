using System;
using System.Linq; // Adicione esta linha se não estiver lá

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // O namespace precisa ser ajustado se você colocou tudo em 'GerenciadorTarefasCsharp'
            // Se você usou o namespace 'ToDoListApp' nas outras classes, use-o aqui também.
            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();
            bool executando = true;

            Console.WriteLine("Bem-vindo ao Gerenciador de Tarefas em C# (Demonstração POO)");

            while (executando)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Listar Tarefas");
                Console.WriteLine("3. Marcar como Concluída");
                Console.WriteLine("4. Sair");
                Console.Write("Opção: ");

                string escolha = Console.ReadLine();

                try
                {
                    switch (escolha)
                    {
                        case "1":
                            Console.Write("Descrição da nova tarefa: ");
                            string descricao = Console.ReadLine();
                            gerenciador.AdicionarTarefa(descricao);
                            break;

                        case "2":
                            gerenciador.ListarTarefas();
                            break;

                        case "3":
                            gerenciador.ListarTarefas();
                            // Se precisar que a propriedade _tarefas seja acessível:
                            // ATENÇÃO: Se _tarefas é 'private', você terá que fazer um pequeno ajuste 
                            // na classe GerenciadorDeTarefas para criar um método público para verificar se há tarefas (ex: HasTasks())
                            // ou fazer a verificação 'if' dentro do método MarcarComoConcluida.
                            // Para simplicidade, vamos assumir que as outras classes foram restauradas.
                            
                            // *** Se você restaurou o código das classes, este bloco funcionará: ***
                            Console.Write("Digite o número da tarefa a ser concluída: ");
                            int indice = Convert.ToInt32(Console.ReadLine()); 
                            gerenciador.MarcarComoConcluida(indice);
                            
                            break;

                        case "4":
                            executando = false;
                            Console.WriteLine("Saindo do programa. Até mais!");
                            break;

                        default:
                            Console.WriteLine("\n> Opção inválida. Tente novamente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n[ERRO] Por favor, digite apenas o número da opção desejada.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[ERRO GERAL] Ocorreu um erro: {ex.Message}");
                }
            }
        }
    }
}