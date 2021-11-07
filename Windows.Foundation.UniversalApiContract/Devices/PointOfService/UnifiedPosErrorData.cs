// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.UnifiedPosErrorData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides error information.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IUnifiedPosErrorDataFactory), 393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class UnifiedPosErrorData : IUnifiedPosErrorData
  {
    /// <summary>Creates an instance for UnifiedPosErrorData.</summary>
    /// <param name="message">The error message.</param>
    /// <param name="severity">The error severity.</param>
    /// <param name="reason">The cause of the error.</param>
    /// <param name="extendedReason">The vendor specific error information.</param>
    [MethodImpl]
    public extern UnifiedPosErrorData(
      string message,
      UnifiedPosErrorSeverity severity,
      UnifiedPosErrorReason reason,
      uint extendedReason);

    /// <summary>Gets the error message.</summary>
    /// <returns>The error message.</returns>
    public extern string Message { [MethodImpl] get; }

    /// <summary>Gets the error severity.</summary>
    /// <returns>The error severity.</returns>
    public extern UnifiedPosErrorSeverity Severity { [MethodImpl] get; }

    /// <summary>Gets the cause of the error.</summary>
    /// <returns>The cause of the error.</returns>
    public extern UnifiedPosErrorReason Reason { [MethodImpl] get; }

    /// <summary>Gets the vendor specific error information.</summary>
    /// <returns>The vendor specific error information.</returns>
    public extern uint ExtendedReason { [MethodImpl] get; }
  }
}
