class Program{static void Main(){
        Console.Write("Ingrese el sueldo del empleado: ");
        double sueldo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese los años de antigüedad: ");
        int antiguedad = Convert.ToInt32(Console.ReadLine());

        if (sueldo < 500 && antiguedad >= 10){
            sueldo = sueldo * 1.2;
            Console.WriteLine("Sueldo aumentado un 20%: " + sueldo);
        }
        else if (sueldo < 500 && antiguedad < 10){
            sueldo = sueldo * 1.05;
            Console.WriteLine("Sueldo aumentado 5%: " + sueldo);
        }
        else{
            Console.WriteLine("Sueldo sin aumento: " + sueldo);
        }
        Console.ReadLine();
    }   
}