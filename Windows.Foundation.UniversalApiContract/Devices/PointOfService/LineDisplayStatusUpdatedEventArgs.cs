// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayStatusUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides event data for power state changes in the line display device.</summary>
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LineDisplayStatusUpdatedEventArgs : ILineDisplayStatusUpdatedEventArgs
  {
    /// <summary>Gets the current power status of the device.</summary>
    /// <returns>The current power status of the device.</returns>
    public extern LineDisplayPowerStatus Status { [MethodImpl] get; }
  }
}
