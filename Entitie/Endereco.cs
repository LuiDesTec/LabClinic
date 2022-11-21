namespace LabClinic.Entitie
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public Cidade Cidade { get; set; }
        public Uf Estado { get; set; }

        public Endereco()
        {
        }
        public Endereco(string rua, string numero, string bairro)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;

        }

    }
}
