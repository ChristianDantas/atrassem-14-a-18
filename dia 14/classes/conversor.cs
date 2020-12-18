namespace dia_14.classes
{
    public static class conversor
    {
        private static float cotacaoEuro=6.22f;
        private static float cotacaoDolar=5.07f;
        public static float valorUsuario;

    public static float ConverterDolarParaReal(){
        return cotacaoDolar * valorUsuario;
    }
        public static float ConverterRealParaDolar(){
            return  valorUsuario / cotacaoDolar;
        }
         public static float ConverterEuroParaReal(){
             return cotacaoEuro * valorUsuario;
         }
         public static float ConverterRealParaEuro(){
            return  valorUsuario / cotacaoEuro;
        }
    }
}