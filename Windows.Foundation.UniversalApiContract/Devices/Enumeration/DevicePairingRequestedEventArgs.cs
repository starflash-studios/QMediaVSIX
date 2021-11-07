// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePairingRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Devices.Enumeration
{
  /// <summary>Provides data for the PairingRequested event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class DevicePairingRequestedEventArgs : 
    IDevicePairingRequestedEventArgs,
    IDevicePairingRequestedEventArgs2
  {
    /// <summary>Gets the DeviceInformation object associated with this pairing request.</summary>
    /// <returns>The DeviceInformation object associated with this pairing request.</returns>
    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    /// <summary>Gets the kind of pairing associated with this pairing event.</summary>
    /// <returns>The kind of pairing used for this pairing request.</returns>
    public extern DevicePairingKinds PairingKind { [MethodImpl] get; }

    /// <summary>Gets the pin associated with a pairing request.</summary>
    /// <returns>The pin associated with a pairing request.</returns>
    public extern string Pin { [MethodImpl] get; }

    /// <summary>Accepts a PairingRequested event and pairs the device with the application.</summary>
    [Overload("Accept")]
    [MethodImpl]
    public extern void Accept();

    /// <summary>Accepts a PairingRequested event and pairs the device with the application. Requires a pin for pairing purposes.</summary>
    /// <param name="pin">The pin to use for attempting to pair a device.</param>
    [Overload("AcceptWithPin")]
    [MethodImpl]
    public extern void Accept(string pin);

    /// <summary>Requests a Deferral to support asynchronous operations.</summary>
    /// <returns>The deferral necessary to support asynchronous actions.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();

    /// <summary>Accepts a PairingRequested event and pairs the device with the application. Requires a user name and password for pairing purposes.</summary>
    /// <param name="passwordCredential">An object that encapsulates the user name and password for attempting to pair the device.</param>
    [MethodImpl]
    public extern void AcceptWithPasswordCredential(PasswordCredential passwordCredential);
  }
}
