// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayAdapter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Devices.Display.Core
{
  [ExclusiveTo(typeof (DisplayAdapter))]
  [Guid(2775536263, 61440, 24366, 181, 172, 55, 131, 162, 182, 154, 245)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDisplayAdapter
  {
    DisplayAdapterId Id { get; }

    string DeviceInterfacePath { get; }

    uint SourceCount { get; }

    uint PciVendorId { get; }

    uint PciDeviceId { get; }

    uint PciSubSystemId { get; }

    uint PciRevision { get; }

    IMapView<Guid, object> Properties { get; }
  }
}
