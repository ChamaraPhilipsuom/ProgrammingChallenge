using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingChallenge_II;
using System.Collections;

namespace ProgrammingChallenge_II
{
    public class Player_Solution
    {
        /*
        private char[,] map;    // In here Game map Brick Wall :B
                                // Water Cell: W
                                // Stone Cells: S

        private int maxNumberOfPlayers;
        private Coordinate[] players;
        private ArrayList coinPiles;
        private ArrayList lifePacks;

        public Player_Solution(int numPlayers) { 

            this.maxNumberOfPlayers=numPlayers;
            players = new Coordinate[maxNumberOfPlayers];
            coinPiles = new ArrayList();
            lifePacks = new ArrayList();


        }

        public void initializeMap(String initilizeMessage) {

            map = new char[20, 20];
            String[] str = initilizeMessage.Split(':');
            String[] temp;
            String[] coordinates;
            if (str[0].Equals("I")) {

                for (int i = 1; i <= maxNumberOfPlayers; i++) {
                    players[i] = new Coordinate();
                    temp = str[i].Split(',');
                    players[i].setCoordinates(Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]));
                    players[i].setDirection(Convert.ToInt32(temp[2]));
                }

              
                    temp = str[maxNumberOfPlayers+1].Split(';');
                    for (int j = 0; j < temp.Length; j++) {
                        coordinates = temp[j].Split(',');
                        map[Convert.ToInt32(coordinates[0]), Convert.ToInt32(coordinates[1])] = 'B';

                    }

                    temp = str[maxNumberOfPlayers + 2].Split(';');
                    for (int j = 0; j < temp.Length; j++)
                    {
                        coordinates = temp[j].Split(',');
                        map[Convert.ToInt32(coordinates[0]), Convert.ToInt32(coordinates[1])] = 'S';

                    }


                    temp = str[maxNumberOfPlayers + 3].Split(';');
                    for (int j = 0; j < temp.Length; j++)
                    {
                        coordinates = temp[j].Split(',');
                        map[Convert.ToInt32(coordinates[0]), Convert.ToInt32(coordinates[1])] = 'W';

                    }



                    Console.WriteLine("Map Initilization Successfull...  :)");

            }

        }


        public void CalculateShortestPath(Coordinate start, Coordinate end) {

            int s_x, s_y, e_x, e_y;
            s_x = start.getXCoordinate();
            s_y = start.getYCoordinate();
            e_x = start.getXCoordinate();
            e_y = start.getYCoordinate();




        
        
        }

        public void IsInMyTerrortory(int player_index) { 
        
        }


        public void UpdateMap(String UpdateString) { 
         
        }


        */
    }
          
       
}
