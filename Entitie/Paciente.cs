namespace LabClinic.Entitie;



    public class Paciente : Contato
    {
        public int Id { get; set; }
        public int Codigo { get; private set; }
        
        public Endereco Endereco { get; set; }
       
        public DateTime DataNascimento { get; set; }



        public Paciente()
        {

        }
        public Paciente(string nome, string email, int telefone, int codigo, Endereco Endereco, DateTime DataNascimento) 
        : base(nome, email, telefone)
        
        {
            this.Codigo = codigo;
            this.Endereco = Endereco;
            this.DataNascimento = DataNascimento;


        }
        public string GetIdade()
        {
            return DateTime.Now.Year - DataNascimento.Year + " years old";
        }


    }
