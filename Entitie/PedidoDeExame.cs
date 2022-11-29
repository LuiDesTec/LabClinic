using LabClinic.Entitie.Enums;

namespace LabClinic.Entitie
{   

    public class PedidoDeExame : IIprimir
    {
        public int Id { get; set; }
        public int Codigo { get; private set; }
        public TipoDeRequisicao Tipo { get; private set; }
        public Medico Medico { get; private set; }
        public Paciente Paciente { get; private set; }
        public double ValorExame { get; set; }
        public StatusPedidoExame status { get; set; }
        
        public PedidoDeExame()
        {

        }
        public PedidoDeExame(int id, int codigo, TipoDeRequisicao tipo, Medico medico, 
                             Paciente paciente, double valorExame)
        {
            Id = id;
            Codigo = codigo;
            Tipo = tipo;
            Medico = medico;
            Paciente = paciente;
            ValorExame = valorExame;
        }
        public void SetCadastrar()
        {
            throw new NotImplementedException();
        }
        public void GetImprimir()
        {


        }
    }
}
