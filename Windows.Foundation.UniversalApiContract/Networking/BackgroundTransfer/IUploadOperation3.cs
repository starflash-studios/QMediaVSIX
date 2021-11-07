// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IUploadOperation3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (UploadOperation))]
  [Guid(1120480419, 56889, 17734, 188, 98, 55, 116, 180, 41, 77, 227)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IUploadOperation3
  {
    void MakeCurrentInTransferGroup();
  }
}
