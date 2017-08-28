using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public static class PlayButton
    {
        public static PlayButtonState state = PlayButtonState.puase;
        public const string Play_URL = @"resource\Play.ico";
        public const string Puase_URL = @"resource\Puase.ico";
        public const string Play_Press_URL = @"resource\Play_Press.ico";
        public const string Puase_Press_URL = @"resource\Puase_Press.ico";
        public const string Next_URL = @"resource\Next.ico";
        public const string Next_Press_URL = @"resource\Next_Press.ico";
        public const string Previous_URL = @"resource\Previous.ico";
        public const string Previous_Press_URL = @"resource\Previous_Press.ico";
    }

    public enum PlayButtonState
    {
        play,
        puase
    }
}
