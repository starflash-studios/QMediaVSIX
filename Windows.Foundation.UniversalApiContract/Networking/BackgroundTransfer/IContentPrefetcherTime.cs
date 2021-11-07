// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IContentPrefetcherTime
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentPrefetcher))]
  [Guid(3814849800, 4906, 20446, 167, 204, 252, 176, 230, 101, 35, 175)]
  internal interface IContentPrefetcherTime
  {
    IReference<DateTime> LastSuccessfulPrefetchTime { get; }
  }
}
