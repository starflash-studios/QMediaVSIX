// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicCameraViewportParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Graphics.Holographic
{
  /// <summary>Represents per-viewport parameters for rendering holographic content.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HolographicCameraViewportParameters : IHolographicCameraViewportParameters
  {
    /// <summary>Gets screen-space vertices that define the viewport area the user cannot see, given the headset's lens geometry.</summary>
    /// <returns>The hidden area mesh vertices.</returns>
    public extern Vector2[] HiddenAreaMesh { [MethodImpl] get; }

    /// <summary>Gets screen-space vertices that define the viewport area the user can see, given the headset's lens geometry.</summary>
    /// <returns>The visible area mesh vertices.</returns>
    public extern Vector2[] VisibleAreaMesh { [MethodImpl] get; }
  }
}
