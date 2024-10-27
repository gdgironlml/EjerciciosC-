class Program{static void Main(){
        Console.Write("Ingrese un número entero positivo (máximo 3 dígitos):");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0 && numero < 10)
            Console.WriteLine("El número tiene 1 dígito");
        else if (numero >= 10 && numero < 100)
            Console.WriteLine("El número tiene 2 dígitos");
        else if (numero >= 100 && numero < 1000)
            Console.WriteLine("El número tiene 3 dígitos");
        else if (numero < 0)
            Console.WriteLine("Error. El número es menor a 0");
        else
            Console.WriteLine("Error. El número tiene más de 3 dígitos");
        Console.ReadLine();
    }
}