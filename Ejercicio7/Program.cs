class Program{static void Main(){
        Console.Write("Ingrese la cantidad de numeros a ingresar: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        int pares = 0, impares = 0;

        for (int i = 0; i < cantidad; i++){
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine("La cantidad de números pares es de: " + pares);
        Console.WriteLine("La cantidad de números impares es de: " + impares);
        Console.ReadLine();
    }
}