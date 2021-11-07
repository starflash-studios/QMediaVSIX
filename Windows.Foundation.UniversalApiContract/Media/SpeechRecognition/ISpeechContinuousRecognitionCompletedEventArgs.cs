// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechContinuousRecognitionCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SpeechContinuousRecognitionCompletedEventArgs))]
  [Guid(3822086587, 58124, 24088, 66, 75, 127, 190, 129, 248, 251, 208)]
  internal interface ISpeechContinuousRecognitionCompletedEventArgs
  {
    SpeechRecognitionResultStatus Status { get; }
  }
}
