// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.DialProtocol
{
  /// <summary>Represents the remote device capable of running DIAL apps.</summary>
  [Static(typeof (IDialDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DialDevice : IDialDevice, IDialDevice2
  {
    /// <summary>Gets the remote device's ID. You can use this ID with the Windows.Devices.Enumeration APIs as well.</summary>
    /// <returns>The ID of the remote device.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Creates a new DialApp object. This method does not establish a connection to the device or validate that the app exists. That is done when any function is called on the resulting DialApp object.</summary>
    /// <param name="appName">The name of the app. This becomes the AppName property of the new object.</param>
    /// <returns>The DialApp object for the app.</returns>
    [MethodImpl]
    public extern DialApp GetDialApp(string appName);

    /// <summary>Gets the friendly name for the DIAL device.</summary>
    /// <returns>The friendly name for the DIAL device.</returns>
    public extern string FriendlyName { [MethodImpl] get; }

    /// <summary>Gets a stream containing the thumbnail image for the DIAL device.</summary>
    /// <returns>A stream containing the thumbnail image for the DIAL device.</returns>
    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; }

    /// <summary>Returns an AQS filter string to be used with the Windows.Devices.Enumeration APIs (such as the CreateWatcher API) for a given Dial app.</summary>
    /// <param name="appName">The name of the app.</param>
    /// <returns>The AQS filter.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector(string appName);

    /// <summary>Returns a DialDevice object for a given a device ID (acquired from a query using the Windows.Devices.Enumeration APIs).</summary>
    /// <param name="value">The ID of the device you want a DialDevice object for.</param>
    /// <returns>The DialDevice object for the given device ID.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DialDevice> FromIdAsync(
      string value);

    /// <summary>Indicates whether or not the device supports launching DIAL apps.</summary>
    /// <param name="device">The device you want to get information for.</param>
    /// <returns>True if app launching is supported; false, otherwise.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> DeviceInfoSupportsDialAsync(
      DeviceInformation device);
  }
}
