﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameFlashCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameFlashCapabilities))]
  [Guid(3146989986, 24254, 20322, 130, 35, 14, 43, 5, 191, 187, 208)]
  internal interface IFrameFlashCapabilities
  {
    bool Supported { get; }

    bool RedEyeReductionSupported { get; }

    bool PowerSupported { get; }
  }
}