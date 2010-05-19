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
        private static extern long mciSendString(string strComand, StringBuilder strReturn, int intReturnLength, IntPtr hwndCallback);

        public void Open(string strFileName)
        {
            strCommand = "open \"" + strFileName + "\" type mpegvideo alias MediaFile";
            mciSendString(strCommand, null, 0, IntPtr.Zero);
            blnOpened = true;
        }
       
        public void Play(bool blnLoop)
        {
            if (blnOpened)
            {
                strCommand = "play MediaFile";
                if (blnLoop == true)
                {
                    strCommand += " REPEAT";
                }
                mciSendString(strCommand, null, 0, IntPtr.Zero);
            }
        }

        public void Seek(ulong lMiliseconds)
        {
            strCommand = String.Format("seek MediaFile to {0}", lMiliseconds);
            mciSendString(strCommand, null, 0, IntPtr.Zero);
        }

        public ulong GetLength()
        {
            StringBuilder str = new StringBuilder(128); 
            mciSendString("status MediaFile length", str, 128, IntPtr.Zero); 
            return Convert.ToUInt64(str.ToString());
        }
        
        public void Pause()
        {
            strCommand = "pause MediaFile";
            mciSendString(strCommand, null, 0, IntPtr.Zero);
        }



        public void Close()
        {
            if (blnOpened)
            {
                strCommand = "close MediaFile";
                mciSendString(strCommand, null, 0, IntPtr.Zero);
                blnOpened = false;
            }
        }
    }
}
