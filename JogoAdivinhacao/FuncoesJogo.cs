namespace JogoAdivinhacao
{
    public static class FuncoesJogo
    {
        public static int GeradorNumero()
        {
            Random geradorDeNumeros = new Random();
            int numeroSecreto = geradorDeNumeros.Next(1, 21);

            return numeroSecreto;
        }    
        
    }
}
