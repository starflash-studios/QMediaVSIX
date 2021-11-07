// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowJobActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [ExclusiveTo(typeof (PrintWorkflowJobActivatedEventArgs))]
  [Guid(3569180269, 846, 24064, 166, 22, 249, 97, 160, 51, 220, 200)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IPrintWorkflowJobActivatedEventArgs
  {
    PrintWorkflowJobUISession Session { get; }
  }
}
