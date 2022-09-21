namespace Webmaster442.WindowsTerminalFragment;

/// <summary>
/// This sets the weight (lightness or heaviness of the strokes) for the profile's font
/// </summary>
public enum FontWeight
{
    /// <summary>
    /// Normal
    /// </summary>
    [SerializedValue("normal")]
    Normal,
    /// <summary>
    /// Thin
    /// </summary>
    [SerializedValue("thin")]
    Thin,
    /// <summary>
    /// Extra-Light
    /// </summary>
    [SerializedValue("extra-light")]
    ExtraLight, //Extra-light,
    /// <summary>
    /// Light
    /// </summary>
    [SerializedValue("light")]
    Light,
    /// <summary>
    /// SemiLight
    /// </summary>
    [SerializedValue("semi-light")]
    SemiLight, //Semi-light
    /// <summary>
    /// Medium
    /// </summary>
    [SerializedValue("medium")]
    Medium,
    /// <summary>
    /// SemiBold
    /// </summary>
    [SerializedValue("semi-bold")]
    SemiBold, //Semi-bold,
    /// <summary>
    /// Bold
    /// </summary>
    [SerializedValue("bold")]
    Bold,
    /// <summary>
    /// ExtraBold
    /// </summary>
    [SerializedValue("extra-bold")]
    ExtraBold, //Extra-bold
    /// <summary>
    /// Black
    /// </summary>
    [SerializedValue("black")]
    Black,
    /// <summary>
    /// ExtraBlack
    /// </summary>
    [SerializedValue("extra-black")]
    ExtraBlack //Extra-black
}
