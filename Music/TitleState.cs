using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class TitleState
    {
        public static TitleSize TitleSize = TitleSize.Normal;
    }

    public enum TitleSize
    {
        Max,
        Min,
        Normal
    }
}
