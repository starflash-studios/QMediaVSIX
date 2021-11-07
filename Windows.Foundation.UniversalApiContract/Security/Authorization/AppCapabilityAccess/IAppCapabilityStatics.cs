// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authorization.AppCapabilityAccess.IAppCapabilityStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authorization.AppCapabilityAccess
{
  [Guid(2083864106, 18158, 17637, 175, 61, 106, 211, 252, 73, 189, 34)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (AppCapability))]
  internal interface IAppCapabilityStatics
  {
    [RemoteAsync]
    IAsyncOperation<IMapView<string, AppCapabilityAccessStatus>> RequestAccessForCapabilitiesAsync(
      IIterable<string> capabilityNames);

    [RemoteAsync]
    IAsyncOperation<IMapView<string, AppCapabilityAccessStatus>> RequestAccessForCapabilitiesForUserAsync(
      User user,
      IIterable<string> capabilityNames);

    AppCapability Create(string capabilityName);

    AppCapability CreateWithProcessIdForUser(
      User user,
      string capabilityName,
      uint pid);
  }
}
