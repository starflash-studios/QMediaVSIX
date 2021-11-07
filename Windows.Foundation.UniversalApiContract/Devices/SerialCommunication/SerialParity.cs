// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.SerialParity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SerialCommunication
{
  /// <summary>Defines values for the parity bit for the serial data transmission. The values are used by the Parity property on the SerialDevice object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SerialParity
  {
    /// <summary>No parity check occurs.</summary>
    None,
    /// <summary>Sets the parity bit so that the total count of data bits set is an odd number.</summary>
    Odd,
    /// <summary>Sets the parity bit so that the total count of data bits set is an even number.</summary>
    Even,
    /// <summary>Leaves the parity bit set to 1.</summary>
    Mark,
    /// <summary>Leaves the parity bit set to 0.</summary>
    Space,
  }
}
