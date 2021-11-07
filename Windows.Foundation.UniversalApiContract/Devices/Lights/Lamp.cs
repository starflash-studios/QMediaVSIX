// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Lamp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights
{
  /// <summary>Represents a lamp device.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ILampStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Lamp : ILamp, IClosable
  {
    /// <summary>Gets the DeviceInformation Id for a lamp device.</summary>
    /// <returns>The DeviceInformation Id for a lamp device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the lamp device is enabled.</summary>
    /// <returns>True if the lamp is enabled; otherwise, false.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating the current brightness level of the lamp, where 0.0 is completely off and 1.0 is maximum brightness.</summary>
    /// <returns>A value indicating the current brightness level of the lamp.</returns>
    public extern float BrightnessLevel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating whether you can set the Color property of the lamp device.</summary>
    /// <returns>True if you can set the Color property of the lamp; otherwise, false.</returns>
    public extern bool IsColorSettable { [MethodImpl] get; }

    /// <summary>Gets or sets the color of the lamp.</summary>
    /// <returns>The color of the lamp.</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the availability of the lamp device changes.</summary>
    public extern event TypedEventHandler<Lamp, LampAvailabilityChangedEventArgs> AvailabilityChanged;

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns the class selection string that you can use to enumerate lamp devices.</summary>
    /// <returns>The class selection string for lamp devices.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Gets a Lamp object representing the lamp device with the specified ID.</summary>
    /// <param name="deviceId">The ID of the requested lamp device.</param>
    /// <returns>An asynchronous operation that returns a Lamp object upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Lamp> FromIdAsync(string deviceId);

    /// <summary>Gets a Lamp object representing the default lamp for the device.</summary>
    /// <returns>An asynchronous operation that returns a Lamp object upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Lamp> GetDefaultAsync();
  }
}
