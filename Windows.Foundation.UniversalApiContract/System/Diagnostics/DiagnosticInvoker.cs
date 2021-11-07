// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DiagnosticInvoker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  /// <summary>Contains functionality for executing a diagnostics troubleshooting package.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDiagnosticInvokerStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class DiagnosticInvoker : IDiagnosticInvoker, IDiagnosticInvoker2
  {
    /// <summary>Asynchronously runs the diagnostics invoker with the specified diagnostics context.</summary>
    /// <param name="context">A Json object containing the context for the diagnostics action.</param>
    /// <returns>Returns an async operation object that indicates when the action has completed. A DiagnosticActionState enum value is in the result.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DiagnosticActionResult, DiagnosticActionState> RunDiagnosticActionAsync(
      JsonObject context);

    /// <summary>Asynchronously runs the diagnostics invoker with the specified diagnostics context.</summary>
    /// <param name="context">A string containing the context for the diagnostics action.</param>
    /// <returns>Returns an async operation object that indicates when the action has completed. A DiagnosticActionState enum value is in the result.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DiagnosticActionResult, DiagnosticActionState> RunDiagnosticActionFromStringAsync(
      string context);

    /// <summary>Gets the default diagnostics invoker.</summary>
    /// <returns>Returns the default diagnostics invoker.</returns>
    [MethodImpl]
    public static extern DiagnosticInvoker GetDefault();

    /// <summary>Gets the diagnostics invoker for the specified user.</summary>
    /// <param name="user">The user for which to get the diagnostics invoker.</param>
    /// <returns>Returns the diagnostics invoker for the specified *user*.</returns>
    [MethodImpl]
    public static extern DiagnosticInvoker GetForUser(User user);

    /// <summary>Gets a Boolean value indicating if the diagnostics invoker is supported.</summary>
    /// <returns>A Boolean value indicating if the diagnostics invoker is supported.</returns>
    public static extern bool IsSupported { [MethodImpl] get; }
  }
}
