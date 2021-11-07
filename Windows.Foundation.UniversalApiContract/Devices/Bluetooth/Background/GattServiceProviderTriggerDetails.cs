// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.GattServiceProviderTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  /// <summary>Provides information about the Bluetooth device that caused this trigger to fire.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattServiceProviderTriggerDetails : IGattServiceProviderTriggerDetails
  {
    /// <summary>Gets the connection that triggered the event.</summary>
    /// <returns>Gets the connection that triggered the event.</returns>
    public extern GattServiceProviderConnection Connection { [MethodImpl] get; }
  }
}
