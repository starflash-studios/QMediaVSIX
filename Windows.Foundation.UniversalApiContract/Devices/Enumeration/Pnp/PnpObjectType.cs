// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.PnpObjectType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  /// <summary>Indicates the type of device represented by the PnpObject.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PnpObjectType
  {
    /// <summary>The object is of an unknown type. This value is not used.</summary>
    Unknown,
    /// <summary>The PnpObject represents a device interface.</summary>
    DeviceInterface,
    /// <summary>The PnpObject represents a device container.</summary>
    DeviceContainer,
    /// <summary>The PnpObject represents a device.</summary>
    Device,
    /// <summary>The PnpObject represents a device interface class.</summary>
    DeviceInterfaceClass,
    /// <summary>The PnpObject represents an association endpoint.</summary>
    AssociationEndpoint,
    /// <summary>The PnpObject represents an association endpoint container.</summary>
    AssociationEndpointContainer,
    /// <summary>The PnpObject represents an association endpoint service.</summary>
    AssociationEndpointService,
    /// <summary>The PnpObject represents a device input panel.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] DevicePanel,
  }
}
