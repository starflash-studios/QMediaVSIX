// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IUploadOperation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (UploadOperation))]
  [Guid(1432455666, 10100, 19958, 159, 165, 32, 159, 43, 251, 18, 247)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUploadOperation2
  {
    BackgroundTransferGroup TransferGroup { get; }
  }
}
