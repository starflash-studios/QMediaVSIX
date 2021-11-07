// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IDeviceActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information for a device that invokes AutoPlay.</summary>
  [Guid(3444619689, 52752, 17618, 130, 52, 195, 85, 160, 115, 239, 51)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IDeviceActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the device identifier for the device that invoked AutoPlay.</summary>
    /// <returns>The device identifier for the device that invoked AutoPlay.</returns>
    string DeviceInformationId { get; }

    /// <summary>Gets the action associated with the activated device.</summary>
    /// <returns>The action associated with the activated device.</returns>
    string Verb { get; }
  }
}
