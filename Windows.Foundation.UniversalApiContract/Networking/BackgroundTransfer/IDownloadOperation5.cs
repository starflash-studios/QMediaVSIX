// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IDownloadOperation5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(2795087983, 21904, 17978, 184, 214, 30, 73, 26, 39, 96, 165)]
  [ExclusiveTo(typeof (DownloadOperation))]
  internal interface IDownloadOperation5
  {
    void SetRequestHeader(string headerName, string headerValue);

    void RemoveRequestHeader(string headerName);
  }
}
