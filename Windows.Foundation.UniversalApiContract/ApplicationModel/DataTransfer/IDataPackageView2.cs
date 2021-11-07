// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackageView2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataPackageView))]
  [Guid(1089256085, 9296, 19485, 182, 180, 237, 69, 70, 61, 238, 156)]
  internal interface IDataPackageView2
  {
    [RemoteAsync]
    IAsyncOperation<Uri> GetApplicationLinkAsync();

    [RemoteAsync]
    IAsyncOperation<Uri> GetWebLinkAsync();
  }
}
