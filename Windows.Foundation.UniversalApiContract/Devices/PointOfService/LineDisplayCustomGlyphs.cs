// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayCustomGlyphs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents a set of custom glyphs to be used by a line display.</summary>
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LineDisplayCustomGlyphs : ILineDisplayCustomGlyphs
  {
    /// <summary>Gets the glyph dimensions (based on the number of pixels for a character cell) supported by the device</summary>
    /// <returns>The glyph dimensions, in pixels.</returns>
    public extern Size SizeInPixels { [MethodImpl] get; }

    /// <summary>Gets the list of character codes available for redefinition as custom glyphs.</summary>
    /// <returns>The list of character codes.</returns>
    public extern IVectorView<uint> SupportedGlyphCodes { [MethodImpl] get; }

    /// <summary>Attempts to asynchronously define a custom glyph.</summary>
    /// <param name="glyphCode">The character for which the glyph will be defined.</param>
    /// <param name="glyphData">The glyph data.</param>
    /// <returns>Returns True if the glyph was successfully defined; otherwise, False.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRedefineAsync(
      uint glyphCode,
      IBuffer glyphData);
  }
}
