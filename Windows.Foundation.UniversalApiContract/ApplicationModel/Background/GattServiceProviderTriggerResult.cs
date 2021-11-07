// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.GattServiceProviderTriggerResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>This class contains the trigger created by GattServiceProviderTrigger.CreateAsync().</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattServiceProviderTriggerResult : IGattServiceProviderTriggerResult
  {
    /// <summary>Gets the Trigger created by GattServiceProviderTrigger.CreateAsync</summary>
    /// <returns>The trigger.</returns>
    public extern GattServiceProviderTrigger Trigger { [MethodImpl] get; }

    /// <summary>Get the status of creating the trigger.</summary>
    /// <returns>The error code.</returns>
    public extern BluetoothError Error { [MethodImpl] get; }
  }
}
