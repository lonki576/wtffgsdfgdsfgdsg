using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication40
{
    public abstract class mesterember
    {
        protected string név;
        protected int napidíj;
        protected bool[] foglaltnapok= new bool[31];

        public mesterember(string név, int napidíj)
        {
            this.név = név;

            this.napidíj = napidíj;


            for (int i = 0; i < 31; i++)
                foglaltnapok[i] = true;
        }

        public string mindenadat()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("név:");
            sb.Append(név);
            sb.AppendLine("napidíj: ");
            sb.Append(napidíj);

           
            

            return sb.ToString();

            
        }

        public abstract bool munkátvállal(int a);
    }
}