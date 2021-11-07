// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicSpaceCameraRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Provides data for the HolographicSpace.CameraRemoved event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class HolographicSpaceCameraRemovedEventArgs : 
    IHolographicSpaceCameraRemovedEventArgs
  {
    /// <summary>Gets the HolographicCamera that was removed. The app should dispose of any per-camera resources it may have set up for this camera.</summary>
    /// <returns>The camera.</returns>
    public extern HolographicCamera Camera { [MethodImpl] get; }
  }
}
