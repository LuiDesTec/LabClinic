namespace LabClinic.Entitie
{
    public class CronogramaPedidoExame
    {
        public int Id { get; set; }
        public DateTime DataRealizacao { get; set; }
        public DateTime HorarioRealizacao { set; get; } 
        public DateTime DataResultado { get; set; }  
        public DateTime EntregaResultado { get; set; } = DateTime.Now;
       

        public CronogramaPedidoExame()
        {

        }
        public CronogramaPedidoExame(int id, DateTime dataRealizacao, DateTime horarioRealizacao, 
                                     DateTime dataResultado, DateTime entregaResultado)
        {
            Id = id;
            DataRealizacao = dataRealizacao;
            HorarioRealizacao = horarioRealizacao;
            DataResultado = dataResultado;
            EntregaResultado = entregaResultado;
        }
    }

  
}
