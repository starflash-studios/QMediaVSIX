// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.TetheringEntitlementCheckTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides details about the tethering event that activated a TetheringEntitlementCheckTrigger.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TetheringEntitlementCheckTriggerDetails : 
    ITetheringEntitlementCheckTriggerDetails
  {
    /// <summary>Gets a value specifying the network account ID (SSID), which is a unique identifier for the mobile broadband account that received the notification.</summary>
    /// <returns>A value specifying the network account ID (SSID).</returns>
    public extern string NetworkAccountId { [MethodImpl] get; }

    /// <summary>Indicates that tethering is permitted for the network account ID (SSID) for the device.</summary>
    [MethodImpl]
    public extern void AllowTethering();

    /// <summary>Indicates that tethering is denied for the network account ID (SSID) for the device.</summary>
    /// <param name="entitlementFailureReason">A string specifying the reason for the tethering failure.</param>
    [MethodImpl]
    public extern void DenyTethering(string entitlementFailureReason);
  }
}
