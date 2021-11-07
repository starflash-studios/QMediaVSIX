// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides data for the ActualCameraChanging event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MapActualCameraChangingEventArgs : 
    IMapActualCameraChangingEventArgs,
    IMapActualCameraChangingEventArgs2
  {
    /// <summary>Initializes a new instance of the MapActualCameraChangingEventArgs class.</summary>
    [MethodImpl]
    public extern MapActualCameraChangingEventArgs();

    /// <summary>Gets the position of the map's camera before it started moving.</summary>
    /// <returns>Gets the position of the map's camera before it started moving.</returns>
    public extern MapCamera Camera { [MethodImpl] get; }

    /// <summary>Indicates the reason the ActualCameraChanging event was triggered.</summary>
    /// <returns>The reason the ActualCameraChanging event was triggered.</returns>
    public extern MapCameraChangeReason ChangeReason { [MethodImpl] get; }
  }
}
