// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides data for the CustomMapTileDataSource.BitmapRequested event.</summary>
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapTileBitmapRequestedEventArgs : 
    IMapTileBitmapRequestedEventArgs,
    IMapTileBitmapRequestedEventArgs2
  {
    /// <summary>Initializes a new instance of the MapTileBitmapRequestedEventArgs class.</summary>
    [MethodImpl]
    public extern MapTileBitmapRequestedEventArgs();

    /// <summary>Gets the X value of the requested tile.</summary>
    /// <returns>The X value of the requested tile.</returns>
    public extern int X { [MethodImpl] get; }

    /// <summary>Gets the Y value of the requested tile.</summary>
    /// <returns>The Y value of the requested tile.</returns>
    public extern int Y { [MethodImpl] get; }

    /// <summary>Gets the zoom level of the requested tile.</summary>
    /// <returns>The zoom level of the requested tile.</returns>
    public extern int ZoomLevel { [MethodImpl] get; }

    /// <summary>Gets the bitmap request.</summary>
    /// <returns>The bitmap request.</returns>
    public extern MapTileBitmapRequest Request { [MethodImpl] get; }

    /// <summary>Gets the number of frame of the requested tile.</summary>
    /// <returns>The number of frame of the requested tile.</returns>
    public extern int FrameIndex { [MethodImpl] get; }
  }
}
