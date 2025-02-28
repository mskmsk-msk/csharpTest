using CsharpTest1;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

Console.WriteLine("Test Git clone");
var host = builder.Build();
host.Run();