// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowObjectModelSourceFileContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Represents print content in the form of the COM-based XPS object model.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IPrintWorkflowObjectModelSourceFileContentFactory), 851968, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintWorkflowObjectModelSourceFileContent : 
    IPrintWorkflowObjectModelSourceFileContent
  {
    [MethodImpl]
    public extern PrintWorkflowObjectModelSourceFileContent(IInputStream xpsStream);
  }
}
