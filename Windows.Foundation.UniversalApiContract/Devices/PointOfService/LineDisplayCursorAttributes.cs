// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayCursorAttributes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the attributes of a line display cursor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LineDisplayCursorAttributes : ILineDisplayCursorAttributes
  {
    /// <summary>Gets or sets whether blinking is enabled on the cursor.</summary>
    /// <returns>True if blinking is enabled; otherwise, False.</returns>
    public extern bool IsBlinkEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the type of cursor used by the line display.</summary>
    /// <returns>The type of cursor used.</returns>
    public extern LineDisplayCursorType CursorType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether automatic advancing of the cursor is enabled.</summary>
    /// <returns>True if automatic advancing is enabled; otherwise, False.</returns>
    public extern bool IsAutoAdvanceEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the position of the cursor.</summary>
    /// <returns>The position of the cursor.</returns>
    public extern Point Position { [MethodImpl] get; [MethodImpl] set; }
  }
}
