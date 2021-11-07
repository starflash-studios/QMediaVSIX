// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayMarquee
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2748530238, 62570, 19322, 188, 33, 83, 235, 59, 87, 248, 180)]
  [ExclusiveTo(typeof (LineDisplayMarquee))]
  internal interface ILineDisplayMarquee
  {
    LineDisplayMarqueeFormat Format { get; set; }

    TimeSpan RepeatWaitInterval { get; set; }

    TimeSpan ScrollWaitInterval { get; set; }

    [RemoteAsync]
    IAsyncOperation<bool> TryStartScrollingAsync(LineDisplayScrollDirection direction);

    [RemoteAsync]
    IAsyncOperation<bool> TryStopScrollingAsync();
  }
}
