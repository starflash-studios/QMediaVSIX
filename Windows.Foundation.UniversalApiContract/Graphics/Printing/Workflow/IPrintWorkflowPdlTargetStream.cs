// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowPdlTargetStream
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.Workflow
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(2806177765, 7907, 21161, 159, 159, 46, 32, 67, 24, 15, 209)]
  [ExclusiveTo(typeof (PrintWorkflowPdlTargetStream))]
  internal interface IPrintWorkflowPdlTargetStream
  {
    IOutputStream GetOutputStream();

    void CompleteStreamSubmission(PrintWorkflowSubmittedStatus status);
  }
}
