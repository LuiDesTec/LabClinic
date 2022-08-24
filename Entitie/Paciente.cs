namespace LabClinic.Entitie;

public class Class
{
    class Paciente
    {



        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }



        public Paciente()
        {

        }
        public Paciente(int codigo, string nome, Endereco endereco, string telefone, DateTime datanascimento)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.DataNascimento = datanascimento;



        }
        public string GetIdade()
        {
            return DateTime.Now.Year - DataNascimento.Year + " years old";
        }


    }
}