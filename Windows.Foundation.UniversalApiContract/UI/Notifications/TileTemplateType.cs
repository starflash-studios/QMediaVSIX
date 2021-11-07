// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileTemplateType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the content template to use in a tile update. For a more detailed discussion of each tile, including an example of its XML coding, specifics on each template's image sizes, and use with different versions of the tile XML schema, see [The tile template catalog](https://docs.microsoft.com/previous-versions/windows/apps/hh761491(v=win.10)).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TileTemplateType
  {
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileSquareImage**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Image = 0,
    /// <summary>One image that fills the entire tile; no text. &lt;img src="./windows.ui.notifications/images/TileSquareImage.png" alt="TileSquareImage example" /&gt;</summary>
    /// <deprecated type="deprecate">TileSquareImage may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Image.</deprecated>
    [Deprecated("TileSquareImage may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Image.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareImage = 0,
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileSquareBlock**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Block = 1,
    /// <summary>****: One string of large block text (generally numerical) over a single, short line of regular text.</summary>
    /// <deprecated type="deprecate">TileSquareBlock may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Block.</deprecated>
    [Deprecated("TileSquareBlock may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Block.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareBlock = 1,
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileSquareText01**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Text01 = 2,
    /// <summary>One header string in larger text on the first line; three strings of regular text on each of the next three lines. Text does not wrap. &lt;img src="./windows.ui.notifications/images/TileSquareText01.png" alt="TileSquareText01 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileSquareText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text01.</deprecated>
    [Deprecated("TileSquareText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareText01 = 2,
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileSquareText02**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Text02 = 3,
    /// <summary>One header string in larger text on the first line, over one string of regular text wrapped over a maximum of three lines. &lt;img src="./windows.ui.notifications/images/TileSquareText02.png" alt="TileSquareText02 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileSquareText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text02.</deprecated>
    [Deprecated("TileSquareText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareText02 = 3,
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileSquareText03**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Text03 = 4,
    /// <summary>Four strings of regular text on four lines. Text does not wrap. &lt;img src="./windows.ui.notifications/images/TileSquareText03.png" alt="TileSquareText03 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileSquareText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text03.</deprecated>
    [Deprecated("TileSquareText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareText03 = 4,
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileSquareText04**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Text04 = 5,
    /// <summary>One string of regular text wrapped over a maximum of four lines. &lt;img src="./windows.ui.notifications/images/TileSquareText04.png" alt="TileSquareText04 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileSquareText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text04.</deprecated>
    [Deprecated("TileSquareText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareText04 = 5,
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileSquarePeekImageAndText01**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150PeekImageAndText01 = 6,
    /// <summary>Top/Front: One square image, no text. Bottom/Back: One header string in larger text on the first line, three strings of regular text on each of the next three lines. Text does not wrap. &lt;img src="./windows.ui.notifications/images/TileSquarePeekImageAndText01.png" alt="TileSquarePeekImageAndText01 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileSquarePeekImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText01.</deprecated>
    [Deprecated("TileSquarePeekImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquarePeekImageAndText01 = 6,
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileSquarePeekImageAndText02**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150PeekImageAndText02 = 7,
    /// <summary>Top/Front: Square image, no text. Bottom/Back: One header string in larger text on the first line, over one string of regular text wrapped over a maximum of three lines. &lt;img src="./windows.ui.notifications/images/TileSquarePeekImageAndText02.png" alt="TileSquarePeekImageAndText02 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileSquarePeekImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText02.</deprecated>
    [Deprecated("TileSquarePeekImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquarePeekImageAndText02 = 7,
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileSquarePeekImageAndText03**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150PeekImageAndText03 = 8,
    /// <summary>Top/Front: Square image, no text. Bottom/Back: Four strings of regular text on four lines. Text does not wrap. &lt;img src="./windows.ui.notifications/images/TileSquarePeekImageAndText03.png" alt="TileSquarePeekImageAndText03 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileSquarePeekImageAndText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText03.</deprecated>
    [Deprecated("TileSquarePeekImageAndText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquarePeekImageAndText03 = 8,
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileSquarePeekImageAndText04**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150PeekImageAndText04 = 9,
    /// <summary>Top/Front: Square image, no text. Bottom/Back: One string of regular text wrapped over a maximum of four lines. &lt;img src="./windows.ui.notifications/images/TileSquarePeekImageAndText04.png" alt="TileSquarePeekImageAndText04 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileSquarePeekImageAndText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText04.</deprecated>
    [Deprecated("TileSquarePeekImageAndText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquarePeekImageAndText04 = 9,
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideImage**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Image = 10, // 0x0000000A
    /// <summary>One wide image that fills the entire tile, no text. &lt;img src="./windows.ui.notifications/images/TileWideImage.png" alt="TileWideImage example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideImage may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Image.</deprecated>
    [Deprecated("TileWideImage may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Image.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideImage = 10, // 0x0000000A
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideImageCollection**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150ImageCollection = 11, // 0x0000000B
    /// <summary>****: One large square image with four smaller square images to its right, no text.</summary>
    /// <deprecated type="deprecate">TileWideImageCollection may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageCollection.</deprecated>
    [Deprecated("TileWideImageCollection may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageCollection.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideImageCollection = 11, // 0x0000000B
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideImageAndText01**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150ImageAndText01 = 12, // 0x0000000C
    /// <summary>One wide image over one string of regular text wrapped over a maximum of two lines (one line on Windows Phone 8.1). The width of the text area depends on whether a logo is displayed. </summary>
    /// <deprecated type="deprecate">TileWideImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageAndText01.</deprecated>
    [Deprecated("TileWideImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageAndText01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideImageAndText01 = 12, // 0x0000000C
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideImageAndText02**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150ImageAndText02 = 13, // 0x0000000D
    /// <summary>****: One wide image over two strings of regular text on two lines. Text does not wrap. The width of the text area depends on whether a logo is displayed.</summary>
    /// <deprecated type="deprecate">TileWideImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageAndText02.</deprecated>
    [Deprecated("TileWideImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageAndText02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideImageAndText02 = 13, // 0x0000000D
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideBlockAndText01**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150BlockAndText01 = 14, // 0x0000000E
    /// <summary>Four strings of regular, unwrapped text on the left; large block text (this should be numerical) over a single, short string of regular text on the right. </summary>
    /// <deprecated type="deprecate">TileWideBlockAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150BlockAndText01.</deprecated>
    [Deprecated("TileWideBlockAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150BlockAndText01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideBlockAndText01 = 14, // 0x0000000E
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideBlockAndText02**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150BlockAndText02 = 15, // 0x0000000F
    /// <summary>One string of regular text wrapped over a maximum of four lines on the left; large block text (this should be numerical) over a single, short string of regular text on the right. &lt;img src="./windows.ui.notifications/images/TileWideBlockAndText02.png" alt="TileWideBlockAndText02 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideBlockAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150BlockAndText02.</deprecated>
    [Deprecated("TileWideBlockAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150BlockAndText02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideBlockAndText02 = 15, // 0x0000000F
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImageCollection01**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection01 = 16, // 0x00000010
    /// <summary>****: Top: One large square image with four smaller square images to its right, no text.</summary>
    /// <deprecated type="deprecate">TileWidePeekImageCollection01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection01.</deprecated>
    [Deprecated("TileWidePeekImageCollection01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection01 = 16, // 0x00000010
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImageCollection02**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection02 = 17, // 0x00000011
    /// <summary>****: Top: One large square image with four smaller square images to its right, no text.</summary>
    /// <deprecated type="deprecate">TileWidePeekImageCollection02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection02.</deprecated>
    [Deprecated("TileWidePeekImageCollection02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection02 = 17, // 0x00000011
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImageCollection03**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection03 = 18, // 0x00000012
    /// <summary>****: Top: One large square image with four smaller square images to its right, no text.</summary>
    /// <deprecated type="deprecate">TileWidePeekImageCollection03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection03.</deprecated>
    [Deprecated("TileWidePeekImageCollection03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection03 = 18, // 0x00000012
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImageCollection04**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection04 = 19, // 0x00000013
    /// <summary>****: Top: One large square image with four smaller square images to its right, no text.</summary>
    /// <deprecated type="deprecate">TileWidePeekImageCollection04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection04.</deprecated>
    [Deprecated("TileWidePeekImageCollection04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection04 = 19, // 0x00000013
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImageCollection05**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection05 = 20, // 0x00000014
    /// <summary>****: Top: One large square image with four smaller square images to its right, no text.</summary>
    /// <deprecated type="deprecate">TileWidePeekImageCollection05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection05.</deprecated>
    [Deprecated("TileWidePeekImageCollection05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection05.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection05 = 20, // 0x00000014
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImageCollection06**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection06 = 21, // 0x00000015
    /// <summary>****: Top: One large square image with four smaller square images to its right, no text.</summary>
    /// <deprecated type="deprecate">TileWidePeekImageCollection06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection06.</deprecated>
    [Deprecated("TileWidePeekImageCollection06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection06.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection06 = 21, // 0x00000015
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImageAndText01**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageAndText01 = 22, // 0x00000016
    /// <summary>****: Top: One wide image, with a shorter height than a full-bleed wide image.</summary>
    /// <deprecated type="deprecate">TileWidePeekImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageAndText01.</deprecated>
    [Deprecated("TileWidePeekImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageAndText01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageAndText01 = 22, // 0x00000016
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImageAndText02**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageAndText02 = 23, // 0x00000017
    /// <summary>Top/Front: One wide image, with a shorter height than a full-bleed wide image. Bottom/Back: Five strings of regular text on five lines. Text does not wrap. &lt;img src="./windows.ui.notifications/images/TileWidePeekImageAndText02.jpg" alt="TileWidePeekImageAndText02 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWidePeekImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageAndText02.</deprecated>
    [Deprecated("TileWidePeekImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageAndText02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageAndText02 = 23, // 0x00000017
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImage01**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage01 = 24, // 0x00000018
    /// <summary>Top/Front: One wide image. Bottom/Back: One header string in larger text over one string of regular text that wraps over a maximum of four lines. &lt;img src="./windows.ui.notifications/images/TileWidePeekImage01.png" alt="TileWidePeekImage01 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWidePeekImage01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage01.</deprecated>
    [Deprecated("TileWidePeekImage01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage01 = 24, // 0x00000018
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImage02**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage02 = 25, // 0x00000019
    /// <summary>Top/Front: One wide image. Bottom/Back: One header string in larger text on the first line, four strings of regular text on the next four lines. Text does not wrap. &lt;img src="./windows.ui.notifications/images/TileWidePeekImage02.png" alt="TileWidePeekImage02 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWidePeekImage02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage02.</deprecated>
    [Deprecated("TileWidePeekImage02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage02 = 25, // 0x00000019
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImage03**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage03 = 26, // 0x0000001A
    /// <summary>Top/Front: One wide image. Bottom/Back: One string of large text wrapped over a maximum of three lines. &lt;img src="./windows.ui.notifications/images/TileWidePeekImage03.png" alt="TileWidePeekImage03 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWidePeekImage03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage03.</deprecated>
    [Deprecated("TileWidePeekImage03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage03 = 26, // 0x0000001A
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImage04**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage04 = 27, // 0x0000001B
    /// <summary>Top/Front: One wide image. Bottom/Back: One string of regular text wrapped over a maximum of five lines. &lt;img src="./windows.ui.notifications/images/TileWidePeekImage04.png" alt="TileWidePeekImage04 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWidePeekImage04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage04.</deprecated>
    [Deprecated("TileWidePeekImage04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage04 = 27, // 0x0000001B
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImage05**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage05 = 28, // 0x0000001C
    /// <summary>Top/Front: One wide image.</summary>
    /// <deprecated type="deprecate">TileWidePeekImage05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage05.</deprecated>
    [Deprecated("TileWidePeekImage05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage05.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage05 = 28, // 0x0000001C
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWidePeekImage06**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage06 = 29, // 0x0000001D
    /// <summary>Top/Front: One wide image.</summary>
    /// <deprecated type="deprecate">TileWidePeekImage06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage06.</deprecated>
    [Deprecated("TileWidePeekImage06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage06.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage06 = 29, // 0x0000001D
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideSmallImageAndText01**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150SmallImageAndText01 = 30, // 0x0000001E
    /// <summary>On the left, one small image; on the right, one string of large text wrapped over a maximum of three lines. </summary>
    /// <deprecated type="deprecate">TileWideSmallImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText01.</deprecated>
    [Deprecated("TileWideSmallImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideSmallImageAndText01 = 30, // 0x0000001E
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideSmallImageAndText02**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150SmallImageAndText02 = 31, // 0x0000001F
    /// <summary>On the left, one small image; on the right, one header string in larger text on the first line, four strings of regular text on the next four lines. Text does not wrap. </summary>
    /// <deprecated type="deprecate">TileWideSmallImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText02.</deprecated>
    [Deprecated("TileWideSmallImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideSmallImageAndText02 = 31, // 0x0000001F
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideSmallImageAndText03**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150SmallImageAndText03 = 32, // 0x00000020
    /// <summary>On the left, one small image; on the right, one string of regular text wrapped over a maximum of five lines. </summary>
    /// <deprecated type="deprecate">TileWideSmallImageAndText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText03.</deprecated>
    [Deprecated("TileWideSmallImageAndText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideSmallImageAndText03 = 32, // 0x00000020
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideSmallImageAndText04**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150SmallImageAndText04 = 33, // 0x00000021
    /// <summary>On the left, one small image; on the right, one header string of larger text on the first line over one string of regular text wrapped over a maximum of four lines. </summary>
    /// <deprecated type="deprecate">TileWideSmallImageAndText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText04.</deprecated>
    [Deprecated("TileWideSmallImageAndText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideSmallImageAndText04 = 33, // 0x00000021
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideSmallImageAndText05**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150SmallImageAndText05 = 34, // 0x00000022
    /// <summary>On the left, one header string in larger text over one string of regular text wrapped over a maximum of four lines; on the right, one small image with 3:4 dimensions. </summary>
    /// <deprecated type="deprecate">TileWideSmallImageAndText05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText05.</deprecated>
    [Deprecated("TileWideSmallImageAndText05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText05.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideSmallImageAndText05 = 34, // 0x00000022
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideText01**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text01 = 35, // 0x00000023
    /// <summary>One header string in larger text on the first line, four strings of regular text on the next four lines. Text does not wrap. &lt;img src="./windows.ui.notifications/images/TileWideText01.png" alt="TileWideText01 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text01.</deprecated>
    [Deprecated("TileWideText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText01 = 35, // 0x00000023
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text02 = 36, // 0x00000024
    /// <summary>One header string in larger text over eight short strings arranged in two columns of four lines each. Columns are of equal width. This template is similar to TileWideText07 and TileWideText10, but those templates use columns of unequal width. &lt;img src="./windows.ui.notifications/images/TileWideText02.png" alt="TileWideText02 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text02.</deprecated>
    [Deprecated("TileWideText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText02 = 36, // 0x00000024
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideText03**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text03 = 37, // 0x00000025
    /// <summary>One string of large text wrapped over a maximum of three lines. &lt;img src="./windows.ui.notifications/images/TileWideText03.png" alt="TileWideText03 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text03.</deprecated>
    [Deprecated("TileWideText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText03 = 37, // 0x00000025
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideText04**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text04 = 38, // 0x00000026
    /// <summary>One string of regular text wrapped over a maximum of five lines. &lt;img src="./windows.ui.notifications/images/TileWideText04.png" alt="TileWideText04 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text04.</deprecated>
    [Deprecated("TileWideText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText04 = 38, // 0x00000026
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideText05**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text05 = 39, // 0x00000027
    /// <summary>Five strings of regular text on five lines. Text does not wrap. &lt;img src="./windows.ui.notifications/images/TileWideText05.png" alt="TileWideText05 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideText05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text05.</deprecated>
    [Deprecated("TileWideText05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text05.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText05 = 39, // 0x00000027
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text06 = 40, // 0x00000028
    /// <summary>Ten short strings of regular text, arranged in two columns of five lines each. Columns are of equal width. This template is similar to TileWideText08 and TileWideText11, but those templates use columns of unequal width. &lt;img src="./windows.ui.notifications/images/TileWideText06.png" alt="TileWideText06 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideText06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text06.</deprecated>
    [Deprecated("TileWideText06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text06.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText06 = 40, // 0x00000028
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text07 = 41, // 0x00000029
    /// <summary>One header string in larger text over eight short strings of regular text arranged in two columns of four lines each. The column widths are such that the first column acts as a label and the second column as the content. This template is similar to TileWideText10, which has an even narrower first column, and TileWideText02, which has columns of equal width. &lt;img src="./windows.ui.notifications/images/TileWideText07.png" alt="TileWideText07 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideText07 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text07.</deprecated>
    [Deprecated("TileWideText07 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text07.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText07 = 41, // 0x00000029
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text08 = 42, // 0x0000002A
    /// <summary>Ten short strings of regular text arranged in two columns of five lines each. The column widths are such that the first column acts as a label and the second column as the content. This template is similar to TileWideText11, which has an even narrower first column, and TileWideText06, which has columns of equal width. &lt;img src="./windows.ui.notifications/images/TileWideText08.png" alt="TileWideText08 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideText08 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text08.</deprecated>
    [Deprecated("TileWideText08 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text08.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText08 = 42, // 0x0000002A
    /// <summary> Windows 8 (Version 1) name/Windows 8.1  fallback attribute value: **TileWideText09**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text09 = 43, // 0x0000002B
    /// <summary>One header string in larger text over one string of regular text wrapped over a maximum of four lines. &lt;img src="./windows.ui.notifications/images/TileWideText09.png" alt="TileWideText09 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideText09 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text09.</deprecated>
    [Deprecated("TileWideText09 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text09.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText09 = 43, // 0x0000002B
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text10 = 44, // 0x0000002C
    /// <summary>One header string in larger text over eight short strings of regular text arranged in two columns of four lines each. The column widths are such that the first column acts as a label and the second column as the content. This template is similar to TileWideText07, which has a wider first column, and TileWideText02, which has columns of equal width. &lt;img src="./windows.ui.notifications/images/TileWideText10.png" alt="TileWideText10 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideText10 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text10.</deprecated>
    [Deprecated("TileWideText10 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText10 = 44, // 0x0000002C
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text11 = 45, // 0x0000002D
    /// <summary>Ten short strings of regular text arranged in two columns of five lines each. The column widths are such that the first column acts as a label and the second column as the content. This template is similar to TileWideText08, which has a wider first column, and TileWideText06, which has columns of equal width. &lt;img src="./windows.ui.notifications/images/TileWideText11.png" alt="TileWideText11 example" /&gt;</summary>
    /// <deprecated type="deprecate">TileWideText11 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text11.</deprecated>
    [Deprecated("TileWideText11 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text11.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText11 = 45, // 0x0000002D
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310BlockAndText01 = 46, // 0x0000002E
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310BlockAndText02 = 47, // 0x0000002F
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Image = 48, // 0x00000030
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageAndText01 = 49, // 0x00000031
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageAndText02 = 50, // 0x00000032
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageAndTextOverlay01 = 51, // 0x00000033
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageAndTextOverlay02 = 52, // 0x00000034
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageAndTextOverlay03 = 53, // 0x00000035
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageCollectionAndText01 = 54, // 0x00000036
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageCollectionAndText02 = 55, // 0x00000037
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageCollection = 56, // 0x00000038
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImagesAndTextList01 = 57, // 0x00000039
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImagesAndTextList02 = 58, // 0x0000003A
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImagesAndTextList03 = 59, // 0x0000003B
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImagesAndTextList04 = 60, // 0x0000003C
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text01 = 61, // 0x0000003D
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text02 = 62, // 0x0000003E
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text03 = 63, // 0x0000003F
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text04 = 64, // 0x00000040
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text05 = 65, // 0x00000041
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text06 = 66, // 0x00000042
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text07 = 67, // 0x00000043
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text08 = 68, // 0x00000044
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310TextList01 = 69, // 0x00000045
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310TextList02 = 70, // 0x00000046
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310TextList03 = 71, // 0x00000047
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImageAndText01 = 72, // 0x00000048
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImagesAndTextList05 = 73, // 0x00000049
    /// <summary>**Windows only; not supported on **</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text09 = 74, // 0x0000004A
    /// <summary>** only**.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare71x71IconWithBadge = 75, // 0x0000004B
    /// <summary>** only**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150IconWithBadge = 76, // 0x0000004C
    /// <summary>** only**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150IconWithBadgeAndText = 77, // 0x0000004D
    /// <summary>** only**</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare71x71Image = 78, // 0x0000004E
    /// <summary>One rectangular image that fills the entire tile, no text.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileTall150x310Image = 79, // 0x0000004F
  }
}
