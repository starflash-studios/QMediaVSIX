﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2370845932, 39587, 20072, 149, 89, 157, 230, 62, 55, 44, 228)]
  [ExclusiveTo(typeof (AppServiceResponse))]
  internal interface IAppServiceResponse
  {
    ValueSet Message { get; }

    AppServiceResponseStatus Status { get; }
  }
}