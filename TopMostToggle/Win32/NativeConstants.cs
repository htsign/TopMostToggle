namespace MyApp
{
    public static class NativeConstants
    {
        public const int  HWND_TOPMOST   = -1;
        public const int  HWND_NOTOPMOST = -2;
        public const uint SWP_NOSIZE     = 1;
        public const uint SWP_NOMOVE     = 2;
        public const uint TOPMOST_FLAGS  = SWP_NOSIZE | SWP_NOMOVE;
        public const int  GWL_STYLE      = -16;
        public const int  GWL_EXSTYLE    = -20;
        public const uint WS_EX_TOPMOST  = 8;
        public const uint WS_MAXIMIZE    = 0x1000000;
        public const uint WS_MINIMIZE    = 0x20000000;
        public const int  SW_MAXIMIZE    = 3;
        public const int  SW_MINIMIZE    = 6;
        public const int  SW_RESTORE     = 9;
    }
}
