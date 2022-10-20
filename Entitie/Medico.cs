namespace LabClinic.Entitie
{
    public class Medico
    {
        public int Id   { get; set; }
        public Crm Crm { get; set; }
        public string Nome { get; set; }

        public Medico()
        {

        }

        public Medico(Crm crm, string nome)
        {
            Crm = crm;
            Nome = nome;
        }
    }
}
