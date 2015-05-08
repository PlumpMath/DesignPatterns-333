using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.MediaPlayer
{
    public class MediaAdapter : IWinAmpPlayer
    {
        public WindowsMediaPlayer wmp;

        public MediaAdapter()
        {
            this.wmp = new WindowsMediaPlayer();
        }

        public void Play()
        {
            wmp.Play();
        }
    }
}
