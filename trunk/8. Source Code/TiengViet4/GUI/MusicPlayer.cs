using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace TiengViet4
{
    class MusicPlayer
    {
        string strCommand;
        bool blnOpened;
        
        [DllImport("Winmm.dll")]
        private static extern long mciSendString(string strComand, string strReturn, int intReturnLength, IntPtr hwndCallback);

        public void Open(string strFileName)
        {
            strCommand = "open \"" + strFileName + "\" type mpegvideo alias MediaFile";
            mciSendString(strCommand, null, 0, IntPtr.Zero);
            blnOpened = true;
        }
       
        public void Play(bool blnLoop)
        {
            if (blnOpened == true)
            {
                strCommand = "play MediaFile";
                if (blnLoop == true)
                {
                    strCommand += " REPEAT";
                }
                mciSendString(strCommand, null, 0, IntPtr.Zero);
            }
        }

        public void Close()
        {
            if (blnOpened == true)
            {
                strCommand = "close MediaFile";
                mciSendString(strCommand, null, 0, IntPtr.Zero);
                blnOpened = false;
            }
        }
    }
}
