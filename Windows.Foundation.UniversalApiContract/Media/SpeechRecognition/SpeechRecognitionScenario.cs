// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionScenario
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Specifies the scenario used to optimize speech recognition for a web-service constraint (created through a SpeechRecognitionTopicConstraint object).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SpeechRecognitionScenario
  {
    /// <summary>A grammar constraint optimized for web search recognition scenarios.</summary>
    WebSearch,
    /// <summary>A gramar constraint optimized for continuous recognition scenarios.</summary>
    Dictation,
    /// <summary>A grammar constraint optimized for form input recognition scenarios.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] FormFilling,
  }
}
