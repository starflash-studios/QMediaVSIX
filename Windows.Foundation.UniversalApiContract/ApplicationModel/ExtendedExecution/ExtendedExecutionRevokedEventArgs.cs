// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.ExtendedExecutionRevokedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution
{
  /// <summary>The object that is passed as a parameter to the event handler that is invoked when the system revokes background execution.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ExtendedExecutionRevokedEventArgs : IExtendedExecutionRevokedEventArgs
  {
    /// <summary>Gets the reason background execution was revoked.</summary>
    /// <returns>The reason background execution was revoked.</returns>
    public extern ExtendedExecutionRevokedReason Reason { [MethodImpl] get; }
  }
}
