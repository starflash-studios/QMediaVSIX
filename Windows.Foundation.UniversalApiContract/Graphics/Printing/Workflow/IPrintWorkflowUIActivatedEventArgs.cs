// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowUIActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [ExclusiveTo(typeof (PrintWorkflowUIActivatedEventArgs))]
  [Guid(3163194445, 2539, 22342, 114, 166, 141, 200, 181, 237, 190, 155)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPrintWorkflowUIActivatedEventArgs : 
    IActivatedEventArgs,
    IActivatedEventArgsWithUser
  {
    PrintWorkflowForegroundSession PrintWorkflowSession { get; }
  }
}
