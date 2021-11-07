// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.ErrorReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SerialCommunication
{
  /// <summary>Represents the object that is passed as a parameter to the event handler that is invoked when error occurs on the serial port.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ErrorReceivedEventArgs : IErrorReceivedEventArgs
  {
    /// <summary>Gets the character type received that caused the event on the serial port.</summary>
    /// <returns>One of the values defined in the SerialError enumeration.</returns>
    public extern SerialError Error { [MethodImpl] get; }
  }
}
