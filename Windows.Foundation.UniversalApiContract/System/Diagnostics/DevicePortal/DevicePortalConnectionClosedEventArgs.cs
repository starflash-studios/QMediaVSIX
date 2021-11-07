// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionClosedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.DevicePortal
{
  /// <summary>Describes a DevicePortalConnection.Closed event that was raised.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DevicePortalConnectionClosedEventArgs : IDevicePortalConnectionClosedEventArgs
  {
    /// <summary>Describes the reason that the device portal connection was closed.</summary>
    /// <returns>A DevicePortalConnectionClosedReason value describing the reason for closing.</returns>
    public extern DevicePortalConnectionClosedReason Reason { [MethodImpl] get; }
  }
}
