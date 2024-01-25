class Triangulo_Pascal
{
    static void Main(string[] args)
    {
        int pisos = 0;
        int[] arreglo = new int[1];
        //mostramos un mensaje y capturamos el dato ingresado desde la consola
        Console.WriteLine("Ingrese el numero de pisos");
        pisos = Convert.ToInt16(Console.ReadLine());
        //declaramos ciclo for 
        for (int i = 1; i <= pisos; i++)
        {


            int[] pascal = new int[i];
            //ciclo for para que se decremente para formar el triangulo
            for (int j = pisos; j < i; j--)
            {
                Console.Write(" ");
            }
            //ciclo for para generar las sumas de las cifras
            for (int k = 0; k < i; k++)
            {
                //condicion que evalua la variable del ciclo for
                if (k == 0 || k == (i - 1))
                {
                    pascal[k] = 1;
                }
                else {
                    //sumamos los numeros que estan en cada posicion
                    // del arreglo para formar el triangulo
                    pascal[k] = arreglo[k] + arreglo[k - 1];
                }
                Console.Write("[" + pascal[k] + "]");
            }
            arreglo = pascal;
            Console.WriteLine(" ");
        }

        Console.ReadLine();
    }
}