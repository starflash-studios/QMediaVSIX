// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IMediaDeviceControlCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(587225110, 60293, 17378, 185, 43, 130, 64, 213, 238, 112, 236)]
  [ExclusiveTo(typeof (MediaDeviceControlCapabilities))]
  internal interface IMediaDeviceControlCapabilities
  {
    bool Supported { get; }

    double Min { get; }

    double Max { get; }

    double Step { get; }

    double Default { get; }

    bool AutoModeSupported { get; }
  }
}
