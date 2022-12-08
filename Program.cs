namespace DesafioDeCodigoDio
{
  class program
  {
    public static void Main(string[] args)
    {
      var numeroDigitado = "";
      var produto = 1;
      var soma = 0;
      var resultado = 0;
      Console.WriteLine("Informe 3 números: ");
      numeroDigitado = Console.ReadLine();
      foreach (var caracter in numeroDigitado.ToCharArray())
      {
        var numero = Convert.ToInt32(caracter.ToString());
        produto = produto * numero;
        soma = soma + numero;
      }
      resultado = produto - soma;
      // Console.WriteLine(soma);
      // Console.WriteLine(produto);
      Console.WriteLine(resultado);

    }
  }
}