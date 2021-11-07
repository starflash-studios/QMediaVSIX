// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.HdmiDisplayHdrOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  /// <summary>Defines constants that specify the high dynamic range (HDR) options of a connected device such as a TV or a monitor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum HdmiDisplayHdrOption
  {
    /// <summary>Specifies no option.</summary>
    None,
    /// <summary>Specifies a standard dynamic range (SDR) electro-optical transfer function (EOTF).</summary>
    EotfSdr,
    /// <summary>Specifies an SMPTE ST 2084 electro-optical transfer function (EOTF).</summary>
    Eotf2084,
    /// <summary>Specifies the low-latency profile for Dolby Vision.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] DolbyVisionLowLatency,
  }
}
