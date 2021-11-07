// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides a source of tiles for a MapTileSource. The tiles are fetched by using a local protocol such as **ms-appdata**.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ILocalMapTileDataSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class LocalMapTileDataSource : MapTileDataSource, ILocalMapTileDataSource
  {
    /// <summary>Initializes a new instance of the LocalMapTileDataSource class.</summary>
    [MethodImpl]
    public extern LocalMapTileDataSource();

    /// <summary>Initializes a new instance of the LocalMapTileDataSource class with the specified Uri format.</summary>
    /// <param name="uriFormatString">The Uri format to use.</param>
    [MethodImpl]
    public extern LocalMapTileDataSource(string uriFormatString);

    /// <summary>Gets or sets the format of the Uri for fetching tiles from a local source.</summary>
    /// <returns>The format of the Uri for fetching tiles from a local source.</returns>
    public extern string UriFormatString { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the tile is requested for an LocalMapTileDataSource. An instance of MapTileUriRequestedEventArgs provides data for this event.</summary>
    public extern event TypedEventHandler<LocalMapTileDataSource, MapTileUriRequestedEventArgs> UriRequested;
  }
}
