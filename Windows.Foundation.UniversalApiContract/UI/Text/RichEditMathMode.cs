// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.RichEditMathMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Defines constants that specify whether a RichEditBox interprets input as math (MathML ) or text.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public enum RichEditMathMode
  {
    /// <summary>Input is interpreted as text.</summary>
    NoMath,
    /// <summary>Input is interpreted as math.</summary>
    MathOnly,
  }
}
