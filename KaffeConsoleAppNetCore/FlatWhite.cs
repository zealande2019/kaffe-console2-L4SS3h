using System;
using System.Collections.Generic;
using System.Text;
using kaffe;

namespace KaffeConsoleAppNetCore
{
    public class FlatWhite : Kaffe, Imælk
    {
        public FlatWhite(int rabat) :base(rabat)
        {
            //Rabat = rabat;
        }

        public int MlMælk()
        {
            return 120;
        }

        public override int Pris()
        {
            return 45;
        }

        public override string Styrke()
        {
            return "mild";
        }
    }
}
