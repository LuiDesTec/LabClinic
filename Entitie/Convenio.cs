namespace LabClinic.Entitie
{
    public class Convenio : Entidades
    {
        public int Id { get; set; }
       

        public Convenio(int codigo, string nome, int id) : base(codigo, nome)
        {
               Id = id;
        }
    }
}
