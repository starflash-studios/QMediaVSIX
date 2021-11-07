// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferContentPart
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(3907081815, 55249, 20184, 131, 142, 103, 74, 194, 23, 172, 230)]
  [ExclusiveTo(typeof (BackgroundTransferContentPart))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundTransferContentPart
  {
    void SetHeader(string headerName, string headerValue);

    void SetText(string value);

    void SetFile(IStorageFile value);
  }
}
