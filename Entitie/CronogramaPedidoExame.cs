namespace LabClinic.Entitie
{
    public class CronogramaPedidoExame
    {
        public int Id { get; set; }
        public DateTime DataRealizacao { get; set; }
        public DateTime HorarioRealizacao { set; get; }
        public DateTime DataResultado { get; set; }
        public DateTime EntregaResultado { get; set; }
       

        public CronogramaPedidoExame()
        {

        }
    }

  
}
