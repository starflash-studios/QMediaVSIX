// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayWindow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents a line display window.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  public sealed class LineDisplayWindow : ILineDisplayWindow, ILineDisplayWindow2, IClosable
  {
    /// <summary>Gets dimensions of the window, in number of character lines (rows and columns).</summary>
    /// <returns>The number of character lines (rows and columns).</returns>
    public extern Size SizeInCharacters { [MethodImpl] get; }

    /// <summary>Gets or sets the delay interval between displaying successive characters.</summary>
    /// <returns>The delay interval between displaying successive characters. The default value of this property is 0.</returns>
    public extern TimeSpan InterCharacterWaitInterval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Refresh the line display window.</summary>
    /// <returns>True if the window was successfully refreshed; otherwise, false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRefreshAsync();

    /// <summary>Try to display the specified text in the line display window, using the specified display attribute.</summary>
    /// <param name="text">The text to be displayed.</param>
    /// <param name="displayAttribute">The display attribute to be applied to the window.</param>
    /// <returns>True if the text was displayed successfully; otherwise, false.</returns>
    [RemoteAsync]
    [Overload("TryDisplayTextAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayTextAsync(
      string text,
      LineDisplayTextAttribute displayAttribute);

    /// <summary>Try to display the specified text at a specified position in the line display window, using the specified display attribute.</summary>
    /// <param name="text">The text to be displayed.</param>
    /// <param name="displayAttribute">The display attribute to be applied to the window.</param>
    /// <param name="startPosition">The row and column at which to start displaying the text.</param>
    /// <returns>True if the text was displayed successfully; otherwise, false.</returns>
    [Overload("TryDisplayTextAtPositionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayTextAsync(
      string text,
      LineDisplayTextAttribute displayAttribute,
      Point startPosition);

    /// <summary>Try to display the specified text in the line display window.</summary>
    /// <param name="text">The text to be displayed.</param>
    /// <returns>True if the text was displayed successfully; otherwise, false.</returns>
    [RemoteAsync]
    [Overload("TryDisplayTextNormalAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayTextAsync(string text);

    /// <summary>Scroll the window text contents the specified number of lines in the specified direction.</summary>
    /// <param name="direction">The direction in which to scroll text.</param>
    /// <param name="numberOfColumnsOrRows">The number of columns or rows to scroll. Columns are used if the scroll direction is left or right; rows are used if the scroll direction is up or down.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryScrollTextAsync(
      LineDisplayScrollDirection direction,
      uint numberOfColumnsOrRows);

    /// <summary>Clears the current window. Changers all characters to blanks, clears any bitmaps displayed in the window, and sets **Cursor.Position** to {0,0}.</summary>
    /// <returns>True if the window was successfully cleared; otherwise, false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryClearTextAsync();

    /// <summary>Gets the cursor of the line display window.</summary>
    /// <returns>The cursor of the line display window.</returns>
    public extern LineDisplayCursor Cursor { [MethodImpl] get; }

    /// <summary>Gets the line display marquee.</summary>
    /// <returns>The line display marquee.</returns>
    public extern LineDisplayMarquee Marquee { [MethodImpl] get; }

    /// <summary>Attempts to asynchronously read the currently displayed character at the current cursor position.</summary>
    /// <returns>Returns the code for the character at the current cursor position. Returns 0 if the method fails.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> ReadCharacterAtCursorAsync();

    /// <summary>Attempts to asynchronously display a stored bitmap from at LineDisplayStoredBitmap object at the current cursor position.</summary>
    /// <param name="bitmap">The bitmap to be displayed.</param>
    /// <returns>Returns True if the bitmap was successfully displayed; otherwise, False.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayStoredBitmapAtCursorAsync(
      LineDisplayStoredBitmap bitmap);

    /// <summary>Attempts to asynchronously display a bitmap from a storage file at the current cursor position.</summary>
    /// <param name="bitmap">The bitmap to be displayed.</param>
    /// <returns>Return True if the bitmap was successfully displayed; otherwise, False.</returns>
    [RemoteAsync]
    [Overload("TryDisplayStorageFileBitmapAtCursorAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayStorageFileBitmapAtCursorAsync(
      StorageFile bitmap);

    /// <summary>Attempts to asynchronously display a bitmap from a storage file at the current cursor position.</summary>
    /// <param name="bitmap">The bitmap to be displayed.</param>
    /// <param name="horizontalAlignment">The horizontal alignment of the bitmap relative to the current text character position.</param>
    /// <param name="verticalAlignment">The vertical alignment of the bitmap relative to the current text character position.</param>
    /// <returns>Return True if the bitmap was successfully displayed; otherwise, False.</returns>
    [Overload("TryDisplayStorageFileBitmapAtCursorWithAlignmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayStorageFileBitmapAtCursorAsync(
      StorageFile bitmap,
      LineDisplayHorizontalAlignment horizontalAlignment,
      LineDisplayVerticalAlignment verticalAlignment);

    /// <summary>Attempts to asynchronously display a bitmap from a storage file at the current cursor position, at a particular width.</summary>
    /// <param name="bitmap">The bitmap to be displayed.</param>
    /// <param name="horizontalAlignment">The horizontal alignment of the bitmap relative to the current text character position.</param>
    /// <param name="verticalAlignment">The vertical alignment of the bitmap relative to the current text character position.</param>
    /// <param name="widthInPixels">The desired width of the bitmap. A value of 0 pixels will display the bitmap at one pixel per screen dot (unscaled).</param>
    /// <returns>Return True if the bitmap was successfully displayed; otherwise, False.</returns>
    [Overload("TryDisplayStorageFileBitmapAtCursorWithAlignmentAndWidthAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayStorageFileBitmapAtCursorAsync(
      StorageFile bitmap,
      LineDisplayHorizontalAlignment horizontalAlignment,
      LineDisplayVerticalAlignment verticalAlignment,
      int widthInPixels);

    /// <summary>Attempts to asynchronously display a bitmap from a storage file at a particular point.</summary>
    /// <param name="bitmap">The bitmap to be displayed.</param>
    /// <param name="offsetInPixels">The number of pixels to offset the bitmap display from the top-left corner of the screen, {0,0}.</param>
    /// <returns>Return True if the bitmap was successfully displayed; otherwise, False.</returns>
    [RemoteAsync]
    [Overload("TryDisplayStorageFileBitmapAtPointAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayStorageFileBitmapAtPointAsync(
      StorageFile bitmap,
      Point offsetInPixels);

    /// <summary>Attempts to asynchronously display a bitmap from a storage file at a particular point, scaled to a particular width.</summary>
    /// <param name="bitmap">The bitmap to be displayed.</param>
    /// <param name="offsetInPixels">The number of pixels to offset the bitmap display from the top-left corner of the screen, {0,0}.</param>
    /// <param name="widthInPixels">The desired width of the bitmap. A value of 0 pixels will display the bitmap at one pixel per screen dot (unscaled).</param>
    /// <returns>Return True if the bitmap was successfully displayed; otherwise, False.</returns>
    [RemoteAsync]
    [Overload("TryDisplayStorageFileBitmapAtPointWithWidthAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayStorageFileBitmapAtPointAsync(
      StorageFile bitmap,
      Point offsetInPixels,
      int widthInPixels);

    [MethodImpl]
    public extern void Close();
  }
}
