﻿// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextPredictionGeneratorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Guid(1918350358, 35746, 18257, 157, 48, 157, 133, 67, 86, 83, 162)]
  [ExclusiveTo(typeof (TextPredictionGenerator))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITextPredictionGeneratorFactory
  {
    TextPredictionGenerator Create(string languageTag);
  }
}