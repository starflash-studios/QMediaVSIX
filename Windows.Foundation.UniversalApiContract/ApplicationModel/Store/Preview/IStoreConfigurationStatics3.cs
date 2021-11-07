// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStoreConfigurationStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview
{
  [ExclusiveTo(typeof (StoreConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1833301372, 61764, 19637, 157, 63, 78, 176, 94, 48, 182, 211)]
  internal interface IStoreConfigurationStatics3
  {
    bool HasStoreWebAccount();

    bool HasStoreWebAccountForUser(User user);

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamReference> GetStoreLogDataAsync(
      StoreLogOptions options);

    void SetStoreWebAccountIdForUser(User user, string webAccountId);

    bool IsStoreWebAccountIdForUser(User user, string webAccountId);

    IReference<uint> GetPurchasePromptingPolicyForUser(User user);

    void SetPurchasePromptingPolicyForUser(User user, IReference<uint> value);
  }
}
