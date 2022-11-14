namespace ejerciciouno
{
    public class program
    {
        public static void Main ()
        {
            int numero, resultado, doblado;
            Console.WriteLine("por favor ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            doblado = numero * 2;
            resultado = doblado * 25;
            Console.WriteLine("el rsultado de la operacion es de " + resultado);
        }
    }
}