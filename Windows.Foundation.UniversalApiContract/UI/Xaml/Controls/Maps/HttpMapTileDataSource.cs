// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides a source of tiles for a MapTileSource. The tiles are fetched by using the HTTP or HTTPS protocol. Note that, as of build 15063, local uris don't work anymore.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IHttpMapTileDataSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class HttpMapTileDataSource : MapTileDataSource, IHttpMapTileDataSource
  {
    /// <summary>Initializes a new instance of the HttpMapTileDataSource class.</summary>
    [MethodImpl]
    public extern HttpMapTileDataSource();

    /// <summary>Initializes a new instance of the HttpMapTileDataSource class with the specified Uri format.</summary>
    /// <param name="uriFormatString">The Uri format to use.</param>
    [MethodImpl]
    public extern HttpMapTileDataSource(string uriFormatString);

    /// <summary>Gets or sets the format of the Uri for fetching tiles from an HTTP source.</summary>
    /// <returns>The format of the Uri for fetching tiles from an HTTP source.</returns>
    public extern string UriFormatString { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets additional HTTP request headers and their values for fetching tiles from an HTTP source.</summary>
    /// <returns>Additional HTTP request headers and their values for fetching tiles from an HTTP source.</returns>
    public extern IMap<string, string> AdditionalRequestHeaders { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the Internet cache is checked before fetching a tile from an HTTP source. When caching is disabled, a new request for the tile is made every time.</summary>
    /// <returns>**true** if the Internet cache is checked before fetching a tile from an HTTP source; otherwise, **false**.</returns>
    public extern bool AllowCaching { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the tile is requested for an HttpMapTileDataSource. An instance of MapTileUriRequestedEventArgs provides data for this event.</summary>
    public extern event TypedEventHandler<HttpMapTileDataSource, MapTileUriRequestedEventArgs> UriRequested;
  }
}
