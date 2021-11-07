// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandAccountUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides information for the AccountUpdated event.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandAccountUpdatedEventArgs : 
    IMobileBroadbandAccountUpdatedEventArgs
  {
    /// <summary>Gets the network account Id of the updated account.</summary>
    /// <returns>The network account Id of the updated account.</returns>
    public extern string NetworkAccountId { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the device information has changed for the account.</summary>
    /// <returns>A value indicating whether the device information has changed for the account.</returns>
    public extern bool HasDeviceInformationChanged { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if the CurrentNetwork was updated for the account.</summary>
    /// <returns>A value that indicates if the CurrentNetwork was updated for the account.</returns>
    public extern bool HasNetworkChanged { [MethodImpl] get; }
  }
}
