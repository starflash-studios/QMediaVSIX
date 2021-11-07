// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [Guid(2764682796, 13151, 22321, 140, 180, 193, 204, 212, 115, 16, 112)]
  [ExclusiveTo(typeof (DisplayDevice))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDisplayDevice
  {
    DisplaySource CreateScanoutSource(DisplayTarget target);

    DisplaySurface CreatePrimary(DisplayTarget target, DisplayPrimaryDescription desc);

    DisplayTaskPool CreateTaskPool();

    DisplayFence CreatePeriodicFence(DisplayTarget target, TimeSpan offsetFromVBlank);

    void WaitForVBlank(DisplaySource source);

    DisplayScanout CreateSimpleScanout(
      DisplaySource pSource,
      DisplaySurface pSurface,
      uint SubResourceIndex,
      uint SyncInterval);

    bool IsCapabilitySupported(DisplayDeviceCapability capability);
  }
}
