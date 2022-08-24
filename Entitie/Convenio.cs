namespace LabClinic.Entitie
{
    public class Convenio
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }

        public Convenio()
        {

        }
        public void SetNome(string nome)
        {

            Nome = nome;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }

    }
}
