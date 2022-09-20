namespace Webmaster442.WinTerminalInteract;

public sealed class TerminalSettings
{
    /// <summary>
    /// Set the default profile that opens by typing ctrl+shift+t, typing the key binding assigned to newTab, running wt new-tab without specifying a profile, or clicking the '+' icon.
    /// </summary>
    public Guid DefaultProfile { get; set; }

    /// <summary>
    /// This is the number of character columns displayed in the window upon first load. If launchMode is set to "maximized" or "maximizedFocus", this property is ignored.
    /// </summary>
    public int InitialCols { get; set; }

    /// <summary>
    /// This is the number of rows displayed in the window upon first load. If launchMode is set to "maximized" or "maximizedFocus", this property is ignored.
    /// </summary>
    public int InitialRows { get; set; }

    /// <summary>
    /// This defines whether the terminal will launch as maximized, full screen, or in a window. Setting this to focus is equivalent to launching the terminal in the default mode, but with focus mode enabled. Similarly, setting this to maximizedFocus will result in launching the terminal in a maximized window with focus mode enabled.
    /// </summary>
    public LaunchMode LaunchMode { get; set; }

    /// <summary>
    /// When set to true, Windows Terminal windows will launch on top of all other windows on the desktop. This state can also be toggled with the toggleAlwaysOnTop key binding
    /// </summary>
    public bool AlwaysOnTop { get; set; }

    /// <summary>
    /// When this is set to true, a selection is immediately copied to your clipboard upon creation. The right-click on your mouse will always paste in this case. When it's set to false, the selection persists and awaits further action. Using your mouse to right-click will copy the selection.
    /// </summary>
    public bool CopyOnSelect { get; set; }

    /// <summary>
    /// When this is set to true, the color and font formatting of the selected text is also copied to your clipboard. When it's set to false, only plain text is copied to your clipboard. You can also specify which formats you would like to copy.
    /// </summary>
    public bool CopyFormatting { get; set; }

    /// <summary>
    /// When this is set to true and you copy text in a rectangular (block) selection to the clipboard, trailing white-spaces are removed from each line. When it's set to false, the white-spaces are preserved, ensuring that all lines have the same length. To copy text in a rectangular (block) selection, hold down the Alt key, click and drag your mouse over the text area you want to select. This can be useful for selecting text columns, etc.
    /// </summary>
    public bool TrimBlockSelection { get; set; }

    /// <summary>
    /// When enabled, the terminal will automatically trim trailing whitespace characters when pasting text to the terminal.
    /// </summary>
    public bool TrimPaste { get; set; }

    /// <summary>
    /// This determines the word delimiters used in a double-click selection. Word delimiters are characters that specify where the boundary is between two words. The most common examples are spaces, semicolons, commas, and periods.
    /// </summary>
    public string WordDelimiters { get; set; }

    /// <summary>
    /// When this is set to true, tabs are always displayed. When it's set to false and showTabsInTitlebar is set to false, tabs are always displayed underneath the title bar. When this is set to false and showTabsInTitlebar is set to false, tabs only appear after more than one tab exists, by typing ctrl+shift+t or by typing the key binding assigned to newTab. Note that changing this setting will require starting a new terminal instance.
    /// </summary>
    public bool AlwaysShowTabs { get; set; }

    /// <summary>
    /// When this is set to true, the tabs are moved into the title bar and the title bar disappears. When it's set to false, the title bar sits above the tabs. Note that changing this setting will require starting a new terminal instance.
    /// </summary>
    public bool ShowTabsInTitlebar { get; set; }

    /// <summary>
    /// When this is set to true, the title bar displays the title of the selected tab. When it's set to false, title bar displays "Windows Terminal". Note that changing this setting will require starting a new terminal instance.
    /// </summary>
    public bool ShowTerminalTitleInTitlebar { get; set; }

    /// <summary>
    /// This sets the width of the tabs. "equal" makes each tab the same width. "titleLength" sizes each tab to the length of its title. "compact" will shrink every inactive tab to the width of the icon, leaving the active tab more space to display its full title.
    /// </summary>
    public TabWidthMode TabWidthMode { get; set; }

    /// <summary>
    /// When this is set to true or "mru", the nextTab and prevTab commands will use the tab switcher UI, with most recently used ordering. When set to "inOrder", these actions will switch tabs in their current order in the tab bar. The UI will show all the currently open tabs in a vertical list, navigable with the keyboard or mouse.
    /// The tab switcher will open on the initial press of the actions for nextTab and prevTab, and will stay open as long as a modifier key is held down. When all modifier keys are released, the switcher will close and the highlighted tab will be focused. tab/shift+tab, the up and down arrow keys, and the nextTab/prevTab actions can be used to cycle through the switcher UI.
    /// To disable the tab switcher, you can set this to false or "disabled".
    /// </summary>
    public TabSwitcherMode TabSwitcherMode { get; set; }

    public bool ShowAdminShield { get; set; }

    /// <summary>
    /// When this is set to true, closing a window with multiple tabs open will require confirmation. When it's set to false, closing a window with multiple tabs open will not require confirmation.
    /// </summary>
    public bool ConfirmCloseAllTabs { get; set; }

    /// <summary>
    /// When set to true, this enables the launch of Windows Terminal at startup. Setting this to false will disable the startup task entry.
    /// Note: if the Windows Terminal startup task entry is disabled either by org policy or by user action this setting will have no effect.
    /// </summary>
    public bool StartOnUserLogin { get; set; }

    /// <summary>
    /// This sets the theme of the application. "system" will use the same theme as Windows.
    /// </summary>
    public Theme Theme { get; set; }

    /// <summary>
    /// When this is set to true, the window will snap to the nearest character boundary on resize. When it's set to false, the window will resize "smoothly".
    /// </summary>
    public bool SnapToGridOnResize { get; set; }

    /// <summary>
    /// This disables visual animations across the application when set to true
    /// </summary>
    public bool DisableAnimations { get; set; }

    /// <summary>
    /// This sets the list of actions to execute on startup, allowing the terminal to launch with a custom set of tabs and panes by default. These actions will be applied only if no command line arguments were supplied. The list of actions is represented by a string with the same format as commands in the command line arguments. For more information about the commands format, visit the Command line arguments page.
    /// </summary>
    public string StartupActions { get; set; }

    /// <summary>
    /// When this is set to true, the terminal will move focus to the pane on mouse hover. When it's set to false, a click will be required to focus the pane using the mouse.
    /// </summary>
    public bool FocusFollowMouse { get; set; }

    /// <summary>
    /// When this is set to true, minimizing a window will hide it from the taskbar, making it inaccessible from that area. It will instead be accessible from terminal's notification area icon. If either this global setting or the minimizeToNotificationArea global setting is set to true, terminal will place an icon in the notification area.
    /// </summary>
    public bool MinimizeToNotificationArea { get; set; }

    /// <summary>
    /// When this is set to true, the terminal will place its icon in the notification area. If either this global setting or the minimizeToNotificationArea global setting is set to true, the terminal will place an icon in the notification area. The user will also be able to utilize the minimizeToNotificationArea action.
    /// </summary>
    public bool AlwaysShowNotificationIcon { get; set; }

    public TerminalSettings()
    {
        DefaultProfile = Guid.NewGuid();
        InitialCols = 120;
        InitialRows = 30;
        LaunchMode = LaunchMode.Default;
        TrimBlockSelection = true;
        TrimPaste = true;
        WordDelimiters = " /\\()\"'-.,:;<>~!@#$%^&*|+=[]{}~?\u2502";
        AlwaysShowTabs = true;
        ShowTabsInTitlebar = true;
        ShowTerminalTitleInTitlebar = true;
        TabWidthMode = TabWidthMode.Equal;
        TabSwitcherMode = TabSwitcherMode.InOrder;
        ConfirmCloseAllTabs = true;
        ShowAdminShield = true;
        Theme = Theme.System;
        SnapToGridOnResize = true;
        StartupActions = string.Empty;
    }
}
