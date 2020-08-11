using System;
using System.IO;
using TextFilter.Services;
using Microsoft.Extensions.Configuration;


namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {

            //IConfiguration config = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json", true, true)
            //    .Build();

            string fileName = string.Empty;

            if (args.Length > 0)
            {
                fileName = args[0];

                try
                {
                    FileService fileService = new FileService();

                    string output = fileService.ReadFile(fileName);

                    if (!String.IsNullOrEmpty(output))
                    {
                        Console.Write(output);
                    }
                    else
                    {
                        Console.WriteLine("File contents are empty");
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("No file parameters found....");
            }


        }
    }
}
