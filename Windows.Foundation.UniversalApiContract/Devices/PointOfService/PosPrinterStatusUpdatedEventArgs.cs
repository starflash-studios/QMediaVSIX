// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterStatusUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides information about the PosPrinter.StatusUpdated event that occurs when the status of a point-of-service printer changes.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class PosPrinterStatusUpdatedEventArgs : IPosPrinterStatusUpdatedEventArgs
  {
    /// <summary>Gets the new status of the point-of-service printer after the status of the printer changes.</summary>
    /// <returns>The new status of the point-of-service printer after the status of the printer changes.</returns>
    public extern PosPrinterStatus Status { [MethodImpl] get; }
  }
}
