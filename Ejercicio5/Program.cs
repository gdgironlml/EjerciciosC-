class Program{static void Main(){
        Console.Write("Ingrese coordenada de X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese coordenada de Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
            Console.WriteLine("El punto está en el primer cuadrante.");
        else if (x < 0 && y > 0)
            Console.WriteLine("El punto está en el segundo cuadrante.");
        else if (x < 0 && y < 0)
            Console.WriteLine("El punto está en el tercer cuadrante.");
        else if (x > 0 && y < 0)
            Console.WriteLine("El punto está en el cuarto cuadrante.");
        Console.ReadLine();
    }
}