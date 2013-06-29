using ProgrammingChallenge_II;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace ProgrammingChallenge_II
{
    public class GameUpdater
    { 

        private TcpListener tcpListener;
        private Socket connection;
        private NetworkStream stm;
        private ASCIIEncoding ascii;
        private Communicator com;


        private Map map;

        private String initialString;
        private String startString;
        private String gameString;
        private String coinPileString;
        private String medipackString;
        private Thread stear;
                                   

        public GameUpdater(){
            ascii = new ASCIIEncoding();
            tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"),7000);
            tcpListener.Start();
            stear = new Thread(this.Stear);
                                   
        }

        public void update() {
            
            
            int s = 0;  // s=1 ensures that the initial message Recived
            // s=2 ensures that the start message Recived..
                  

            while (true)
            {
                connection = tcpListener.AcceptSocket();
                if (connection.Connected)
                {
                    stm = new NetworkStream(connection);
                    byte[] buffer = new byte[1000];
                    int k = stm.Read(buffer, 0, buffer.Length);
                    String message = ascii.GetString(buffer, 0, k);
                    char value = message.ToCharArray()[0];
                    switch (value) {

                        case 'I': this.initialString = message;
                                  s++; 
                                  break;

                        case 'S': this.startString = message;
                                  s++;
                                  if (s == 2) {
                                      map = new Map(initialString, startString);
                                  }
                                  break;

                        case 'G': this.gameString = message;
                                  map.MapUpdate(message);
                                  if (s == 2) {
                                      stear.Start();
            
                                      s++;
                                  }
                                  
                                  
                                  break;

                        case 'C': this.coinPileString = message;
                                  map.ItemUpdate(message);
                                  break;

                        case 'L': this.medipackString = message;
                                  map.ItemUpdate(message);
                                  break;

                        default: Console.WriteLine("Unknown Message....");
                                  break;   
                                                   
                    }
                 
                    Console.WriteLine(message);
        
                
                
                }
                else {
                    Console.WriteLine("Unable to reach the Server.. Check Your internet connection");
                    continue;
                }
                Thread.Sleep(500);           
            
            }
        
        }



        private void Stear() {

            while (true) {

                com = new Communicator();
                if (System.Console.ReadKey(true).Key == ConsoleKey.UpArrow) {

                    com.sendMessage_ToServer("UP#");
                    Console.WriteLine("Sending Message UP");
                }
                else if (System.Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                {
                    com.sendMessage_ToServer("DOWN#");
                    Console.WriteLine("Sending Message DOWN");
                }
                else if (System.Console.ReadKey(true).Key == ConsoleKey.LeftArrow) {
                    com.sendMessage_ToServer("LEFT#");
                    Console.WriteLine("Sending Message LEFT");
                }
                else if (System.Console.ReadKey(true).Key == ConsoleKey.RightArrow) {
                    com.sendMessage_ToServer("RIGHT#");
                    Console.WriteLine("Sending Message RIGHT");
                }
                else if (System.Console.ReadKey(true).Key == ConsoleKey.Spacebar) {
                    com.sendMessage_ToServer("SHOOT#");
                    Console.WriteLine("Sending Message SHOOT");
                
                }
            
            
            }
       
        }



       


        /*
        public void WriteMessage(String message) {

            try
            {

                if (connection.Connected)
                {

                    byte[] buffer = ascii.GetBytes(message);
                    Stream stm_write = new NetworkStream(connection);
                    stm_write.Write(buffer, 0, buffer.Length);

                }
                else {

                    Console.WriteLine("Game updater connection was lost...");

                }


            }
            catch (Exception e) {
                Console.WriteLine("Game Update message writing failed....");
                Console.WriteLine(e.StackTrace.ToString());
            }
        

        
        }
        */
     
    }
}
