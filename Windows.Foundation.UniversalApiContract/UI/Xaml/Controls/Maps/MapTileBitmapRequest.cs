// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a bitmap request for a tile for a CustomMapTileDataSource.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MapTileBitmapRequest : IMapTileBitmapRequest
  {
    /// <summary>Initializes a new instance of MapTileBitmapRequest class.</summary>
    [MethodImpl]
    public extern MapTileBitmapRequest();

    /// <summary>Gets the bitmap data for the CustomMapTileDataSource.</summary>
    /// <returns>The bitmap data.</returns>
    public extern IRandomAccessStreamReference PixelData { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a MapTileBitmapRequestDeferral that the app can use to respond asynchronously to the bitmap request.</summary>
    /// <returns>The deferral object that the app uses to indicate that it has finished responding to a BitmapRequested event and that the request is complete.</returns>
    [MethodImpl]
    public extern MapTileBitmapRequestDeferral GetDeferral();
  }
}
