// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides information about the status of a point-of-service printer, such as the power state of the printer.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PosPrinterStatus : IPosPrinterStatus
  {
    /// <summary>Gets the power state of a point-of-service printer.</summary>
    /// <returns>The power state of a point-of-service printer.</returns>
    public extern PosPrinterStatusKind StatusKind { [MethodImpl] get; }

    /// <summary>Gets extended information about the power state of the point-of-service printer that the original equipment manufacturer (OEM) defines. Value is only valid if the PosPrinterStatus.StatusKind property is **PosPrinterStatusKind.Extended**.</summary>
    /// <returns>An OEM-defined value that provides extended information about the power state of the point-of-service printer when the value of the PosPrinterStatus.StatusKind property is **PosPrinterStatusKind.Extended**.</returns>
    public extern uint ExtendedStatus { [MethodImpl] get; }
  }
}
