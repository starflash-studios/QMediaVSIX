﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaProcessingTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(3951387820, 41809, 20302, 180, 240, 155, 242, 64, 137, 147, 219)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaProcessingTriggerDetails))]
  internal interface IMediaProcessingTriggerDetails
  {
    ValueSet Arguments { get; }
  }
}