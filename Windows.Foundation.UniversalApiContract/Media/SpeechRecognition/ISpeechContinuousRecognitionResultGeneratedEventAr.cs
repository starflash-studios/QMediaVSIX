﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechContinuousRecognitionResultGeneratedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechContinuousRecognitionResultGeneratedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(420027934, 28286, 23110, 64, 251, 118, 89, 79, 120, 101, 4)]
  internal interface ISpeechContinuousRecognitionResultGeneratedEventArgs
  {
    SpeechRecognitionResult Result { get; }
  }
}