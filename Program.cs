using System;
class Programs {
  static void Main() 
  {
      Console.WriteLine("Introduce el límite inferior: ");
      int LimiteInferior = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Introduce el límite superior: ");
      int LimiteSuperior = Convert.ToInt32(Console.ReadLine());
      
      Random random = new Random();
      int numeroAleatorio = random.Next(LimiteInferior, LimiteSuperior + 1);
      
      Console.WriteLine("adivina el numero entre " + LimiteInferior + " y " + LimiteSuperior);
      
      int Sup;
      bool Acer = false;
      
      while (!Acer) {
          Console.WriteLine("Introduce Supucicion: ");
          Sup = Convert.ToInt32(Console.ReadLine());
          
          if (Sup == numeroAleatorio) {
              Console.WriteLine("¡Felicidades! Adivinaste el número.");
              Acer = true;
          }
          
          else if (Sup < numeroAleatorio){
              Console.WriteLine("El número es mayor que " + Sup);
          }
          
          else {
              Console.WriteLine("El número es menor que " + Sup);
          }
    
      }
  }
}

