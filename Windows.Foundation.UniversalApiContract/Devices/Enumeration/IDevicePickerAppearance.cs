// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDevicePickerAppearance
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DevicePickerAppearance))]
  [Guid(3868857030, 58919, 20184, 155, 108, 70, 10, 244, 69, 229, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDevicePickerAppearance
  {
    string Title { get; set; }

    Color ForegroundColor { get; set; }

    Color BackgroundColor { get; set; }

    Color AccentColor { get; set; }

    Color SelectedForegroundColor { get; set; }

    Color SelectedBackgroundColor { get; set; }

    Color SelectedAccentColor { get; set; }
  }
}
