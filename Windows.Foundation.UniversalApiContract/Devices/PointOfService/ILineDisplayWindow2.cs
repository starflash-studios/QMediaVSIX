// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayWindow2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (LineDisplayWindow))]
  [Guid(2841436902, 48600, 17253, 142, 17, 222, 148, 222, 141, 255, 2)]
  internal interface ILineDisplayWindow2
  {
    LineDisplayCursor Cursor { get; }

    LineDisplayMarquee Marquee { get; }

    [RemoteAsync]
    IAsyncOperation<uint> ReadCharacterAtCursorAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryDisplayStoredBitmapAtCursorAsync(
      LineDisplayStoredBitmap bitmap);

    [Overload("TryDisplayStorageFileBitmapAtCursorAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryDisplayStorageFileBitmapAtCursorAsync(StorageFile bitmap);

    [RemoteAsync]
    [Overload("TryDisplayStorageFileBitmapAtCursorWithAlignmentAsync")]
    IAsyncOperation<bool> TryDisplayStorageFileBitmapAtCursorAsync(
      StorageFile bitmap,
      LineDisplayHorizontalAlignment horizontalAlignment,
      LineDisplayVerticalAlignment verticalAlignment);

    [Overload("TryDisplayStorageFileBitmapAtCursorWithAlignmentAndWidthAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryDisplayStorageFileBitmapAtCursorAsync(
      StorageFile bitmap,
      LineDisplayHorizontalAlignment horizontalAlignment,
      LineDisplayVerticalAlignment verticalAlignment,
      int widthInPixels);

    [RemoteAsync]
    [Overload("TryDisplayStorageFileBitmapAtPointAsync")]
    IAsyncOperation<bool> TryDisplayStorageFileBitmapAtPointAsync(
      StorageFile bitmap,
      Point offsetInPixels);

    [Overload("TryDisplayStorageFileBitmapAtPointWithWidthAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryDisplayStorageFileBitmapAtPointAsync(
      StorageFile bitmap,
      Point offsetInPixels,
      int widthInPixels);
  }
}
