﻿// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowBackgroundSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [Guid(1534661562, 3166, 21130, 116, 88, 134, 164, 108, 189, 220, 69)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (PrintWorkflowBackgroundSession))]
  internal interface IPrintWorkflowBackgroundSession
  {
    event TypedEventHandler<PrintWorkflowBackgroundSession, PrintWorkflowBackgroundSetupRequestedEventArgs> SetupRequested;

    event TypedEventHandler<PrintWorkflowBackgroundSession, PrintWorkflowSubmittedEventArgs> Submitted;

    PrintWorkflowSessionStatus Status { get; }

    void Start();
  }
}