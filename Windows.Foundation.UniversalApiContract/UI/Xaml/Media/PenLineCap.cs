// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PenLineCap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Describes the shape at the end of a line or segment.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum PenLineCap
  {
    /// <summary>A cap that does not extend past the last point of the line. Comparable to no line cap.</summary>
    Flat,
    /// <summary>A rectangle that has a height equal to the line thickness and a length equal to half the line thickness.</summary>
    Square,
    /// <summary>A semicircle that has a diameter equal to the line thickness.</summary>
    Round,
    /// <summary>An isosceles right triangle whose base length is equal to the thickness of the line.</summary>
    Triangle,
  }
}
