// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.PinChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SerialCommunication
{
  /// <summary>Represents the object that is passed as a parameter to the event handler that is invoked when the state of a signal line changes on the serial port.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class PinChangedEventArgs : IPinChangedEventArgs
  {
    /// <summary>Gets the type of signal change that caused the event on the serial port.</summary>
    /// <returns>One of the values defined in SerialPinChange enumeration.</returns>
    public extern SerialPinChange PinChange { [MethodImpl] get; }
  }
}
