// Decompiled with JetBrains decompiler
// Type: Windows.System.UserDeviceAssociation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Contains methods for querying for an association between a user and a device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUserDeviceAssociationStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class UserDeviceAssociation
  {
    /// <summary>Finds the user associated with a device.</summary>
    /// <param name="deviceId">The Id of the device.</param>
    /// <returns>The user associated with the device.</returns>
    [MethodImpl]
    public static extern User FindUserFromDeviceId(string deviceId);

    /// <summary>Fires when the user associated with a device changes.</summary>
    public static extern event EventHandler<UserDeviceAssociationChangedEventArgs> UserDeviceAssociationChanged;
  }
}
