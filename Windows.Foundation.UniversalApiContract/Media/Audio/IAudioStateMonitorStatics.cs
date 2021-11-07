// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioStateMonitorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Devices;
using Windows.Media.Render;

namespace Windows.Media.Audio
{
  [Guid(1668606540, 6971, 16385, 148, 217, 221, 34, 83, 48, 250, 64)]
  [ExclusiveTo(typeof (AudioStateMonitor))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAudioStateMonitorStatics
  {
    [Overload("CreateForRenderMonitoring")]
    AudioStateMonitor CreateForRenderMonitoring();

    [Overload("CreateForRenderMonitoringWithCategory")]
    AudioStateMonitor CreateForRenderMonitoring(AudioRenderCategory category);

    [Overload("CreateForRenderMonitoringWithCategoryAndDeviceRole")]
    AudioStateMonitor CreateForRenderMonitoring(
      AudioRenderCategory category,
      AudioDeviceRole role);

    AudioStateMonitor CreateForRenderMonitoringWithCategoryAndDeviceId(
      AudioRenderCategory category,
      string deviceId);

    [Overload("CreateForCaptureMonitoring")]
    AudioStateMonitor CreateForCaptureMonitoring();

    [Overload("CreateForCaptureMonitoringWithCategory")]
    AudioStateMonitor CreateForCaptureMonitoring(MediaCategory category);

    [Overload("CreateForCaptureMonitoringWithCategoryAndDeviceRole")]
    AudioStateMonitor CreateForCaptureMonitoring(
      MediaCategory category,
      AudioDeviceRole role);

    AudioStateMonitor CreateForCaptureMonitoringWithCategoryAndDeviceId(
      MediaCategory category,
      string deviceId);
  }
}
