namespace LabClinic.Entitie
{
    public class Grupo_Exame : Entidades
    {
        public int Id { get; set; }
      

        public Grupo_Exame( int codigo, string nome, int id)  : base (codigo, nome) 
        { 
            Id = id;
        }
    }
}
