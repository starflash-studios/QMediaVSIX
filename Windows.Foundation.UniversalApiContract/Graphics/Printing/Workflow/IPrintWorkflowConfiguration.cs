// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (PrintWorkflowConfiguration))]
  [Guid(3500852461, 64843, 24053, 75, 182, 141, 13, 21, 158, 190, 63)]
  internal interface IPrintWorkflowConfiguration
  {
    string SourceAppDisplayName { get; }

    string JobTitle { get; }

    string SessionId { get; }
  }
}
