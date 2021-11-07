// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploaderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundUploader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1935803335, 4327, 18592, 172, 60, 26, 199, 16, 149, 236, 87)]
  internal interface IBackgroundUploaderFactory
  {
    BackgroundUploader CreateWithCompletionGroup(
      BackgroundTransferCompletionGroup completionGroup);
  }
}
