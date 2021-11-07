// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapActualCameraChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides data for the ActualCameraChanged event.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class MapActualCameraChangedEventArgs : 
    IMapActualCameraChangedEventArgs,
    IMapActualCameraChangedEventArgs2
  {
    /// <summary>Initializes a new instance of the MapActualCameraChangedEventArgs class.</summary>
    [MethodImpl]
    public extern MapActualCameraChangedEventArgs();

    /// <summary>Gets the current position of the map's camera.</summary>
    /// <returns>The current position of the map's camera.</returns>
    public extern MapCamera Camera { [MethodImpl] get; }

    /// <summary>Indicates the reason the ActualCameraChanged event was triggered.</summary>
    /// <returns>The reason the ActualCameraChanged event was triggered.</returns>
    public extern MapCameraChangeReason ChangeReason { [MethodImpl] get; }
  }
}
