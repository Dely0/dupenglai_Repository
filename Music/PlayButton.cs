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
    }

    public enum PlayButtonState
    {
        play,
        puase
    }
}
