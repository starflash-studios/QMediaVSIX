// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFrameId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Uniquely identifies a HolographicFrame within its parent HolographicSpace.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public struct HolographicFrameId
  {
    /// <summary>A 64-bit integer value uniquely identifying a **HolographicFrame**.</summary>
    public ulong Value;
  }
}
