// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowStreamTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.Workflow
{
  [ExclusiveTo(typeof (PrintWorkflowStreamTarget))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2990258820, 34149, 18571, 152, 57, 28, 158, 124, 122, 169, 22)]
  internal interface IPrintWorkflowStreamTarget
  {
    IOutputStream GetOutputStream();
  }
}
