// Decompiled with JetBrains decompiler
// Type: Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.ExchangeActiveSyncProvisioning
{
  /// <summary>Provides the app with the ability to retrieve device information from the local device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class EasClientDeviceInformation : 
    IEasClientDeviceInformation,
    IEasClientDeviceInformation2
  {
    /// <summary>Creates an instance of an object that allows the caller app to retrieve device information from the local device.</summary>
    [MethodImpl]
    public extern EasClientDeviceInformation();

    /// <summary>Returns the identifier of the local device.</summary>
    /// <returns>The identifier of the local device. The value range is 16 bytes.</returns>
    public extern Guid Id { [MethodImpl] get; }

    /// <summary>Gets the name of the operating system of the local device.</summary>
    /// <returns>A string containing the operating system of the local device.</returns>
    public extern string OperatingSystem { [MethodImpl] get; }

    /// <summary>Gets the friendly name of the local device. This value might come from a NetBIOS computer name.</summary>
    /// <returns>A string containing the friendly name of the local device. The value is fewer than 1024 characters long.</returns>
    public extern string FriendlyName { [MethodImpl] get; }

    /// <summary>Gets the system manufacturer of the local device. Use **SystemManufacturer** only if the value of SystemSku is empty.</summary>
    /// <returns>A string containing the system manufacturer of the local device. The value is fewer than 1024 characters long.</returns>
    public extern string SystemManufacturer { [MethodImpl] get; }

    /// <summary>Gets the system product name of the local device. Use **SystemProductName** only if the value of SystemSku is empty.</summary>
    /// <returns>A string containing the system product name of the local device. The value is fewer than 1024 characters long.</returns>
    public extern string SystemProductName { [MethodImpl] get; }

    /// <summary>Gets the system SKU of the local device.</summary>
    /// <returns>A string containing the system SKU of the local device.</returns>
    public extern string SystemSku { [MethodImpl] get; }

    /// <summary>Gets the system hardware version of the local device.</summary>
    /// <returns>A string containing the system hardware version of the local device.</returns>
    public extern string SystemHardwareVersion { [MethodImpl] get; }

    /// <summary>Gets the system firmware version of the local device.</summary>
    /// <returns>A string containing the system firmware version of the local device.</returns>
    public extern string SystemFirmwareVersion { [MethodImpl] get; }
  }
}
