// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.HdmiDisplayPixelEncoding
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  /// <summary>Describes the types of pixel encoding format.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum HdmiDisplayPixelEncoding
  {
    /// <summary>Video signal is separated into the red, green, blue (RGB) components, with no color sub-sampling.</summary>
    Rgb444,
    /// <summary>Video signal is separated into the chroma (Cb and Cr) and luma (Y) components, with no chroma sub-sampling.</summary>
    Ycc444,
    /// <summary>Chroma sub-sampling is done at 4:2:2. The two chroma components are sampled at half the sample rate of the luma component.</summary>
    Ycc422,
    /// <summary>Chroma sub-sampling is done at 4:2:0. Only one chroma component is sampled on per line. This means that the two chroma components take turns to be sampled, so they are sampled on alternate lines at half the sample rate of the luma component.</summary>
    Ycc420,
  }
}
