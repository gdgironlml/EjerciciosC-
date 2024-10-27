class Program{static void Main(){
        Console.Write("Ingrese la cantidad de preguntas: ");
        double totalPreguntas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la cantidad de respuestas correctas: ");
        double correctas = Convert.ToInt32(Console.ReadLine());
        double porcentaje = correctas / totalPreguntas * 100;

        if (porcentaje >= 90)
            Console.WriteLine("Nivel máximo");
        else if (porcentaje >= 75)
            Console.WriteLine("Nivel medio");
        else if (porcentaje >= 50)
            Console.WriteLine("Nivel regular");
        else
            Console.WriteLine("Fuera de nivel");
        Console.ReadLine();
    }
}