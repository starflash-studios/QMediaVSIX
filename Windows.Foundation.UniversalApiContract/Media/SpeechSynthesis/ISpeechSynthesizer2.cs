// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.ISpeechSynthesizer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2814766258, 17209, 19818, 187, 248, 199, 164, 241, 84, 76, 46)]
  [ExclusiveTo(typeof (SpeechSynthesizer))]
  internal interface ISpeechSynthesizer2
  {
    SpeechSynthesizerOptions Options { get; }
  }
}
