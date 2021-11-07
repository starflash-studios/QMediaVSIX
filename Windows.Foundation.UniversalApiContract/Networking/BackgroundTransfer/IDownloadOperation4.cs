// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IDownloadOperation4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (DownloadOperation))]
  [Guid(215658228, 36079, 16458, 150, 109, 240, 88, 64, 11, 237, 128)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IDownloadOperation4
  {
    void MakeCurrentInTransferGroup();
  }
}
