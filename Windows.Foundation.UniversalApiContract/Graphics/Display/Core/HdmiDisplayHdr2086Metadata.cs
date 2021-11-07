// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.HdmiDisplayHdr2086Metadata
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  /// <summary>Describes the 10 bit display metadata which is usually used for video. This is used to adjust the output to best match a display's capabilities.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public struct HdmiDisplayHdr2086Metadata
  {
    /// <summary>The X chromaticity coordinate of the red value.</summary>
    public ushort RedPrimaryX;
    /// <summary>The Y chromaticity coordinate of the red value.</summary>
    public ushort RedPrimaryY;
    /// <summary>The X chromaticity coordinate of the green value.</summary>
    public ushort GreenPrimaryX;
    /// <summary>The Y chromaticity coordinate of the green value.</summary>
    public ushort GreenPrimaryY;
    /// <summary>The X chromaticity coordinate of the blue value.</summary>
    public ushort BluePrimaryX;
    /// <summary>The Y chromaticity coordinate of the blue value.</summary>
    public ushort BluePrimaryY;
    /// <summary>The X chromaticity coordinate of the white point.</summary>
    public ushort WhitePointX;
    /// <summary>The Y chromaticity coordinate of the white point.</summary>
    public ushort WhitePointY;
    /// <summary>The maximum number of nits of the display used to master the content. Units are 0.0001 nit, so if the value is 1 nit, the value should be 10,000.</summary>
    public ushort MaxMasteringLuminance;
    /// <summary>The minimum number of nits (in units of 0.00001 nit) of the display used to master the content.</summary>
    public ushort MinMasteringLuminance;
    /// <summary>The maximum nit value (in units of 0.00001 nit) used anywhere in the content.</summary>
    public ushort MaxContentLightLevel;
    /// <summary>The per-frame average of the maximum nit values (in units of 0.00001 nit).</summary>
    public ushort MaxFrameAverageLightLevel;
  }
}
