// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IWhiteBalanceControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2015298686, 29026, 18888, 168, 249, 148, 129, 197, 101, 54, 62)]
  [ExclusiveTo(typeof (WhiteBalanceControl))]
  internal interface IWhiteBalanceControl
  {
    bool Supported { get; }

    ColorTemperaturePreset Preset { get; }

    [RemoteAsync]
    IAsyncAction SetPresetAsync(ColorTemperaturePreset preset);

    uint Min { get; }

    uint Max { get; }

    uint Step { get; }

    uint Value { get; }

    [RemoteAsync]
    IAsyncAction SetValueAsync(uint temperature);
  }
}
