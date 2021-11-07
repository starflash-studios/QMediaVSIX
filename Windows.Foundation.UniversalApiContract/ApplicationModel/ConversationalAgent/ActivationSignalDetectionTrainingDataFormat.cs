// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionTrainingDataFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Specifies the activation signal training data formats supported by the ActivationSignalDetector for the digital assistant.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public enum ActivationSignalDetectionTrainingDataFormat
  {
    /// <summary>Training data is voice audio in 8-bit 8kHz mono.</summary>
    Voice8kHz8BitMono,
    /// <summary>Training data is voice audio in 16-bit 8kHz mono.</summary>
    Voice8kHz16BitMono,
    /// <summary>Training data is voice audio in 8-bit 16kHz mono.</summary>
    Voice16kHz8BitMono,
    /// <summary>Training data is voice audio in 16-bit 16kHz mono.</summary>
    Voice16kHz16BitMono,
    /// <summary>Training data is voice audio is defined by an OEM.</summary>
    VoiceOEMDefined,
    /// <summary>Training data is generic audio in 8-bit 44kHz mono.</summary>
    Audio44kHz8BitMono,
    /// <summary>Training data is generic audio in 16-bit 44kHz mono.</summary>
    Audio44kHz16BitMono,
    /// <summary>Training data is generic audio in 8-bit 48kHz mono.</summary>
    Audio48kHz8BitMono,
    /// <summary>Training data is generic audio in 16-bit 48kHz mono.</summary>
    Audio48kHz16BitMono,
    /// <summary>Training data is generic audio in a format specified by a hardware provider.</summary>
    AudioOEMDefined,
    /// <summary>Training data is in a format specified by a hardware provider.</summary>
    OtherOEMDefined,
  }
}
