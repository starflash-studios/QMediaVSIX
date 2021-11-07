// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.IDisplayMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Devices.Display
{
  [ExclusiveTo(typeof (DisplayMonitor))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(527111636, 7425, 19537, 135, 226, 111, 149, 74, 119, 43, 89)]
  internal interface IDisplayMonitor
  {
    string DeviceId { get; }

    string DisplayName { get; }

    DisplayMonitorConnectionKind ConnectionKind { get; }

    DisplayMonitorPhysicalConnectorKind PhysicalConnector { get; }

    string DisplayAdapterDeviceId { get; }

    DisplayAdapterId DisplayAdapterId { get; }

    uint DisplayAdapterTargetId { get; }

    DisplayMonitorUsageKind UsageKind { get; }

    SizeInt32 NativeResolutionInRawPixels { get; }

    IReference<Size> PhysicalSizeInInches { get; }

    float RawDpiX { get; }

    float RawDpiY { get; }

    Point RedPrimary { get; }

    Point GreenPrimary { get; }

    Point BluePrimary { get; }

    Point WhitePoint { get; }

    float MaxLuminanceInNits { get; }

    float MinLuminanceInNits { get; }

    float MaxAverageFullFrameLuminanceInNits { get; }

    byte[] GetDescriptor(DisplayMonitorDescriptorKind descriptorKind);
  }
}
