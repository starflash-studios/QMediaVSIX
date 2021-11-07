﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadySecureStopServiceRequestFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(239373001, 59006, 18766, 159, 73, 98, 133, 67, 140, 118, 207)]
  [ExclusiveTo(typeof (PlayReadySecureStopServiceRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadySecureStopServiceRequestFactory
  {
    PlayReadySecureStopServiceRequest CreateInstance(
      [Range(0, 2147483647)] byte[] publisherCertBytes);

    PlayReadySecureStopServiceRequest CreateInstanceFromSessionID(
      Guid sessionID,
      [Range(0, 2147483647)] byte[] publisherCertBytes);
  }
}