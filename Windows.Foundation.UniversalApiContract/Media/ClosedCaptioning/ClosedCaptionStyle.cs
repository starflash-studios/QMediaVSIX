// Decompiled with JetBrains decompiler
// Type: Windows.Media.ClosedCaptioning.ClosedCaptionStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ClosedCaptioning
{
  /// <summary>Specifies the style of closed caption text.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ClosedCaptionStyle
  {
    /// <summary>The default style.</summary>
    Default,
    /// <summary>Monospaced with serifs.</summary>
    MonospacedWithSerifs,
    /// <summary>Proportional with serifs.</summary>
    ProportionalWithSerifs,
    /// <summary>Monospaced without serifs</summary>
    MonospacedWithoutSerifs,
    /// <summary>Proportional without serifs.</summary>
    ProportionalWithoutSerifs,
    /// <summary>Casual.</summary>
    Casual,
    /// <summary>Cursive.</summary>
    Cursive,
    /// <summary>Small capitals.</summary>
    SmallCapitals,
  }
}
