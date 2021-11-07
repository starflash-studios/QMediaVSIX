// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.HandwritingLineHeight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Specifies the handwriting space available when using ink for text input in a text control (when HandwritingView is enabled).</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum HandwritingLineHeight
  {
    /// <summary>Approximately 0.5" of handwriting space per line.</summary>
    Small,
    /// <summary>Approximately 1" of handwriting space per line.</summary>
    Medium,
    /// <summary>Approximately 1.5" of handwriting space per line.</summary>
    Large,
  }
}
