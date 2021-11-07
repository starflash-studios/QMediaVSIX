// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSource5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.BackgroundTransfer;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (MediaSource))]
  [Guid(857350830, 60718, 18978, 148, 200, 183, 67, 169, 43, 48, 34)]
  internal interface IMediaSource5
  {
    DownloadOperation DownloadOperation { get; }
  }
}
