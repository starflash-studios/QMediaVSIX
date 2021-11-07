// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowForegroundSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3348849616, 63724, 19691, 149, 58, 200, 135, 97, 87, 221, 51)]
  [ExclusiveTo(typeof (PrintWorkflowForegroundSession))]
  internal interface IPrintWorkflowForegroundSession
  {
    event TypedEventHandler<PrintWorkflowForegroundSession, PrintWorkflowForegroundSetupRequestedEventArgs> SetupRequested;

    event TypedEventHandler<PrintWorkflowForegroundSession, PrintWorkflowXpsDataAvailableEventArgs> XpsDataAvailable;

    PrintWorkflowSessionStatus Status { get; }

    void Start();
  }
}
