// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.PnpObjectUpdate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  /// <summary>Contains the updated properties of a PnpObject.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PnpObjectUpdate : IPnpObjectUpdate
  {
    /// <summary>The type of the PnpObject. One of the values of the PnpObjectType enumeration.</summary>
    /// <returns>The type of the PnpObject.</returns>
    public extern PnpObjectType Type { [MethodImpl] get; }

    /// <summary>The identifier of the PnpObject.</summary>
    /// <returns>The identifier of the PnpObject.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>The changed properties in an update to a PnpObject.</summary>
    /// <returns>The changed properties.</returns>
    public extern IMapView<string, object> Properties { [MethodImpl] [return: HasVariant] get; }
  }
}
