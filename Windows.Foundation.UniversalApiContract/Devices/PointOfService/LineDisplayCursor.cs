// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayCursor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents a line display cursor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  public sealed class LineDisplayCursor : ILineDisplayCursor
  {
    /// <summary>Gets whether the line display device supports customizing the cursor style.</summary>
    /// <returns>True if the device supports customizing the cursor style; otherwise, False.</returns>
    public extern bool CanCustomize { [MethodImpl] get; }

    /// <summary>Gets whether cursor blinking is supported.</summary>
    /// <returns>True if cursor blinking is supported; otherwise, false.</returns>
    public extern bool IsBlinkSupported { [MethodImpl] get; }

    /// <summary>Gets whether a block cursor is supported.</summary>
    /// <returns>True if a block cursor is supported; otherwise, False.</returns>
    public extern bool IsBlockSupported { [MethodImpl] get; }

    /// <summary>Gets whether a half-block cursor is supported.</summary>
    /// <returns>True if a half-block cursor is supported; otherwise, False.</returns>
    public extern bool IsHalfBlockSupported { [MethodImpl] get; }

    /// <summary>Gets whether an underlined cursor is supported.</summary>
    /// <returns>True if an underline cursor is supported; otherwise, False.</returns>
    public extern bool IsUnderlineSupported { [MethodImpl] get; }

    /// <summary>Gets whether an inverted cursor is supported.</summary>
    /// <returns>True if an inverted cursor is supported; otherwise, False.</returns>
    public extern bool IsReverseSupported { [MethodImpl] get; }

    /// <summary>Gets whether another type (unknown as per UnifiedPOS) of cursor is supported.</summary>
    /// <returns>True if another type of cursor is supported; otherwise, False.</returns>
    public extern bool IsOtherSupported { [MethodImpl] get; }

    /// <summary>Gets the attributes of the line display cursor.</summary>
    /// <returns>The attributes of the line display cursor.</returns>
    [MethodImpl]
    public extern LineDisplayCursorAttributes GetAttributes();

    /// <summary>Attempts to asynchronously update the attributes of the line display curor.</summary>
    /// <param name="attributes">The attributes to be applied to the cursor.</param>
    /// <returns>Returns True if the attributes were successfully updated; otherwise, False.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryUpdateAttributesAsync(
      LineDisplayCursorAttributes attributes);
  }
}
