// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStoreConfigurationStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (StoreConfiguration))]
  [Guid(553604818, 20195, 19696, 155, 18, 85, 44, 3, 49, 15, 117)]
  internal interface IStoreConfigurationStatics4
  {
    string GetStoreWebAccountId();

    string GetStoreWebAccountIdForUser(User user);

    void SetEnterpriseStoreWebAccountId(string webAccountId);

    void SetEnterpriseStoreWebAccountIdForUser(User user, string webAccountId);

    string GetEnterpriseStoreWebAccountId();

    string GetEnterpriseStoreWebAccountIdForUser(User user);

    bool ShouldRestrictToEnterpriseStoreOnly();

    bool ShouldRestrictToEnterpriseStoreOnlyForUser(User user);
  }
}
