using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShritoriG
{
    internal class Shritori 
    {
        public string[] words=new string[100];
        public bool game_over;
        public int count=0;

        public string[] Play(string word)
        {
            bool flag = false;
            for (int i = 0; i < count; i++)
            {
                if (word == words[i])
                {
                    Console.WriteLine("Invalid input.");
                    game_over = true;

                }
            }
            

            
            
                
                    if(count==0)
                {
                    words[0] = word; 
                }
                    else
                {

                string lengthi = words[count-1];
                for(int i = 0;i<lengthi.Length;i++)
                {
                    if (i + 1 == lengthi.Length)
                    {
                        if (word[0] == lengthi[i])
                        {
                            words[count] = word;
                            flag = true;
                            break;
                        }

                    }

                }
                if(!flag)
                    game_over= true;

            }

            count++;
                   
            
            
               
            
            return words;
        }
        public void restrat()
        {
           game_over=false;
            words= new string[100];
            count = 0;
        }
    }

}
