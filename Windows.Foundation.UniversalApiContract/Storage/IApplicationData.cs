// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IApplicationData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3285872567, 46916, 19269, 176, 184, 34, 58, 9, 56, 208, 220)]
  [ExclusiveTo(typeof (ApplicationData))]
  internal interface IApplicationData
  {
    uint Version { get; }

    [RemoteAsync]
    IAsyncAction SetVersionAsync(
      uint desiredVersion,
      ApplicationDataSetVersionHandler handler);

    [RemoteAsync]
    [Overload("ClearAllAsync")]
    IAsyncAction ClearAsync();

    [RemoteAsync]
    [Overload("ClearAsync")]
    IAsyncAction ClearAsync(ApplicationDataLocality locality);

    ApplicationDataContainer LocalSettings { get; }

    ApplicationDataContainer RoamingSettings { get; }

    StorageFolder LocalFolder { get; }

    StorageFolder RoamingFolder { get; }

    StorageFolder TemporaryFolder { get; }

    event TypedEventHandler<ApplicationData, object> DataChanged;

    void SignalDataChanged();

    ulong RoamingStorageQuota { get; }
  }
}
