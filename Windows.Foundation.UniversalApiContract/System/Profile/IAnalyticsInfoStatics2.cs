﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IAnalyticsInfoStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [Guid(269944042, 43001, 18130, 171, 148, 1, 104, 101, 175, 219, 37)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (AnalyticsInfo))]
  internal interface IAnalyticsInfoStatics2
  {
    [RemoteAsync]
    IAsyncOperation<IMapView<string, string>> GetSystemPropertiesAsync(
      IIterable<string> attributeNames);
  }
}