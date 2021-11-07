// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataTransferManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(92558451, 27778, 20316, 172, 35, 98, 228, 88, 54, 31, 172)]
  [ExclusiveTo(typeof (DataTransferManager))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IDataTransferManagerStatics3
  {
    [Overload("ShowShareUIWithOptions")]
    void ShowShareUI(ShareUIOptions options);
  }
}
