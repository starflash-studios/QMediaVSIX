﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameExposureCompensationCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (FrameExposureCompensationCapabilities))]
  [Guid(3112740899, 32869, 16878, 176, 79, 114, 34, 101, 149, 69, 0)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameExposureCompensationCapabilities
  {
    bool Supported { get; }

    float Min { get; }

    float Max { get; }

    float Step { get; }
  }
}