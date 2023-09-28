  namespace RaizCuadrada
{
    
        
   public class RaizCuadrada
{
  public static double Calcular(double numero)
  {
    if (numero == 0)
    {
      return 0;
    }

    double aprox = numero / 2;
    while (true)
    {
      double cuadrado = aprox * aprox;
      double error = numero - cuadrado;
      if (error < 0.000001)
      {
        return aprox;
      }
      aprox = (aprox + error / aprox) / 2;
    }
  }
}
        }
    }
}