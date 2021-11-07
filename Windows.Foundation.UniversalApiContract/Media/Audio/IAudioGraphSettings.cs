// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraphSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Render;

namespace Windows.Media.Audio
{
  [Guid(492397695, 59134, 17960, 132, 248, 157, 139, 219, 162, 87, 133)]
  [ExclusiveTo(typeof (AudioGraphSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioGraphSettings
  {
    AudioEncodingProperties EncodingProperties { get; set; }

    DeviceInformation PrimaryRenderDevice { get; set; }

    QuantumSizeSelectionMode QuantumSizeSelectionMode { get; set; }

    int DesiredSamplesPerQuantum { get; set; }

    AudioRenderCategory AudioRenderCategory { get; set; }

    AudioProcessing DesiredRenderDeviceAudioProcessing { get; set; }
  }
}
