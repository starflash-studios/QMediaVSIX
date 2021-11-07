// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.CustomMapTileDataSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides a source of custom tiles for a MapTileSource. Use this class when you can't use HttpMapTileDataSource or LocalMapTileDataSource. For example, CustomMapTileDataSource supports drawing tiles in memory and returning them as a stream of pixels.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (ICustomMapTileDataSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class CustomMapTileDataSource : MapTileDataSource, ICustomMapTileDataSource
  {
    /// <summary>Initializes a new instance of the CustomMapTileDataSource class.</summary>
    [MethodImpl]
    public extern CustomMapTileDataSource();

    /// <summary>Occurs when the bitmap is requested for a CustomMapTileDataSource. An instance of MapTileBitmapRequestedEventArgs provides data for this event.</summary>
    public extern event TypedEventHandler<CustomMapTileDataSource, MapTileBitmapRequestedEventArgs> BitmapRequested;
  }
}
