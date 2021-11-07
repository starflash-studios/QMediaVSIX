// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.WorkflowPrintTicketValidationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  /// <summary>Represents the result of a print ticket validation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  public sealed class WorkflowPrintTicketValidationResult : IWorkflowPrintTicketValidationResult
  {
    /// <summary>Indicates whether the print ticket was found to be valid.</summary>
    /// <returns>**true** if the ticket was valid, **false** if it was invalid.</returns>
    public extern bool Validated { [MethodImpl] get; }

    /// <summary>Gets the error report (if an error occurred) relating to the ticket validation.</summary>
    /// <returns>An HResult for the reported error.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
