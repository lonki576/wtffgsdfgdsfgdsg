using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication40
{
    public class Burkoló : mesterember
    {
        private szakterületek szakterület;

        public Burkoló(string név,int napidíj, szakterületek szakterület): base(név, napidíj)
        {
            this.szakterület = szakterület;
        }

        public szakterületek Property
        {
            get
            {
                return szakterület;
            }

            set
            {
                if (value!=szakterületek.belső&&value!=szakterületek.külső)
                {
                    return;
                }
            }
        }

        public int összesszabadnap()
        {
            int szabadnapok = 0;
            for(int i=0; i<31;i++)
            {
                if(foglaltnapok[i]==true)
                {
                    szabadnapok++;
                }
            }
            return szabadnapok;
        }

        public new string mindenadat()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("név:");
            sb.Append(név);
            sb.Append(szakterület);
            sb.AppendLine("napidíj: ");
            sb.Append(napidíj);

            

            return sb.ToString();
        }

        public override bool munkátvállal(int a)
        {
            if (foglaltnapok[a] == true)
            {
                foglaltnapok[a] = false;
                return true;
            }
            return false;
        }
    }
}