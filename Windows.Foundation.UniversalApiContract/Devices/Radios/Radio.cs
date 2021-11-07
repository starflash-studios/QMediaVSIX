// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Radios.Radio
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Radios
{
  /// <summary>Represents a radio device on the system.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IRadioStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Radio : IRadio
  {
    /// <summary>An asynchronous operation that attempts to set the state of the radio represented by this object.</summary>
    /// <param name="value">The desired radio state. </param>
    /// <returns>An asynchronous state setting operation. On successful completion, contains an enumeration value describing status of the state change request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RadioAccessStatus> SetStateAsync(
      RadioState value);

    /// <summary>Event raised by a state change in the radio represented by this object.  When a USB Bluetooth radio is removed or otherwise goes offline, no state change is reported.</summary>
    public extern event TypedEventHandler<Radio, object> StateChanged;

    /// <summary>Gets the current state of the radio represented by this object.</summary>
    /// <returns>The current radio state.</returns>
    public extern RadioState State { [MethodImpl] get; }

    /// <summary>Gets the name of the radio represented by this object.</summary>
    /// <returns>The radio name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets an enumeration value that describes what kind of radio this object represents.</summary>
    /// <returns>The kind of this radio.</returns>
    public extern RadioKind Kind { [MethodImpl] get; }

    /// <summary>A static, asynchronous method that retrieves a collection of Windows.Devices.Radios.Radio objects representing radio devices which existed on the system at the time the program launched.  Additions or removals of radios are ignored by subsequent calls.</summary>
    /// <returns>An asynchronous retrieval operation. When the operation is complete, contains a list of Windows.Devices.Radios.Radio objects describing radios that existed at the time the program launched.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<Radio>> GetRadiosAsync();

    /// <summary>A static method that returns an Advanced Query Syntax (AQS) string to be used to enumerate or monitor Radio devices with Windows.Devices.Enumeration.DeviceInformation.FindAllAsync and related methods.</summary>
    /// <returns>An identifier to be used to enumerate radio devices.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>A static method that retrieves a Radio object. The method accepts the 'Device.Id' found through Windows.Devices.Enumeration.DeviceInformation.FindAllAsync. This procedure is more reliable than using GetRadiosAsync to obtain a radio in situations where a USB Radio has failed or been removed on a Windows 10 workstation. In this instance of a failed or removed radio, GetRadiosAsync returns no bluetooth radio.</summary>
    /// <param name="deviceId">A string that identifies a particular radio device.</param>
    /// <returns>An asynchronous retrieval operation. On successful completion, it contains a Radio object that represents the specified radio device. Otherwise it throws an exception.</returns>
    [Overload("FromIdAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Radio> FromIdAsync(string deviceId);

    /// <summary>An asynchronous method that retrieves a value indicating what access the current user has to the radio represented by this object. In circumstances where user permission is required to access the radio, this method prompts the user for permission. Consequently, always call this method on the UI thread.</summary>
    /// <returns>An asynchronous status retrieval operation. On successful completion, contains an enumeration value describing the current user's access to this radio.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RadioAccessStatus> RequestAccessAsync();
  }
}
