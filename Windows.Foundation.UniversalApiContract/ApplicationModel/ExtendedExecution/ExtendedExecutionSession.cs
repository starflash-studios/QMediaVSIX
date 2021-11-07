// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.ExtendedExecutionSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution
{
  /// <summary>Supports managing a request for background execution. For more information on how to use Extended Execution, see Run while minimized with Extended Execution</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ExtendedExecutionSession : IExtendedExecutionSession, IClosable
  {
    /// <summary>Creates an **ExtendedExecutionSession** object.</summary>
    [MethodImpl]
    public extern ExtendedExecutionSession();

    /// <summary>Gets or sets the reason for the for the background execution request.</summary>
    /// <returns>The reason for the for the background execution request.</returns>
    public extern ExtendedExecutionReason Reason { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>This property is not used in the current release.</summary>
    /// <returns>This property is not used in the current release.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>This property is not used in the current release.</summary>
    /// <returns>This property is not used in the current release.</returns>
    public extern uint PercentProgress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The **Revoked** event occurs when the system revokes background execution.</summary>
    public extern event TypedEventHandler<object, ExtendedExecutionRevokedEventArgs> Revoked;

    /// <summary>Requests background execution.</summary>
    /// <returns>The result of the request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ExtendedExecutionResult> RequestExtensionAsync();

    [MethodImpl]
    public extern void Close();
  }
}
