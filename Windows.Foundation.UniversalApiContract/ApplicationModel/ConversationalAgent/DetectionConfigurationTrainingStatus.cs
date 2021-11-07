// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.DetectionConfigurationTrainingStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Specifies the voice training data states recognized by the ActivationSignalDetector for the digital assistant.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public enum DetectionConfigurationTrainingStatus
  {
    /// <summary>Signal detection training was successful.</summary>
    Success,
    /// <summary>Training data format is not recognized by the signal detector.</summary>
    FormatNotSupported,
    /// <summary>Training data cannot be processed by the signal detector due to user speaking too quietly.</summary>
    VoiceTooQuiet,
    /// <summary>Training data cannot be processed by the signal detector due to user speaking too loudly.</summary>
    VoiceTooLoud,
    /// <summary>Training data cannot be processed by the signal detector due to user speaking too fast.</summary>
    VoiceTooFast,
    /// <summary>Training data cannot be processed by the signal detector due to user speaking too slowly.</summary>
    VoiceTooSlow,
    /// <summary>Training data cannot be processed by the signal detector due to poor quality of speech input.</summary>
    VoiceQualityProblem,
    /// <summary>An internal error, unrelated to the input data format, was encountered during signal detection training.</summary>
    TrainingSystemInternalError,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 851968)] TrainingTimedOut,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 851968)] ConfigurationNotFound,
  }
}
