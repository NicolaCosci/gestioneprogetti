using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcessi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione sulla gestione dei processi");

         
            Process.Start("notepad.exe",@"\\Users\studenti\source\repos\AppProcessi\AppProcessi\Hello_World.txt");
            Process.Start("Chrome.exe",@"https://www.google.com/search?q=ranocchia&rlz=1C1GCEU_itIT820IT820&source=lnms&tbm=isch&sa=X&ved=0ahUKEwi5ntaYxPrkAhWEGewKHQJOA3YQ_AUIEygC&biw=1920&bih=937#imgrc=TSq4dXyaccj5DM");
            var app = new Process();
            app.StartInfo.FileName = @"Notepad.exe";
            app.StartInfo.Arguments = @"\\Users\studenti\source\repos\AppProcessi\AppProcessi\Hello_World.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            //app.WaitForExit();
             

           
            var proceses = Process.GetProcesses(); 
            foreach(var P in proceses)  
            {
                if(P.ProcessName=="Notepad") 
                { 
                    P.Kill();
                }
            }
            Console.WriteLine("programma terminato");
            Console.ReadLine();



        }
    }
}
