﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IAudioEncodingProperties2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (AudioEncodingProperties))]
  [Guid(3294450906, 32957, 19491, 128, 213, 114, 212, 161, 129, 232, 148)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IAudioEncodingProperties2
  {
    bool IsSpatial { get; }
  }
}