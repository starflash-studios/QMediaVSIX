// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicAdapterId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Represents the graphics adapter used for rendering holographic content. Matches the Win32 locally unique identifier (LUID) type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public struct HolographicAdapterId
  {
    /// <summary>The LowPart of the LUID struct.</summary>
    public uint LowPart;
    /// <summary>The HighPart of the LUID struct.</summary>
    public int HighPart;
  }
}
