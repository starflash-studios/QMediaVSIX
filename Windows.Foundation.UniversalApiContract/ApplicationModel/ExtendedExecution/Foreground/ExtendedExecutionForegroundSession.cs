// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.Foreground.ExtendedExecutionForegroundSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution.Foreground
{
  /// <summary>Supports managing a request for extended execution. This API requires the use of restricted capabilities and cannot be used for Store applications.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ExtendedExecutionForegroundSession : 
    IExtendedExecutionForegroundSession,
    IClosable
  {
    /// <summary>Creates an ExtendedExecutionForegroundSession object</summary>
    [MethodImpl]
    public extern ExtendedExecutionForegroundSession();

    /// <summary>Gets or sets a string to display in the shell.</summary>
    /// <returns>A string to display in the shell.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>This event occurs when the system revokes extended execution.</summary>
    public extern event TypedEventHandler<object, ExtendedExecutionForegroundRevokedEventArgs> Revoked;

    /// <summary>Requests extended execution</summary>
    /// <returns>The result of the request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ExtendedExecutionForegroundResult> RequestExtensionAsync();

    /// <summary>Gets or sets the reason for the extended execution request.</summary>
    /// <returns>The reason for the for the extended execution request.</returns>
    public extern ExtendedExecutionForegroundReason Reason { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Close();
  }
}
