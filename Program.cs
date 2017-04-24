
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GitHub
{
  class Program
    {
      public static void Main(string[] args)
        {
            Console.WriteLine("Enter height Of the Wall:");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Single Jump Length of The Prisoner");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Single Slip Length of The Prisoner");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jump Required To Escape Jail By The Prisponer is = "+CalculateJump(h,x,y));
            Console.ReadKey();
        }


     #region JumpCalculation
        /// <summary>
        /// Jump calculation for Prisoner who tried to scape jail wall
        /// </summary>
        /// <param name="h">heigh of the jail wall</param>
        /// <param name="x">Prisonar jump in one attemnp</param>
        /// <param name="y">Prison slips after jump</param>
        /// <returns>No of jump required to scape the jail</returns>
        public static int CalculateJump(int h, int x, int y)
        {
            if (h > x)
            {
                return CalculateJump(h - x + y, x, y) + 1;
            }
            else
            {
                return 1;
            }
        } 
        #endregion
     }   
 }
