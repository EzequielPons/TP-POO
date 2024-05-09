    class using System;
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                CreateHostBuilder(args).Build().Run();
            }
    
            public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    });

        Circulo circulo = new Circulo(15);
            Console.WriteLine(circulo.CalcularArea());

        Rectangulo rectangulo = new Rectangulo(7, 14);
            Console.WriteLine(rectangulo.CalcularArea());
        }
    }
       