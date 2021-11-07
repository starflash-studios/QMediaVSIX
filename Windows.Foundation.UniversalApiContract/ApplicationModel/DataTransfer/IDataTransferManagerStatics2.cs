// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataTransferManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataTransferManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3310273260, 40855, 19811, 152, 104, 57, 94, 39, 26, 216, 245)]
  internal interface IDataTransferManagerStatics2
  {
    bool IsSupported();
  }
}
