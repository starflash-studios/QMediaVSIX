// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTileUriRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides data for the HttpMapTileDataSource.UriRequested event and the LocalMapTileDataSource.UriRequested event.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class MapTileUriRequestedEventArgs : 
    IMapTileUriRequestedEventArgs,
    IMapTileUriRequestedEventArgs2
  {
    /// <summary>Initializes a new instance of the MapTileUriRequestedEventArgs class.</summary>
    [MethodImpl]
    public extern MapTileUriRequestedEventArgs();

    /// <summary>Gets the X value of the requested tile.</summary>
    /// <returns>The X value of the requested tile.</returns>
    public extern int X { [MethodImpl] get; }

    /// <summary>Gets the Y value of the requested tile.</summary>
    /// <returns>The Y value of the requested tile.</returns>
    public extern int Y { [MethodImpl] get; }

    /// <summary>Gets the zoom level of the requested tile.</summary>
    /// <returns>The zoom level of the requested tile.</returns>
    public extern int ZoomLevel { [MethodImpl] get; }

    /// <summary>Gets the Uri request.</summary>
    /// <returns>The Uri request.</returns>
    public extern MapTileUriRequest Request { [MethodImpl] get; }

    /// <summary>Gets the number of frame of the requested tile.</summary>
    /// <returns>The number of frame of the requested tile.</returns>
    public extern int FrameIndex { [MethodImpl] get; }
  }
}
