namespace LabClinic.Entitie
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
       
      
        public Contato()
        {

        }
      
        public Contato(string nome, string email, int telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }

   
}
