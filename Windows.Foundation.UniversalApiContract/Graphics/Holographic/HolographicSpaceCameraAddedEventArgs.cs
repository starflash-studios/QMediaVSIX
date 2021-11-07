// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicSpaceCameraAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Provides data for the HolographicSpace.CameraAdded event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class HolographicSpaceCameraAddedEventArgs : IHolographicSpaceCameraAddedEventArgs
  {
    /// <summary>Gets the HolographicCamera that is being added. The app should set up any per-camera resources it may need for this camera.</summary>
    /// <returns>The camera.</returns>
    public extern HolographicCamera Camera { [MethodImpl] get; }

    /// <summary>Requests that addition of this camera be delayed until the deferral is completed.</summary>
    /// <returns>The deferral.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
