class Program {static void Main(){
        Console.Write("Ingrese el valor del lado del cuadrado: ");
        double lado = Convert.ToDouble(Console.ReadLine());
        double perimetro = lado * 4;
        Console.WriteLine("El perímetro del cuadrado es: " + perimetro);
        Console.ReadLine();
    }
}