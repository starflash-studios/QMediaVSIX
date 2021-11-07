// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.BarcodeScannerProviderTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  /// <summary>Represents trigger information about the barcode scanner background task, where data will be transferred between the app and its caller.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BarcodeScannerProviderTriggerDetails : IBarcodeScannerProviderTriggerDetails
  {
    /// <summary>Gets the connection object used to provide barcode scanning to a client app.</summary>
    /// <returns>The connection used by the provider to communicate with a client app.</returns>
    public extern BarcodeScannerProviderConnection Connection { [MethodImpl] get; }
  }
}
