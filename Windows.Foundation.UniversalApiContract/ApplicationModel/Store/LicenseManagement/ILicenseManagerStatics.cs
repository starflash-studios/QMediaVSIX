// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.ILicenseManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  [Guid(3047963360, 55879, 20256, 154, 35, 9, 24, 44, 148, 118, 255)]
  [ExclusiveTo(typeof (LicenseManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ILicenseManagerStatics
  {
    [RemoteAsync]
    IAsyncAction AddLicenseAsync(IBuffer license);

    [RemoteAsync]
    IAsyncOperation<LicenseSatisfactionResult> GetSatisfactionInfosAsync(
      IIterable<string> contentIds,
      IIterable<string> keyIds);
  }
}
