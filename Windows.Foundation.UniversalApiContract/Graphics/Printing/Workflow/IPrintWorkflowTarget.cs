// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [ExclusiveTo(typeof (PrintWorkflowTarget))]
  [Guid(702162796, 2675, 23277, 79, 61, 151, 13, 50, 81, 240, 87)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPrintWorkflowTarget
  {
    PrintWorkflowStreamTarget TargetAsStream { get; }

    PrintWorkflowObjectModelTargetPackage TargetAsXpsObjectModelPackage { get; }
  }
}
