// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.UIElementType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Defines the set of user interface element types.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UIElementType
  {
    /// <summary>An active caption element.</summary>
    ActiveCaption = 0,
    /// <summary>A background element.</summary>
    Background = 1,
    /// <summary>A button face element.</summary>
    ButtonFace = 2,
    /// <summary>The text displayed on a button.</summary>
    ButtonText = 3,
    /// <summary>The text displayed in a caption.</summary>
    CaptionText = 4,
    /// <summary>Greyed text.</summary>
    GrayText = 5,
    /// <summary>A highlighted user interface (UI) element.</summary>
    Highlight = 6,
    /// <summary>Highlighted text.</summary>
    HighlightText = 7,
    /// <summary>A hotlighted UI element.</summary>
    Hotlight = 8,
    /// <summary>An inactive caption element.</summary>
    InactiveCaption = 9,
    /// <summary>The text displayed in an inactive caption element.</summary>
    InactiveCaptionText = 10, // 0x0000000A
    /// <summary>A window.</summary>
    Window = 11, // 0x0000000B
    /// <summary>The text displayed in a window's UI decoration.</summary>
    WindowText = 12, // 0x0000000C
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] AccentColor = 1000, // 0x000003E8
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TextHigh = 1001, // 0x000003E9
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TextMedium = 1002, // 0x000003EA
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TextLow = 1003, // 0x000003EB
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TextContrastWithHigh = 1004, // 0x000003EC
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NonTextHigh = 1005, // 0x000003ED
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NonTextMediumHigh = 1006, // 0x000003EE
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NonTextMedium = 1007, // 0x000003EF
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NonTextMediumLow = 1008, // 0x000003F0
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NonTextLow = 1009, // 0x000003F1
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PageBackground = 1010, // 0x000003F2
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PopupBackground = 1011, // 0x000003F3
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] OverlayOutsidePopup = 1012, // 0x000003F4
  }
}
