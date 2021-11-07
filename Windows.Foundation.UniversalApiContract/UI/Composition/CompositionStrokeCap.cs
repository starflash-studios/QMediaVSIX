// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionStrokeCap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Defines constants that specify the shape at the end of a line or segment.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  public enum CompositionStrokeCap
  {
    /// <summary>A cap that does not extend past the last point of the line.</summary>
    Flat,
    /// <summary>Half of a square that has a length equal to the line thickness.</summary>
    Square,
    /// <summary>A semicircle that has a diameter equal to the line thickness.</summary>
    Round,
    /// <summary>An isosceles right triangle whose hypotenuse is equal in length to the thickness of the line.</summary>
    Triangle,
  }
}
