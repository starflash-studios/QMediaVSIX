// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognizerUIOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Specifies the UI settings for the SpeechRecognizer.RecognizeWithUIAsync method.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SpeechRecognizerUIOptions : ISpeechRecognizerUIOptions
  {
    /// <summary>Gets or sets the example text shown on the **Listening** screen.</summary>
    /// <returns>The example text that is shown on the **Listening** screen.</returns>
    public extern string ExampleText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the heading text that is displayed on the **Listening** screen. The default is "Listening...".</summary>
    /// <returns>The heading text. A custom string should clearly describe the kind of info expected by the app and is limited to two lines in length.</returns>
    public extern string AudiblePrompt { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the recognized text is spoken back to the user on the **Heard you say** screen.</summary>
    /// <returns>True if the recognized text is spoken back to the user. Otherwise, false. The default is true.</returns>
    public extern bool IsReadBackEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether a **Heard you say** screen is shown to the user after speech recognition is completed.</summary>
    /// <returns>True if a **Heard you say** screen is shown. Otherwise, false. The default is true.</returns>
    public extern bool ShowConfirmation { [MethodImpl] get; [MethodImpl] set; }
  }
}
