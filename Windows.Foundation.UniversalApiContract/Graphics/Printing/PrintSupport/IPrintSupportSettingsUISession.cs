// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintSupport.IPrintSupportSettingsUISession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;

namespace Windows.Graphics.Printing.PrintSupport
{
  [Guid(3336184401, 33731, 21988, 160, 248, 93, 232, 176, 98, 173, 191)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (PrintSupportSettingsUISession))]
  internal interface IPrintSupportSettingsUISession
  {
    WorkflowPrintTicket SessionPrintTicket { get; }

    string DocumentTitle { get; }

    SettingsLaunchKind LaunchKind { get; }

    void UpdatePrintTicket(WorkflowPrintTicket printTicket);

    PrintSupportSessionInfo SessionInfo { get; }
  }
}
