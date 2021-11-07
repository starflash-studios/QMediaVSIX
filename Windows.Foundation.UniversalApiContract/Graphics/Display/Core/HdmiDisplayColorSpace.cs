// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.HdmiDisplayColorSpace
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  /// <summary>Describes the types of standard color spaces for display monitors.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum HdmiDisplayColorSpace
  {
    /// <summary>Limited RGB; levels are limited to 16-235.</summary>
    RgbLimited,
    /// <summary>Full RGB; levels are in the full range of 0-255.</summary>
    RgbFull,
    /// <summary>The ITU-R Recommendation BT.2020 is the recommended format for ultra-high-definition TV (UHDTV).</summary>
    BT2020,
    /// <summary>The ITU-R Recommendation BT.709 is the recommended format for high-definition TV (HDTV).</summary>
    BT709,
  }
}
