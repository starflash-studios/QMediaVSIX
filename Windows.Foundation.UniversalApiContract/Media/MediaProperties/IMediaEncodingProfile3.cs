﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingProfile3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3127819912, 30064, 20073, 172, 207, 86, 17, 173, 1, 95, 136)]
  [ExclusiveTo(typeof (MediaEncodingProfile))]
  internal interface IMediaEncodingProfile3
  {
    void SetTimedMetadataTracks(IIterable<TimedMetadataStreamDescriptor> value);

    IVector<TimedMetadataStreamDescriptor> GetTimedMetadataTracks();
  }
}