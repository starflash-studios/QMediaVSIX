// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowUILauncher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [ExclusiveTo(typeof (PrintWorkflowUILauncher))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(1693049391, 5324, 22568, 150, 251, 57, 22, 63, 182, 195, 120)]
  internal interface IPrintWorkflowUILauncher
  {
    bool IsUILaunchEnabled();

    [RemoteAsync]
    IAsyncOperation<PrintWorkflowUICompletionStatus> LaunchAndCompleteUIAsync();
  }
}
