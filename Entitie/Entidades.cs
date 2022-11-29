namespace LabClinic.Entitie
{
    public class Entidades
    {
        public int Codigo { set; get; }
        public string Nome { set; get; }


        public Entidades (int nodigo, string nome)
        {
            Codigo = nodigo;
            Nome = nome;
        }
    }
    
}
