// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a deferral that can be used by an app to respond asynchronously to a bitmap request for a tile.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class MapTileBitmapRequestDeferral : IMapTileBitmapRequestDeferral
  {
    /// <summary>Initializes a new instance of the MapTileBitmapRequestDeferral class.</summary>
    [MethodImpl]
    public extern MapTileBitmapRequestDeferral();

    /// <summary>Notifies the system that the app has finished processing the bitmap request for a tile.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
