// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundDownloaderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(646147108, 55454, 18164, 162, 154, 79, 77, 79, 20, 65, 85)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BackgroundDownloader))]
  internal interface IBackgroundDownloaderFactory
  {
    BackgroundDownloader CreateWithCompletionGroup(
      BackgroundTransferCompletionGroup completionGroup);
  }
}
