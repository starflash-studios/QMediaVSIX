// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.LanIdentifierData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents the port specific data that enables LAN locality capabilities.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class LanIdentifierData : ILanIdentifierData
  {
    /// <summary>Gets a value indicating the type of data stored in the value field of the LanIdentifierData object according to the Link Layer Discovery Protocol (LLDP) protocol.</summary>
    /// <returns>A numeric value that maps to a value-type defined by the LLDP protocol used to define the locality information.</returns>
    public extern uint Type { [MethodImpl] get; }

    /// <summary>Gets the serialized value.</summary>
    /// <returns>A byte array that contains the serialized value of the data.</returns>
    public extern IVectorView<byte> Value { [MethodImpl] get; }
  }
}
