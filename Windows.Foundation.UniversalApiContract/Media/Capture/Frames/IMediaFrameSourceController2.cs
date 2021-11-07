// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSourceController2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MediaFrameSourceController))]
  [Guid(4022640596, 64754, 18947, 180, 228, 172, 150, 40, 115, 155, 238)]
  internal interface IMediaFrameSourceController2
  {
    [RemoteAsync]
    IAsyncOperation<MediaFrameSourceGetPropertyResult> GetPropertyByExtendedIdAsync(
      byte[] extendedPropertyId,
      IReference<uint> maxPropertyValueSize);

    [RemoteAsync]
    IAsyncOperation<MediaFrameSourceSetPropertyStatus> SetPropertyByExtendedIdAsync(
      byte[] extendedPropertyId,
      byte[] propertyValue);
  }
}
