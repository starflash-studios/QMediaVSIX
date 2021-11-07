// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IMediaProcessingTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2593504869, 35410, 19248, 144, 17, 207, 56, 4, 14, 168, 176)]
  [ExclusiveTo(typeof (MediaProcessingTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaProcessingTrigger : IBackgroundTrigger
  {
    [Overload("RequestAsync")]
    [RemoteAsync]
    IAsyncOperation<MediaProcessingTriggerResult> RequestAsync();

    [Overload("RequestAsyncWithArguments")]
    IAsyncOperation<MediaProcessingTriggerResult> RequestAsync(
      ValueSet arguments);
  }
}
