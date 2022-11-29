namespace LabClinic.Entitie
{
    public class Cidade : Entidades
    {
        public int Id { get; set; }
        public int DDD { get; set; }

        public Cidade(int id, int ddd, int codigo, string nome) : base (codigo, nome)
        {
            Id = id;
            DDD = ddd;
        }
    }
}
