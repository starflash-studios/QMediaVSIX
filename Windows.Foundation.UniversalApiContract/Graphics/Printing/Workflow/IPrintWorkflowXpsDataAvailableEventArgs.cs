// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowXpsDataAvailableEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [ExclusiveTo(typeof (PrintWorkflowXpsDataAvailableEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1293009713, 21713, 17230, 190, 14, 130, 197, 250, 88, 229, 178)]
  internal interface IPrintWorkflowXpsDataAvailableEventArgs
  {
    PrintWorkflowSubmittedOperation Operation { get; }

    Deferral GetDeferral();
  }
}
