// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.WhiteBalanceGain
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Represents the red, green, and blue values of a white balance gain setting.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct WhiteBalanceGain
  {
    /// <summary>The red value of a white balance gain setting.</summary>
    public double R;
    /// <summary>The green value of a white balance gain setting.</summary>
    public double G;
    /// <summary>The blue value of a white balance gain setting.</summary>
    public double B;
  }
}
