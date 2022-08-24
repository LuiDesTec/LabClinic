namespace LabClinic.Entitie
{
    public class Medico
    {
        public CRM CRM { get; set; }
        public string Nome { get; set; }

        public Medico(CRM crm, string nome)
        {
            CRM = crm;
            Nome = nome;
        }
    }
}
