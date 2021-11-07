// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePairingKinds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Indicates the kinds of pairing supported by your application or requested by the system. As an input value, use this value to indicate what kinds of pairing your application supports. When this datatype is received as an output value, it indicates the kind of pairing requested by the system. In this case, your code will need to respond accordingly.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Flags]
  public enum DevicePairingKinds : uint
  {
    /// <summary>No pairing is supported.</summary>
    None = 0,
    /// <summary>The application must confirm they wish to perform the pairing action. You can present an optional confirmation dialog to the user. With a value of **ConfirmOnly**, call Accept from the event args of the PairingRequested event handler if you want the pairing to complete.</summary>
    ConfirmOnly = 1,
    /// <summary>The application must display the given PIN to the user. The user will then need to enter or confirm that PIN on the device that is being paired. With a value of **DisplayPin**, call Accept from the event args of the PairingRequested event handler if you want the pairing to complete. If your application cancels the pairing at this point, the device might still be paired. This is because the system and the target device don't need any confirmation for this DevicePairingKinds value.</summary>
    DisplayPin = 2,
    /// <summary>The application must request a PIN from the user. The PIN will typically be displayed on the target device. With a value of **ProvidePin**, call Accept from the event args of the PairingRequested event handler if you want the pairing to complete. Pass in the PIN as a parameter.</summary>
    ProvidePin = 4,
    /// <summary>The application must display the given PIN to the user and ask the user to confirm that the PIN matches the one show on the target device. With a value of **ConfirmPinMatch**, call Accept from the event args of the PairingRequested event handler if you want the pairing to complete.</summary>
    ConfirmPinMatch = 8,
    /// <summary>The application must request a user name and password from the user. With a value of **ProvidePasswordCredential**, call AcceptWithPasswordCredential from the event args of the PairingRequested event handler to accept the pairing. Pass in the PasswordCredential that encapsulates the user name and password as a parameter.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] ProvidePasswordCredential = 16, // 0x00000010
  }
}
