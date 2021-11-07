// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.SerialPinChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SerialCommunication
{
  /// <summary>Defines values for types of signal state changes on the serial port.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SerialPinChange
  {
    /// <summary>Change in the break signal state.</summary>
    BreakSignal,
    /// <summary>Change in the Carrier Detect line for the port.</summary>
    CarrierDetect,
    /// <summary>Change in the Clear-to-Send line for the port.</summary>
    ClearToSend,
    /// <summary>Change in the state of the Data Set Ready (DSR) signal.</summary>
    DataSetReady,
    /// <summary>Change in the ring indicator state.</summary>
    RingIndicator,
  }
}
