// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaBindingEventArgs3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.BackgroundTransfer;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaBindingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(4176168798, 6590, 17660, 165, 237, 122, 186, 49, 80, 55, 249)]
  internal interface IMediaBindingEventArgs3
  {
    void SetDownloadOperation(DownloadOperation downloadOperation);
  }
}
