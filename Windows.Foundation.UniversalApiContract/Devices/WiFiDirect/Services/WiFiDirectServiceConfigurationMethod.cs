// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceConfigurationMethod
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Values describing how service configuration is performed when a session is being established. Typically, either no input is required, or one device in the session displays a PIN and the other device requires that the PIN be entered.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WiFiDirectServiceConfigurationMethod
  {
    /// <summary>Do not require input at configuration.</summary>
    Default,
    /// <summary>Display a PIN at configuration.</summary>
    PinDisplay,
    /// <summary>Request PIN entry at configuration.</summary>
    PinEntry,
  }
}
