using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Winsh
{
    class Winsh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t    TERMINAL READY.");
            Console.WriteLine("\t\t ds168 V 1.0 - The C# terminal application.");
            Console.WriteLine("\t\t Type \"help\" for available commands. ");
            Console.WriteLine("--------------------------------------------------------------------------------");

            while (true)
            {
                
                
                Console.Write(Environment.UserName + "@" + Environment.CurrentDirectory + "\\winsh>");
                String inputString=Console.ReadLine();
                String[] str = inputString.Split(' ');
                if(str.Length==1&&str[0].Equals("help")) 
                { 
                  Console.WriteLine("\nCurrently implemented UNIX-commands (see \"man\" for implemented options)");
                  Console.WriteLine("\t man - an interface to the on-line reference manuals");
                  Console.WriteLine("\t ls  - list directory contents ");
                  Console.WriteLine("\t cp - copy files");
                  Console.WriteLine("\t more - file perusal filter for crt viewing");
                  Console.WriteLine("\t grep - print lines matching a pattern");
                  Console.WriteLine("\t cd - Changes the current directory");
                  Console.WriteLine("\t ps - Displays all running processes.");
                  Console.WriteLine("\t date - Displays system current date and time.");
                  Console.WriteLine("\t mv - move files");
                  Console.WriteLine("\t ping - send ICMP ECHO_REQUEST to network hosts");
                  
                  Console.WriteLine();                       
                }
                else if (str.Length == 2 && str[0].Equals("man") && str[1].Equals("man"))
                {
                    Console.WriteLine("\nNAME");
                    Console.WriteLine("\t man - an interface to the on-line reference manuals");
                    Console.WriteLine("\nSYNOPSIS");
                    Console.WriteLine("\t man [COMMAND]...");
                    Console.WriteLine("\nDESCRIPTION");
                    Console.WriteLine("\t man is the system's manual pager.");
                    Console.WriteLine();
                }
                else if (str.Length == 2 && str[0].Equals("man") && str[1].Equals("ls"))
                {
                    Console.WriteLine("\nNAME");
                    Console.WriteLine("\t ls - list directory contents");
                    Console.WriteLine("\nSYNOPSIS");
                    Console.WriteLine("\t ls [FILE]...");
                    Console.WriteLine("\nDESCRIPTION");
                    Console.WriteLine("\t List  information  about  the FILEs (the current directory by default).");
                    Console.WriteLine();
                }
                else if (str.Length == 2 && str[0].Equals("man") && str[1].Equals("more"))
                {
                    Console.WriteLine("\nNAME");
                    Console.WriteLine("\t more - file perusal filter for crt viewing");
                    Console.WriteLine("\nSYNOPSIS");
                    Console.WriteLine("\t more [FILE]...");
                    Console.WriteLine("\nDESCRIPTION");
                    Console.WriteLine("\t  more is a filter for paging through text one screenful at a time.");
                    Console.WriteLine();
                }
                else if (str.Length == 2 && str[0].Equals("man") && str[1].Equals("cp"))
                {
                    Console.WriteLine("\nNAME");
                    Console.WriteLine("\t cp - copy files");
                    Console.WriteLine("\nSYNOPSIS");
                    Console.WriteLine("\t cp [SOURCE...] [DIRECTORY...]");
                    Console.WriteLine("\nDESCRIPTION");
                    Console.WriteLine("\t Copy SOURCE to DEST");
                    Console.WriteLine();
                }
                else if (str.Length == 2 && str[0].Equals("man") && str[1].Equals("grep"))
                {
                    Console.WriteLine("\nNAME");
                    Console.WriteLine("\t grep - print lines matching a pattern");
                    Console.WriteLine("\nSYNOPSIS");
                    Console.WriteLine("\t  grep PATTERN [FILE...]");
                    Console.WriteLine("\nDESCRIPTION");
                    Console.WriteLine("\t grep searches the named input FILEs for lines containing a match to the given PATTERN.");
                    Console.WriteLine();
                }
                else if (str.Length == 2 && str[0].Equals("man") && str[1].Equals("cd"))
                {
                    Console.WriteLine("\nNAME");
                    Console.WriteLine("\t cd - Changes the current directory");
                    Console.WriteLine("\nSYNOPSIS");
                    Console.WriteLine("\t  cd  [DEST...] ..");
                    Console.WriteLine("\nDESCRIPTION");
                    Console.WriteLine("\t cd DEST changes the current directory the Destination directory.");
                    Console.WriteLine("\t cd .. changes the current directory to the parent directory.");
                    Console.WriteLine();
                }
                else if (str.Length == 2 && str[0].Equals("man") && str[1].Equals("ps"))
                {
                    Console.WriteLine("\nNAME");
                    Console.WriteLine("\t ps - Displays all running processes.");
                    Console.WriteLine("\nSYNOPSIS");
                    Console.WriteLine("\t  ps");
                    Console.WriteLine("\nDESCRIPTION");
                    Console.WriteLine("\t program  provides  a  dynamic real-time view of a running system.");
                    Console.WriteLine();
                }
                else if (str.Length == 2 && str[0].Equals("man") && str[1].Equals("date"))
                {
                    Console.WriteLine("\nNAME");
                    Console.WriteLine("\t date - Displays system current date and time.");
                    Console.WriteLine("\nSYNOPSIS");
                    Console.WriteLine("\t  ps");
                    Console.WriteLine("\nDESCRIPTION");
                    Console.WriteLine("\t Prints system date and time");
                    Console.WriteLine();
                }
                else if (str.Length == 2 && str[0].Equals("man") && str[1].Equals("ping"))
                {
                    Console.WriteLine("\nNAME");
                    Console.WriteLine("\t ping - send ICMP ECHO_REQUEST to network hosts");
                    Console.WriteLine("\nSYNOPSIS");
                    Console.WriteLine("\t  ping [URL]");
                    Console.WriteLine("\nDESCRIPTION");
                    Console.WriteLine("\t Allows an application to determine whether a remote computer is accessible over the network.");
                    Console.WriteLine("\nEXAMPLE");
                    Console.WriteLine("\t ping http:\\www.google.com");
                    Console.WriteLine();
                }
                else if (str.Length == 2 && str[0].Equals("man") && str[1].Equals("mv"))
                {
                    Console.WriteLine("\nNAME");
                    Console.WriteLine("\t  mv - move files");
                    Console.WriteLine("\nSYNOPSIS");
                    Console.WriteLine("\t mv [SOURCE...] [DIRECTORY...]");
                    Console.WriteLine("\nDESCRIPTION");
                    Console.WriteLine("\t Move SOURCE(s) to DIRECTORY.");
                    Console.WriteLine();
                }
                else if (str.Length==1 && str[0].Equals("ls"))
                {

                    string[] dirs = Directory.GetFiles(Environment.CurrentDirectory, "*");
                    Console.WriteLine("The number of files in current directory is {0}.", dirs.Length);
                    foreach (string dir in dirs)
                    {
                        Console.WriteLine("\t"+dir);
                    }
                    Console.WriteLine();
                }

                else if (str.Length == 2 && str[0].Equals("cd"))
                {
                    if (str[1] == "..") {


                        try
                        {
                            String prevDir = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
                            Directory.SetCurrentDirectory(prevDir);
                        }
                        catch {
                            Console.WriteLine(" ");//At root Directory
                        }

                    }
                    else if (Directory.Exists(str[1]) == false)
                    {
                        Console.WriteLine(str[1]+": No Such file or Directory");
                    }
                    else
                    {
                        String strin = str[1];
                        Directory.SetCurrentDirectory(strin);

                    }
                    Console.WriteLine();
                }
                else if (str.Length == 2 && str[0].Equals("more"))
                {
                     if (File.Exists(str[1]) == false)
                    {
                        Console.WriteLine(str[1] + ": No Such file exists");
                    }
                    else
                    {
                        string fullPath = Path.GetFullPath(str[1]);
                        int counter = 0;
                        string line;

                        // Read the file and display it line by line.
                        System.IO.StreamReader file =
                            new System.IO.StreamReader(fullPath);
                        Console.WriteLine("<Press Enter to read more lines>");
                        while ((file.Peek()) != -1)
                        {
                            Console.ReadKey();
                            counter = 0;
                            while (counter != 5)
                            {
                                line = file.ReadLine();
                                System.Console.WriteLine(line);
                                counter++;
                            }
                        }

                        file.Close();

                    }
                    Console.WriteLine();
                }
                else if (str.Length == 3 && str[0].Equals("cp"))
                {
                    
                    if (File.Exists(str[1]) == false)
                    {
                        Console.WriteLine( "Source file: "+str[1] +" not found");
                    }

                    else if (File.Exists(str[2]) == false)
                    {
                        Console.WriteLine("Target file: " + str[2] + " not found");
                     }
                     else
                     {
                         

                         File.Copy(Path.GetFullPath(str[1]), Path.GetFullPath(str[2]),true);
                     }
                       Console.WriteLine();
                }
                else if (str.Length == 3 && str[0].Equals("grep"))
                {
                    if (File.Exists(str[2])&&Directory.Exists(str[2]) == false)
                    {
                        Console.WriteLine(str[1] + ": No Such file or Directory exists");
                    }
                    else
                    {
                        foreach (String d in Directory.GetDirectories(Directory.GetCurrentDirectory()))
                        {
                            Console.WriteLine("Directory: "+d);
                            foreach(String f in Directory.GetFiles(d)){
                            Console.WriteLine("\t File: " + f);
                            string[] lines = File.ReadAllLines(f);

                            foreach (string line in lines)
                            {
                                if (line.Contains(str[1]))
                                {
                                    Console.WriteLine(line);
                                }
                            }
                            }
                        }
                    }
                    Console.WriteLine();

                }
                else if (str.Length== 1 && str[0].Equals("ps"))
                {

                   Process[] processlist = Process.GetProcesses();

                    foreach(Process theprocess in processlist){
                    Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
                    }
                    Console.WriteLine();
                }
                else if (str.Length == 1 && str[0].Equals("date"))
                {
                    
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine();
                  

                }
                else if (str.Length == 2 && str[0].Equals("ping"))
                {

                    Uri url = new Uri(str[1]);
                    string pingurl = string.Format("{0}", url.Host);
                    Ping ping = new Ping();
                    PingReply pingresult = ping.Send(pingurl,3000);

                    if (pingresult.Status.ToString() == "Success")
                    {
                        Console.WriteLine("Connection Success");
                    }
                    else {
                        Console.WriteLine("Connection Failed");
                    }
                    
                    Console.WriteLine();
                }
                else if (str.Length == 3 && str[0].Equals("mv"))
                {
                    if (File.Exists(str[1]) == false)
                    {
                        Console.WriteLine("Source file not found");
                    }
                    else if (Directory.Exists(str[2]) == false)
                    {
                        Console.WriteLine("Target Directory not found");
                    }
                    else
                    {
                        File.Move(str[1], str[2] + "\\" + str[1]);
                    }
                    

                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("Command '" + inputString + "' not recognized.");
                    Console.WriteLine();
                    
                }
                   


            }
        }
    }
}
