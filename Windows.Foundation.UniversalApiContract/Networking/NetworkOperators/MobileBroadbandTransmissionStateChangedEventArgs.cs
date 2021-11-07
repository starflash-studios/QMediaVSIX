// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandTransmissionStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides data for the TransmissionStateChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandTransmissionStateChangedEventArgs : 
    IMobileBroadbandTransmissionStateChangedEventArgs
  {
    /// <summary>Gets a value that indicates whether the modem is transmitting.</summary>
    /// <returns>True if the modem is transmitting; otherwise, false.</returns>
    public extern bool IsTransmitting { [MethodImpl] get; }
  }
}
