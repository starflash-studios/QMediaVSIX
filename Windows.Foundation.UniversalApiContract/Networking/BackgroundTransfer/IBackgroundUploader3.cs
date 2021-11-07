// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploader3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundUploader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3109983289, 23536, 19258, 140, 71, 44, 97, 153, 168, 84, 185)]
  internal interface IBackgroundUploader3
  {
    BackgroundTransferCompletionGroup CompletionGroup { get; }
  }
}
