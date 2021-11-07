// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IMediaDeviceControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (MediaDeviceControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4020821929, 28533, 18531, 186, 11, 88, 63, 48, 54, 180, 222)]
  internal interface IMediaDeviceControl
  {
    MediaDeviceControlCapabilities Capabilities { get; }

    bool TryGetValue(out double value);

    bool TrySetValue(double value);

    bool TryGetAuto(out bool value);

    bool TrySetAuto(bool value);
  }
}
