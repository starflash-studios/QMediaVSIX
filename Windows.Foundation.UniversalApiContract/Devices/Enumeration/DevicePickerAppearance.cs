// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePickerAppearance
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Enumeration
{
  /// <summary>Represents the appearance of a device picker.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class DevicePickerAppearance : IDevicePickerAppearance
  {
    /// <summary>Gets and sets the title for the picker UI.</summary>
    /// <returns>The title of the picker UI.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the foreground color of the picker UI.</summary>
    /// <returns>The foreground color.</returns>
    public extern Color ForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the background color of the picker UI.</summary>
    /// <returns>The background color.</returns>
    public extern Color BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the accent color of the picker UI.</summary>
    /// <returns>The accent color.</returns>
    public extern Color AccentColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the foreground color for a device that is selected in the picker.</summary>
    /// <returns>The foreground color.</returns>
    public extern Color SelectedForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the background color for a device that is selected in the picker.</summary>
    /// <returns>The color to use as the background of a selected device.</returns>
    public extern Color SelectedBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the accent color for a device that has been selected in the picker.</summary>
    /// <returns>The accent color.</returns>
    public extern Color SelectedAccentColor { [MethodImpl] get; [MethodImpl] set; }
  }
}
