// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.TileSize
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  /// <summary>Specifies the size of tile to pin. Used by some secondary tile constructors.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TileSize
  {
    /// <summary>Use the default size of the app tile.</summary>
    Default,
    /// <summary>The small image size used in search results, the Apps list, and in some other parts of the UI.</summary>
    /// <deprecated type="deprecate">TileSize.Square30x30 may be altered or unavailable for release after Windows 10.</deprecated>
    [Deprecated("TileSize.Square30x30 may be altered or unavailable for release after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] Square30x30,
    /// <summary>The small tile used on the Start screen.</summary>
    /// <deprecated type="deprecate">TileSize.Square70x70 may be altered or unavailable for release after Windows Phone 8.1.</deprecated>
    [Deprecated("TileSize.Square70x70 may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] Square70x70,
    /// <summary>The medium tile.</summary>
    Square150x150,
    /// <summary>The wide tile.</summary>
    Wide310x150,
    /// <summary>The large tile.</summary>
    Square310x310,
    /// <summary>** only**: The small tile used on the Start screen. Note that you cannot specify the size of a pinned secondary tile on Windows Phone 8.1, so this value currently has no use.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Square71x71,
    /// <summary>The small image size used in search results, the Apps list, and in some other parts of the UI.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Square44x44,
  }
}
