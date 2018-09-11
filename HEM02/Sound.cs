using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    
        class Sound
        {
        private string stereoType;
            public void StartMusic()
            {
                Console.WriteLine("{0} switched to music on",stereoType);
            }


            public void StopMusic()
            {
                Console.WriteLine("{0} switched to music off",stereoType);
            }
        }
    
}
