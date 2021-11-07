// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.CashDrawerStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides the current power and availability status of the cash drawer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CashDrawerStatus : ICashDrawerStatus
  {
    /// <summary>Gets the status kind for the cash drawer status.</summary>
    /// <returns>The status kind.</returns>
    public extern CashDrawerStatusKind StatusKind { [MethodImpl] get; }

    /// <summary>ExtendedStatus provides a way for a Point of Service driver or provider to send custom notifications to the app.</summary>
    /// <returns>Value representing the custom notification.</returns>
    public extern uint ExtendedStatus { [MethodImpl] get; }
  }
}
