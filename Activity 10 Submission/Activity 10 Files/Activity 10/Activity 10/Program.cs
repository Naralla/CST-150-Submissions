//Corrected by Dalton Danz
//CST-150
//May 22, 2022
//This is my own work

//use for IC08
//Lydia's code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CST117_IC08_console
{    class Program    
    {        
        static void Main( string[] args )        
        {            
            //make some sets
            Set A = new Set( );            
            Set B = new Set( );

            //put some stuff in the sets
            Random r = new Random(); 
            for (int i = 0; i < 10; i++) 
            { 
                A.addElement(r.Next(4)); 
                B.addElement(r.Next(12)); 
            }
            
            //display each set and the union
            Console.WriteLine("A: " + A);            
            Console.WriteLine("B: " + B);            
            Console.WriteLine("A union B: " + A.union(B));       

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");            
            Console.WriteLine("A: " + A);            
            Console.WriteLine("B: " + B);                   
        }    
    }
}

//Lydia's code - find the errors!
namespace CST117_IC08_console
{    
    class Set    
    {        
       
        private List<int> elements;  
        

        public Set( )        
        {            
            elements = new List<int>();                    
        }        

        public bool addElement(int val )        
        {
            if (containsElement(val)) 
               return false; 
            else 
            { 
                elements.Add(val); 
                return true; 
            }
        }


        private bool containsElement(int val) 
        {            
            for (int i = 0; i < elements.Count; i++)
            { 
                if (val == elements[i]) 
                    
                    return true;
                //else                  These lines would return false if the first number did not match.   
                    //return false;     Removing them allows the function to check all numbers 
            }                        // in the list to locate a possible match.
            return false;
        }

        public override string ToString() 
        { 
            string str = ""; 
            foreach (int i in elements) 
            { 
                str += i + " "; 
            } 
            return str; 
        }

        public void clearSet() 
        { 
            elements.Clear(); 
        }


        public Set union(Set rhs) 
        {
            Set unionSet = new Set();                    //create new temporary set to hold values. This allows original set to be
                                                         //unaltered for second console listing.           
            for(int x = 0; x < this.elements.Count; x++) //add elements from set A to temporary set.
            {
                unionSet.addElement(this.elements[x]);
            }
            for (int i = 0; i < rhs.elements.Count; i++) //add elements from set B to temporary set.
            { 
                unionSet.addElement(rhs.elements[i]); 
            }

            /*
            for (int i = 0; i < rhs.elements.Count; i++)    These lines would cause Set A to be altered to include
            {                                               the union for Set B. However only Set B would be
                this.addElement(rhs.elements[i]);           returned.
            }
            //return rhs;   */

            return unionSet;    //this causes the return to be the updated set
        }
    }
}