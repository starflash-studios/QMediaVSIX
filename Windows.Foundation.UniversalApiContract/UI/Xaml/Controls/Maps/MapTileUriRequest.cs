// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTileUriRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a Uri request for a tile for an HttpMapTileDataSource or a LocalMapTileDataSource.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MapTileUriRequest : IMapTileUriRequest
  {
    /// <summary>Initializes a new instance of the MapTileUriRequest class.</summary>
    [MethodImpl]
    public extern MapTileUriRequest();

    /// <summary>Gets the Uri of the request.</summary>
    /// <returns>The Uri of the request.</returns>
    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a MapTileUriRequestDeferral that the app can use to respond asynchronously to the Uri request.</summary>
    /// <returns>A MapTileUriRequestDeferral that the app can use to respond asynchronously to the Uri request.</returns>
    [MethodImpl]
    public extern MapTileUriRequestDeferral GetDeferral();
  }
}
