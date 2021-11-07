// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authorization.AppCapabilityAccess.IAppCapability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authorization.AppCapabilityAccess
{
  [Guid(1279908117, 35370, 17045, 148, 55, 45, 247, 195, 150, 175, 244)]
  [ExclusiveTo(typeof (AppCapability))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IAppCapability
  {
    string CapabilityName { get; }

    User User { get; }

    [RemoteAsync]
    IAsyncOperation<AppCapabilityAccessStatus> RequestAccessAsync();

    AppCapabilityAccessStatus CheckAccess();

    event TypedEventHandler<AppCapability, AppCapabilityAccessChangedEventArgs> AccessChanged;
  }
}
