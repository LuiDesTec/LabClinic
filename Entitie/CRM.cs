namespace LabClinic.Entitie
{
    public class Crm
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public Uf Uf { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }

        public Crm()
        {

        }
    }
}
