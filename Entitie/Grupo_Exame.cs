namespace LabClinic.Entitie
{
    public class Grupo_Exame
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Grupo_Exame()
        {

        }

        public Grupo_Exame(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
