﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.IPlaybackRateChangeRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(753058847, 15574, 20343, 155, 167, 235, 39, 194, 106, 33, 64)]
  [ExclusiveTo(typeof (PlaybackRateChangeRequestedEventArgs))]
  internal interface IPlaybackRateChangeRequestedEventArgs
  {
    double RequestedPlaybackRate { get; }
  }
}