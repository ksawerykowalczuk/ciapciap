class Ciapuncio
{
    public void zrobKupe()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("zaczynam robienie kupy.");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("zaczynam robienie kupy..");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("zaczynam robienie kupy...");
            System.Threading.Thread.Sleep(200);
        }
        System.Threading.Thread.Sleep(2000);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(" robienie kupy.");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine(" robienie kupy..");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine(" robienie kupy...");
            System.Threading.Thread.Sleep(200);
        }
        Console.WriteLine(" *CIAP* ");
        System.Threading.Thread.Sleep(2000);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("kończę robienie kupy.");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("kończę robienie kupy..");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("kończę robienie kupy...");
            System.Threading.Thread.Sleep(200);
        }
    }
}