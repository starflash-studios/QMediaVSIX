// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IDevicePairingActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information when an app is activated as a result of a device pairing.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3953185252, 60614, 16712, 148, 237, 244, 179, 126, 192, 91, 62)]
  public interface IDevicePairingActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the DeviceInformation object for the device object that is being paired.</summary>
    /// <returns>The information of the device object.</returns>
    DeviceInformation DeviceInformation { get; }
  }
}
