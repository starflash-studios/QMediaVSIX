// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedLineDisplay2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ClaimedLineDisplay))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2736551405, 16885, 20086, 160, 116, 121, 94, 71, 164, 110, 151)]
  internal interface IClaimedLineDisplay2
  {
    [RemoteAsync]
    IAsyncOperation<string> GetStatisticsAsync(IIterable<string> statisticsCategories);

    [RemoteAsync]
    IAsyncOperation<string> CheckHealthAsync(UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    IAsyncOperation<LineDisplayPowerStatus> CheckPowerStatusAsync();

    event TypedEventHandler<ClaimedLineDisplay, LineDisplayStatusUpdatedEventArgs> StatusUpdated;

    IVectorView<Size> SupportedScreenSizesInCharacters { get; }

    Size MaxBitmapSizeInPixels { get; }

    IVectorView<int> SupportedCharacterSets { get; }

    LineDisplayCustomGlyphs CustomGlyphs { get; }

    LineDisplayAttributes GetAttributes();

    [RemoteAsync]
    IAsyncOperation<bool> TryUpdateAttributesAsync(LineDisplayAttributes attributes);

    [RemoteAsync]
    IAsyncOperation<bool> TrySetDescriptorAsync(
      uint descriptor,
      LineDisplayDescriptorState descriptorState);

    [RemoteAsync]
    IAsyncOperation<bool> TryClearDescriptorsAsync();

    [RemoteAsync]
    IAsyncOperation<LineDisplayWindow> TryCreateWindowAsync(
      Rect viewport,
      Size windowSize);

    [RemoteAsync]
    [Overload("TryStoreStorageFileBitmapAsync")]
    IAsyncOperation<LineDisplayStoredBitmap> TryStoreStorageFileBitmapAsync(
      StorageFile bitmap);

    [Overload("TryStoreStorageFileBitmapWithAlignmentAsync")]
    [RemoteAsync]
    IAsyncOperation<LineDisplayStoredBitmap> TryStoreStorageFileBitmapAsync(
      StorageFile bitmap,
      LineDisplayHorizontalAlignment horizontalAlignment,
      LineDisplayVerticalAlignment verticalAlignment);

    [Overload("TryStoreStorageFileBitmapWithAlignmentAndWidthAsync")]
    [RemoteAsync]
    IAsyncOperation<LineDisplayStoredBitmap> TryStoreStorageFileBitmapAsync(
      StorageFile bitmap,
      LineDisplayHorizontalAlignment horizontalAlignment,
      LineDisplayVerticalAlignment verticalAlignment,
      int widthInPixels);
  }
}
