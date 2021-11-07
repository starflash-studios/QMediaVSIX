// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayAttributes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the attributes of a line display device.</summary>
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LineDisplayAttributes : ILineDisplayAttributes
  {
    /// <summary>Gets or sets whether the device is enabled to notify the user of power state changes.</summary>
    /// <returns>True if power state notifications are enabled; otherwise, False.</returns>
    public extern bool IsPowerNotifyEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brightness of the line display.</summary>
    /// <returns>The brightness of the line display.</returns>
    public extern int Brightness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the blink rate of the line display.</summary>
    /// <returns>The blink rate in milliseconds.</returns>
    public extern TimeSpan BlinkRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the current screen size.</summary>
    /// <returns>The current screen size in characters.</returns>
    public extern Size ScreenSizeInCharacters { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the current character set used by the device to display characters.</summary>
    /// <returns>The current character set.</returns>
    public extern int CharacterSet { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether character set mapping is enabled.</summary>
    /// <returns>True if character set mapping is enabled; otherwise, False.</returns>
    public extern bool IsCharacterSetMappingEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the current window to which text is displayed.</summary>
    /// <returns>The current window to which text is displayed.</returns>
    public extern LineDisplayWindow CurrentWindow { [MethodImpl] get; [MethodImpl] set; }
  }
}
