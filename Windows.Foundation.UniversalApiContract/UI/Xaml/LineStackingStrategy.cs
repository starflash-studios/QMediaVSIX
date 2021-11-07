// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.LineStackingStrategy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Describes the mechanism by which a line box is determined for each line.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum LineStackingStrategy
  {
    /// <summary>The stack height is the minimum of the extended block progression dimension (height) of all the inline elements when properly aligned and the LineHeight value, if specified.</summary>
    MaxHeight,
    /// <summary>The stack height is determined by the block element's LineHeight property value.</summary>
    BlockLineHeight,
    /// <summary>The stack height is determined by adding LineHeight to the baseline of the previous line.</summary>
    BaselineToBaseline,
  }
}
