// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IVoiceCommandActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.SpeechRecognition;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Represents the activated event object that contains the event info when the app is launched through a voice command.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2878528765, 36163, 19942, 151, 117, 32, 112, 75, 88, 27, 0)]
  public interface IVoiceCommandActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the SpeechRecognitionResult object representing the voice command that activated the app.</summary>
    /// <returns>The SpeechRecognitionResult object representing the voice commands that activated the app.</returns>
    SpeechRecognitionResult Result { get; }
  }
}
