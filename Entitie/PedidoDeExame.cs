namespace LabClinic.Entitie
{
    public class PedidoDeExame
    {
        public int Codigo { get; private set; }
        public TipoDeRequisicao Tipo { get; private set; }
        public Medico Medico { get; private set; }
        public Paciente Paciente { get; private set; }

        public PedidoDeExame()
        {

        }
        public PedidoDeExame(int codigo, TipoDeRequisicao tipo, Medico medico, Paciente paciente)
        {
            Codigo = codigo;
            Tipo = tipo;
            Medico = medico;
            Paciente = paciente;
        }
    }
}
