class Program{static void Main(){
        Console.Write("Ingrese el precio del artículo: ");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la cantidad comprada por el cliente: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        double total = precio * cantidad;
        Console.WriteLine("El total a pagar es: " + total);
        Console.ReadLine();
    }
}