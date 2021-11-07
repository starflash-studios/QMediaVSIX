// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceUnpairingResultStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>The result of the unpairing action.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum DeviceUnpairingResultStatus
  {
    /// <summary>The device object is successfully unpaired.</summary>
    Unpaired,
    /// <summary>The device object was already unpaired.</summary>
    AlreadyUnpaired,
    /// <summary>The device object is currently in the middle of either a pairing or unpairing action.</summary>
    OperationAlreadyInProgress,
    /// <summary>The caller does not have sufficient permissions to unpair the device.</summary>
    AccessDenied,
    /// <summary>An unknown failure occurred.</summary>
    Failed,
  }
}
