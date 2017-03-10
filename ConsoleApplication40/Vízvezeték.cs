using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication40
{
    public class Vízvezetékszerelő : mesterember
    {
        private int tapasztalat;

        public Vízvezetékszerelő(string név, int napidíj, int tapasztalat): base(név, napidíj)
        {
            this.tapasztalat = tapasztalat;
        }

        public int Property
        {
            get
            {
                return tapasztalat;
            }

            set
            {
                if(value<=tapasztalat)
                    return;
            }
        }

        public new string mindenadat()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("név:");
            sb.Append(név);
            sb.AppendLine("napidíj: ");
            sb.Append(napidíj);
            sb.AppendLine("tapasztalat");
            sb.Append(tapasztalat);

            return sb.ToString();
            
        }

        public override bool munkátvállal(int a)
        {
            if (foglaltnapok[a]=true&&foglaltnapok[a-1]&&foglaltnapok[a+1])
            {
                return true;
            }
            return false;
        }

    }
}