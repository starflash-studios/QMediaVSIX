// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFramePrediction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception;

namespace Windows.Graphics.Holographic
{
  /// <summary>Represents the poses for each holographic camera at the time that they're predicted to be displayed.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HolographicFramePrediction : IHolographicFramePrediction
  {
    /// <summary>Gets the camera poses that correspond with the time specified by Timestamp.</summary>
    /// <returns>The camera poses.</returns>
    public extern IVectorView<HolographicCameraPose> CameraPoses { [MethodImpl] get; }

    /// <summary>Gets the time when the camera poses are predicted to be displayed.</summary>
    /// <returns>The timestamp.</returns>
    public extern PerceptionTimestamp Timestamp { [MethodImpl] get; }
  }
}
