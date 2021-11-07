// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2932178031, 18356, 21611, 152, 124, 231, 63, 167, 145, 254, 58)]
  [ExclusiveTo(typeof (DisplayTarget))]
  internal interface IDisplayTarget
  {
    DisplayAdapter Adapter { get; }

    string DeviceInterfacePath { get; }

    uint AdapterRelativeId { get; }

    bool IsConnected { get; }

    bool IsVirtualModeEnabled { get; }

    bool IsVirtualTopologyEnabled { get; }

    DisplayMonitorUsageKind UsageKind { get; }

    DisplayTargetPersistence MonitorPersistence { get; }

    string StableMonitorId { get; }

    DisplayMonitor TryGetMonitor();

    IMapView<Guid, object> Properties { get; }

    bool IsStale { get; }

    bool IsSame(DisplayTarget otherTarget);

    bool IsEqual(DisplayTarget otherTarget);
  }
}
