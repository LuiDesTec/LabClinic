namespace LabClinic.Entitie
{
    public class TipoDeRequisicao
    {
        public int Id { get; set; }
        public string Sus { get; set; }
        public List<Convenio> Convenios { get; set; } = new List<Convenio>();
        public string Particular { get; set; }


        public TipoDeRequisicao()
        {


        }

       
         
    }
}
