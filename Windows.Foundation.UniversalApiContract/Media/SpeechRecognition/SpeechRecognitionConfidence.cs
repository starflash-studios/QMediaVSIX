// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionConfidence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Specifies confidence levels that indicate how accurately a spoken phrase was matched to a phrase in an active constraint.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SpeechRecognitionConfidence
  {
    /// <summary>The confidence level is high.</summary>
    High,
    /// <summary>The confidence level is medium.</summary>
    Medium,
    /// <summary>The confidence level is low.</summary>
    Low,
    /// <summary>The spoken phrase was not matched to any phrase in any active grammar.</summary>
    Rejected,
  }
}
