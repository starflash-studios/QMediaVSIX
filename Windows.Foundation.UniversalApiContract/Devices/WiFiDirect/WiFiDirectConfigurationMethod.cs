// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectConfigurationMethod
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Specifies a Wi-Fi Direct configuration method. Configuration is how a user tells one piece of Wi-Fi Direct equipment to connect to another piece of Wi-Fi Direct equipment.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum WiFiDirectConfigurationMethod
  {
    /// <summary>This device accepts entry of the PIN being displayed on the accepting device.</summary>
    ProvidePin,
    /// <summary>This device accepts connections from devices that provide the PIN this device currently displays.</summary>
    DisplayPin,
    /// <summary>This device uses the pushbutton method for pairing. A user pushes a button on both the connecting device and the accepting device in order to establish a connection between them.</summary>
    PushButton,
  }
}
