namespace ToDoListApp
{
    // Classe que representa o objeto Tarefa (Explorando POO e Encapsulamento)
    public class Tarefa
    {
        // Propriedades com get/set para Encapsulamento
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        // Construtor
        public Tarefa(string descricao)
        {
            this.Descricao = descricao;
            this.Concluida = false;
        }

        // Método para exibir o status da tarefa
        public override string ToString()
        {
            string status = Concluida ? "[X]" : "[ ]";
            return $"{status} {Descricao}";
        }
    }
}