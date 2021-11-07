// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowJobUISession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(13136747, 30263, 22151, 163, 2, 15, 102, 77, 42, 172, 101)]
  [ExclusiveTo(typeof (PrintWorkflowJobUISession))]
  internal interface IPrintWorkflowJobUISession
  {
    PrintWorkflowSessionStatus Status { get; }

    event TypedEventHandler<PrintWorkflowJobUISession, PrintWorkflowPdlDataAvailableEventArgs> PdlDataAvailable;

    event TypedEventHandler<PrintWorkflowJobUISession, PrintWorkflowJobNotificationEventArgs> JobNotification;

    void Start();
  }
}
