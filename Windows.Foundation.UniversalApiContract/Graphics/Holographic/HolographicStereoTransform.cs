// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicStereoTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Graphics.Holographic
{
  /// <summary>Contains view or projection transforms for stereo rendering. One transform is for the left display, and the other is for the right display.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public struct HolographicStereoTransform
  {
    /// <summary>View or projection transform for the left display of a stereo device.</summary>
    public Matrix4x4 Left;
    /// <summary>View or projection transform for the right display of a stereo device.</summary>
    public Matrix4x4 Right;
  }
}
