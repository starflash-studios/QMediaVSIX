// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.CornerRadius
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Describes the characteristics of a rounded corner, such as can be applied to a Border.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public struct CornerRadius
  {
    /// <summary>The radius of rounding, in pixels, of the upper-left corner of the object where a CornerRadius is applied.</summary>
    public double TopLeft;
    /// <summary>The radius of rounding, in pixels, of the upper-right corner of the object where a CornerRadius is applied.</summary>
    public double TopRight;
    /// <summary>The radius of rounding, in pixels, of the lower-right corner of the object where a CornerRadius is applied.</summary>
    public double BottomRight;
    /// <summary>The radius of rounding, in pixels, of the lower-left corner of the object where a CornerRadius is applied.</summary>
    public double BottomLeft;
  }
}
