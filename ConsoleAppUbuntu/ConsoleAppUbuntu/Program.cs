// See https://aka.ms/new-console-template for more information
using ConsoleAppUbuntu.Models;

Console.WriteLine("Hello, World!");
Console.WriteLine("");
ReadLogs();
Console.WriteLine("");
CreateLog("Ubuntu PostgreSQL");
Console.WriteLine("");
ReadLogs();

static void ReadLogs()
{
    var dbContext = new testdbContext();
    var logs = dbContext.Logs.ToList();
    foreach(var item in logs)
    {
        Console.WriteLine(item.Log1);
    }

}

static void CreateLog(string LogLine)
{
    var dbContext = new testdbContext();
    Log rec = new Log();
    rec.Log1 = LogLine;
    dbContext.Logs.Add(rec);
    dbContext.SaveChanges();
}