// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.CivicAddress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Unsupported API.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CivicAddress : ICivicAddress
  {
    /// <summary>Unsupported API.</summary>
    /// <returns>Unsupported API.</returns>
    public extern string Country { [MethodImpl] get; }

    /// <summary>Unsupported API.</summary>
    /// <returns>Unsupported API.</returns>
    public extern string State { [MethodImpl] get; }

    /// <summary>Unsupported API.</summary>
    /// <returns>Unsupported API.</returns>
    public extern string City { [MethodImpl] get; }

    /// <summary>Unsupported API.</summary>
    /// <returns>Unsupported API.</returns>
    public extern string PostalCode { [MethodImpl] get; }

    /// <summary>Unsupported API.</summary>
    /// <returns>Unsupported API.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }
  }
}
