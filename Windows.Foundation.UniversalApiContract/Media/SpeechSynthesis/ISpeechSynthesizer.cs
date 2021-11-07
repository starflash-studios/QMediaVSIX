// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.ISpeechSynthesizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3466558582, 38900, 19693, 173, 104, 213, 28, 69, 142, 69, 198)]
  [ExclusiveTo(typeof (SpeechSynthesizer))]
  internal interface ISpeechSynthesizer
  {
    [RemoteAsync]
    IAsyncOperation<SpeechSynthesisStream> SynthesizeTextToStreamAsync(
      string text);

    [RemoteAsync]
    IAsyncOperation<SpeechSynthesisStream> SynthesizeSsmlToStreamAsync(
      string Ssml);

    VoiceInformation Voice { set; get; }
  }
}
