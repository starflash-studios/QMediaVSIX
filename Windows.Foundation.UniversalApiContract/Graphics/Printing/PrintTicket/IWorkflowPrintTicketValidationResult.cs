// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.IWorkflowPrintTicketValidationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(181531538, 55931, 18998, 191, 54, 106, 153, 166, 46, 32, 89)]
  [ExclusiveTo(typeof (WorkflowPrintTicketValidationResult))]
  internal interface IWorkflowPrintTicketValidationResult
  {
    bool Validated { get; }

    HResult ExtendedError { get; }
  }
}
