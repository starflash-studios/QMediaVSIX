// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IQueryOptionsWithProviderFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ExclusiveTo(typeof (QueryOptions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1537019942, 5572, 17629, 184, 154, 71, 165, 155, 125, 124, 79)]
  internal interface IQueryOptionsWithProviderFilter
  {
    IVector<string> StorageProviderIdFilter { get; }
  }
}
