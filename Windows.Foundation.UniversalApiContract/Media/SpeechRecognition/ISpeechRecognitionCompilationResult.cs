// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionCompilationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechRecognitionCompilationResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1082027101, 27335, 19876, 156, 193, 47, 206, 50, 207, 116, 137)]
  internal interface ISpeechRecognitionCompilationResult
  {
    SpeechRecognitionResultStatus Status { get; }
  }
}
