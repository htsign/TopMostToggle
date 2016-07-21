namespace MyApp
{
    public enum WindowState
    {
        [AliasName("通常")]
        Normal    = NativeConstants.SW_RESTORE,
        [AliasName("最小化")]
        Minimized = NativeConstants.SW_MINIMIZE,
        [AliasName("最大化")]
        Maximized = NativeConstants.SW_MAXIMIZE,
    }
}
