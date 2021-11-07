// Decompiled with JetBrains decompiler
// Type: Windows.System.UserDeviceAssociationChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Contains information about a UserDeviceAssociationChanged event.</summary>
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class UserDeviceAssociationChangedEventArgs : IUserDeviceAssociationChangedEventArgs
  {
    /// <summary>Gets the Id of the associated device.</summary>
    /// <returns>The Id of the associated device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the new user associated with the device.</summary>
    /// <returns>The new user associated with the device.</returns>
    public extern User NewUser { [MethodImpl] get; }

    /// <summary>Gets the old user previously associated with the device.</summary>
    /// <returns>The old user previously associated with the device.</returns>
    public extern User OldUser { [MethodImpl] get; }
  }
}
