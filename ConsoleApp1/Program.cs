internal class Program
{
    private static void Main(string[] args)
    {

        //metodo de extension
        List<int> listaNum = new();

        for (int i = 1; i <= 100; i++)
        {
            listaNum.Add(i);
            
        }

        List<int> listadef = listaNum.Where(i => i % 7 == 0).ToList();

        //List<int> listadef = listaNum.Where(i => i % 2 == 0).ToList();

        foreach (int num in listadef)
        {
                Console.Write(" " +num+ " ");
        }

        var query = from num in listaNum where (num % 7 == 0) select num;

        //var query = from num in listaNum where (num % 2 == 0) select num;

        //foreach (int num in query)
        //{
        //    Console.Write(" " +num+ " ");
        //}



    }
}

