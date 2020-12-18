namespace dia_16.classes
{
    public class marca
    {
        public int ID {get; set;}
        public string Nome{get; set;}
        public float Preco{get; set;}
        public marca(){

        }
        public marca(int ID, string Nome, float Preco)
        {
            this.ID=ID;
            this.Nome=Nome;
            this.Preco=Preco;
        }

    }
}