﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.ISpeechSynthesizerOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2699180145, 52285, 17353, 145, 177, 238, 24, 83, 36, 216, 61)]
  [ExclusiveTo(typeof (SpeechSynthesizerOptions))]
  internal interface ISpeechSynthesizerOptions
  {
    bool IncludeWordBoundaryMetadata { get; set; }

    bool IncludeSentenceBoundaryMetadata { get; set; }
  }
}