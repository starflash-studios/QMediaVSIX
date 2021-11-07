// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class is the result of the CreateAsync operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattServiceProviderResult : IGattServiceProviderResult
  {
    /// <summary>Gets the error.</summary>
    /// <returns>The error.</returns>
    public extern BluetoothError Error { [MethodImpl] get; }

    /// <summary>Gets the service provider.</summary>
    /// <returns>The service provider.</returns>
    public extern GattServiceProvider ServiceProvider { [MethodImpl] get; }
  }
}
