using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SysLog_Remote_Store_Application
{
    internal class Program
    {
        // States if a listener is active
        static string ActiveListener(bool active)
        {
            if (active)
            {
                return "Stop";
            }
            else
            {
                return "Start";
            }
        }
        static void Main(string[] args)
        {
            // MOD008904 010-1 SysLog Project Assignment
            // Zachariah Osborn

            // Pre-defined Variables and Loops
            bool programLoop = true;
            bool UDPActive = false;
            bool TCPActive = false;
            List<string> UDPListener = new List<string>();
            List<string> TCPListener = new List<string>();
            IPAddress address;

            // Program
            
            // Loops the program infinitely 
            while (programLoop)
            {
                // Error handling for incorrect inputs including anything outside the interger limit, incorrect format, Null inputs, and etc.
                try
                {
                    Console.Write($"==============================================" +
                        $"\n\tSYSLOG SERVER REMOTE STORE APP" +
                        $"\n==============================================" +
                        $"\nCurrent Target: {null}" +
                        $"\n----------------------------------------------" +
                        $"\n1. {ActiveListener(UDPActive)} UDP Listener" +
                        $"\n2. Display UDP Messages" +
                        $"\n3. {ActiveListener(TCPActive)} TCP Listener" +
                        $"\n4. Display TCP Messages" +
                        $"\n5. Toggle Real-Time Live Feed (UDP)" +
                        $"\n6. Toggle Real-Time Live Feed (TCP)" +
                        $"\n7. Configure IP / Port / Colours" +
                        $"\n8. Exit" +
                        $"\n==============================================" +
                        $"\nInput: ");
                    programLoop = false;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Overflow Error: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Format Error: {ex.Message}");
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine($"Null Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
