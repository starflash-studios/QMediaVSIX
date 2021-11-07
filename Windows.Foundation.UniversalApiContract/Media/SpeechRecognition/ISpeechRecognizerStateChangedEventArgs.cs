// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizerStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [Guid(1446858505, 47619, 19373, 173, 129, 221, 198, 196, 218, 176, 195)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognizerStateChangedEventArgs))]
  internal interface ISpeechRecognizerStateChangedEventArgs
  {
    SpeechRecognizerState State { get; }
  }
}
