// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedLineDisplay
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents a claimed line display device.</summary>
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IClaimedLineDisplayStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class ClaimedLineDisplay : 
    IClaimedLineDisplay,
    IClaimedLineDisplay2,
    IClaimedLineDisplay3,
    IClosable
  {
    /// <summary>Gets the DeviceInformation.Id of the line display.</summary>
    /// <returns>The DeviceInformation.Id of the line display.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the capabilities of the claimed line display.</summary>
    /// <returns>The capabilities of the line display.</returns>
    public extern LineDisplayCapabilities Capabilities { [MethodImpl] get; }

    /// <summary>Gets the physical device name.</summary>
    /// <returns>The physical device name given by the UnifiedPOS specification.</returns>
    public extern string PhysicalDeviceName { [MethodImpl] get; }

    /// <summary>Gets the physical device description.</summary>
    /// <returns>The physical device description given by the UnifiedPOS specification.</returns>
    public extern string PhysicalDeviceDescription { [MethodImpl] get; }

    /// <summary>Gets the device control description of the line display.</summary>
    /// <returns>The control description of the line display.</returns>
    public extern string DeviceControlDescription { [MethodImpl] get; }

    /// <summary>Gets the device control version number of the line display.</summary>
    /// <returns>The UnifiedPOS control version number of the line display.</returns>
    public extern string DeviceControlVersion { [MethodImpl] get; }

    /// <summary>Gets the service version number of the line display.</summary>
    /// <returns>The service version number.</returns>
    public extern string DeviceServiceVersion { [MethodImpl] get; }

    /// <summary>Gets the default device window of the line display.</summary>
    /// <returns>The default device window, covering the entire screen area.</returns>
    public extern LineDisplayWindow DefaultWindow { [MethodImpl] get; }

    /// <summary>Retains an app's claim on a line display device after it has been claimed by another app with LineDisplay.ClaimAsync.</summary>
    [MethodImpl]
    public extern void RetainDevice();

    /// <summary>Occurs when a claimed line display claimed is claimed by another app with LineDisplay.ClaimAsync.</summary>
    public extern event TypedEventHandler<ClaimedLineDisplay, object> ReleaseDeviceRequested;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetStatisticsAsync(
      IIterable<string> statisticsCategories);

    /// <summary>Gets the device's health state asynchronously.</summary>
    /// <param name="level">The specified health check level.</param>
    /// <returns>This value is intended to be reflected in the app interface immediately so the user of the app can interpret it. For example, it will return “OK” as the health string if the device state is good.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> CheckHealthAsync(
      UnifiedPosHealthCheckLevel level);

    /// <summary>Gets the current power status of the device.</summary>
    /// <returns>The current power status of the device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<LineDisplayPowerStatus> CheckPowerStatusAsync();

    /// <summary>Notifies the application that there is a change in the power status of the line display.</summary>
    public extern event TypedEventHandler<ClaimedLineDisplay, LineDisplayStatusUpdatedEventArgs> StatusUpdated;

    /// <summary>Gets the screen sizes supported by the line display.</summary>
    /// <returns>A list containting the sizes that the device supports. Each size is represented as a pair of rows and columns.</returns>
    public extern IVectorView<Size> SupportedScreenSizesInCharacters { [MethodImpl] get; }

    /// <summary>Gets the maximum bitmap size.</summary>
    /// <returns>The maximum bitmap size in pixels.</returns>
    public extern Size MaxBitmapSizeInPixels { [MethodImpl] get; }

    /// <summary>Gets the character sets supported by the line display.</summary>
    /// <returns>The character set numbers supported.</returns>
    public extern IVectorView<int> SupportedCharacterSets { [MethodImpl] get; }

    /// <summary>Gets the line display's custom glyph list, if the feature is supported.</summary>
    /// <returns>The line display's LineDisplayCustomGlyphs object.</returns>
    public extern LineDisplayCustomGlyphs CustomGlyphs { [MethodImpl] get; }

    /// <summary>Gets the attributes of the line display.</summary>
    /// <returns>The attributes of the line display.</returns>
    [MethodImpl]
    public extern LineDisplayAttributes GetAttributes();

    /// <summary>Updates the device attributes.</summary>
    /// <param name="attributes">The updated attributes to be applied to the device.</param>
    /// <returns>Returns True if the attributes were successfully updated; otherwise, False.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryUpdateAttributesAsync(
      LineDisplayAttributes attributes);

    /// <summary>Attempts to asynchronously set a descriptor using the specified attribute.</summary>
    /// <param name="descriptor">The descriptor to be set. Must have a value between 0 and LineDisplayCapabilities.SupportedDescriptors - 1.</param>
    /// <param name="descriptorState">The state to give to the descriptor.</param>
    /// <returns>Returns True if the descriptor was set successfully; otherwise, False.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetDescriptorAsync(
      uint descriptor,
      LineDisplayDescriptorState descriptorState);

    /// <summary>Attempts to asynchronously clear all descriptions.</summary>
    /// <returns>Returns True if all descriptors are successfully cleared; otherwise, False.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryClearDescriptorsAsync();

    /// <summary>Attempts to asynchronously create a LineDisplayWindow.</summary>
    /// <param name="viewport">The viewport’s origin device row, origin device column, width in rows and height in columns.</param>
    /// <param name="windowSize">The numbers of rows and the number of columns in the window.</param>
    /// <returns>A new LineDisplayWindow object, representing a new window for the device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<LineDisplayWindow> TryCreateWindowAsync(
      Rect viewport,
      Size windowSize);

    /// <summary>Attempts to asynchronously store a bitmap image from a StorageFile for later display on the line display device.</summary>
    /// <param name="bitmap">A StorageFile that represents a local bitmap file. All line displays support black and white uncompressed Windows bitmaps. Check device specifications for other supported formats.</param>
    /// <returns>True if the bitmap is stored successfully, False if a failure occurs.</returns>
    [RemoteAsync]
    [Overload("TryStoreStorageFileBitmapAsync")]
    [MethodImpl]
    public extern IAsyncOperation<LineDisplayStoredBitmap> TryStoreStorageFileBitmapAsync(
      StorageFile bitmap);

    /// <summary>Attempts to asynchronously store a bitmap image from a StorageFile for later display on the line display device.</summary>
    /// <param name="bitmap">A StorageFile that represents a local bitmap file. All line displays support black and white uncompressed Windows bitmaps. Check device specifications for other supported formats.</param>
    /// <param name="horizontalAlignment">Determines how the bitmap will be horizontally aligned relative to its originating character cell.</param>
    /// <param name="verticalAlignment">Determines how the bitmap will be vertically aligned relative to its originating character cell.</param>
    /// <returns>True if the bitmap is stored successfully, False if a failure occurs.</returns>
    [RemoteAsync]
    [Overload("TryStoreStorageFileBitmapWithAlignmentAsync")]
    [MethodImpl]
    public extern IAsyncOperation<LineDisplayStoredBitmap> TryStoreStorageFileBitmapAsync(
      StorageFile bitmap,
      LineDisplayHorizontalAlignment horizontalAlignment,
      LineDisplayVerticalAlignment verticalAlignment);

    /// <summary>Attempts to asynchronously store a bitmap image from a StorageFile for later display on the line display device.</summary>
    /// <param name="bitmap">A StorageFile that represents a local bitmap file. All line displays support black and white uncompressed Windows bitmaps. Check device specifications for other supported formats.</param>
    /// <param name="horizontalAlignment">Determines how the bitmap will be horizontally aligned relative to its originating character cell.</param>
    /// <param name="verticalAlignment">Determines how the bitmap will be vertically aligned relative to its originating character cell.</param>
    /// <param name="widthInPixels">The displayed bitmap width in pixels, if different from the original bitmap width. Height will be calculated proportionally.</param>
    /// <returns>True if the bitmap is stored successfully, False if a failure occurs.</returns>
    [RemoteAsync]
    [Overload("TryStoreStorageFileBitmapWithAlignmentAndWidthAsync")]
    [MethodImpl]
    public extern IAsyncOperation<LineDisplayStoredBitmap> TryStoreStorageFileBitmapAsync(
      StorageFile bitmap,
      LineDisplayHorizontalAlignment horizontalAlignment,
      LineDisplayVerticalAlignment verticalAlignment,
      int widthInPixels);

    /// <summary>Event that is raised when the **ClaimedLineDisplay** is closed.</summary>
    public extern event TypedEventHandler<ClaimedLineDisplay, ClaimedLineDisplayClosedEventArgs> Closed;

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a LineDisplay object from the DeviceInformation.Id.</summary>
    /// <param name="deviceId">The DeviceInformation.Id that identifies a specific line display, which can be retrieved from the DeviceId property.</param>
    /// <returns>The line display specified by the unique device identifier. Returns a null object in the following cases:</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ClaimedLineDisplay> FromIdAsync(
      string deviceId);

    /// <summary>Gets an Advanced Query Syntax (AQS) string that you can use to list the available line displays.</summary>
    /// <returns>An Advanced Query Syntax string that is used to enumerate available line displays.</returns>
    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Gets an Advanced Query Syntax (AQS) string that you can use to list the line displays available over the specified connection types</summary>
    /// <param name="connectionTypes">A list of the connection types to check for available line displays.</param>
    /// <returns>An AQS string that is used to enumerate available line displays available over the specified connection types</returns>
    [Overload("GetDeviceSelectorWithConnectionTypes")]
    [MethodImpl]
    public static extern string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
