// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.ISignificantDigitsOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>An interface that gets and sets the option for specifying significant digits.</summary>
  [Guid(491650269, 11587, 20200, 187, 241, 193, 178, 106, 113, 26, 88)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISignificantDigitsOption
  {
    /// <summary>Gets or sets the number of significant digits used in formatting or rounding numbers.</summary>
    /// <returns>The number of significant digits.</returns>
    int SignificantDigits { get; set; }
  }
}
