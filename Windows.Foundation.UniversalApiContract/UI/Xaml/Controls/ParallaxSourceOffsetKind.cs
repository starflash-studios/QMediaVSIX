// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ParallaxSourceOffsetKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how the source offset values of a ParallaxView are interpreted.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  public enum ParallaxSourceOffsetKind
  {
    /// <summary>The source start/end offset value is interpreted as an absolute value.</summary>
    Absolute,
    /// <summary>The source start/end offset value is added to the auto-computed source offset.</summary>
    Relative,
  }
}
