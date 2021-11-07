// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppUriHandlerRegistration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1869852337, 17769, 23615, 155, 160, 153, 18, 62, 234, 50, 195)]
  [ExclusiveTo(typeof (AppUriHandlerRegistration))]
  internal interface IAppUriHandlerRegistration
  {
    string Name { get; }

    User User { get; }

    [RemoteAsync]
    IAsyncOperation<IVector<AppUriHandlerHost>> GetAppAddedHostsAsync();

    [RemoteAsync]
    IAsyncAction SetAppAddedHostsAsync(IIterable<AppUriHandlerHost> hosts);
  }
}
