using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Configurazione del container di servizi
        var serviceProvider = ConfigureServices();

        // Risolvi il servizio principale
        var app = serviceProvider.GetService<App>();

        // Esegui l'applicazione
        app.Run();
    }

    private static ServiceProvider ConfigureServices()
    {
        // Configura i servizi
        var services = new ServiceCollection();

        // Registra i servizi
        services.AddTransient<IExampleService, ExampleService>(); // Un servizio dipendente
        services.AddSingleton<App>(); // L'app principale

        // Costruisci il provider
        return services.BuildServiceProvider();
    }
}

// Classe principale dell'applicazione
public class App
{
    private readonly IExampleService _exampleService;

    public App(IExampleService exampleService)
    {
        _exampleService = exampleService;
    }

    public void Run()
    {
        Console.WriteLine("Applicazione avviata!");
        _exampleService.Execute();
    }
}

// Interfaccia per il servizio di esempio
public interface IExampleService
{
    void Execute();
}

// Implementazione del servizio di esempio
public class ExampleService : IExampleService
{
    public void Execute()
    {
        Console.WriteLine("Esecuzione del servizio di esempio.");
    }
}
