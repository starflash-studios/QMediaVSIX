// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTargetCameraChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides data for the TargetCameraChanged event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MapTargetCameraChangedEventArgs : 
    IMapTargetCameraChangedEventArgs,
    IMapTargetCameraChangedEventArgs2
  {
    /// <summary>Initializes a new instance of the MapTargetCameraChangedEventArgs class.</summary>
    [MethodImpl]
    public extern MapTargetCameraChangedEventArgs();

    /// <summary>Gets the camera position corresponding to the TargetCameraChanged event.</summary>
    /// <returns>The camera position corresponding to the TargetCameraChanged event.</returns>
    public extern MapCamera Camera { [MethodImpl] get; }

    /// <summary>Gets or sets the camera change reason.</summary>
    /// <returns>The reason the camera changed.</returns>
    public extern MapCameraChangeReason ChangeReason { [MethodImpl] get; }
  }
}
