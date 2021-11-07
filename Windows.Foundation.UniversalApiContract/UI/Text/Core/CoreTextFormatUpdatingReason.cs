// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextFormatUpdatingReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Defines constants that specify the set of state applied during text composition.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CoreTextFormatUpdatingReason
  {
    /// <summary>The reason for the format updating is unknown.</summary>
    None,
    /// <summary>The text is an unconverted composition string.</summary>
    CompositionUnconverted,
    /// <summary>The text is a converted composition string.</summary>
    CompositionConverted,
    /// <summary>The user has made a selection in the composition string and the text has been converted.</summary>
    CompositionTargetUnconverted,
    /// <summary>The user made a selection in the composition string, but the text has not yet been converted.</summary>
    CompositionTargetConverted,
  }
}
