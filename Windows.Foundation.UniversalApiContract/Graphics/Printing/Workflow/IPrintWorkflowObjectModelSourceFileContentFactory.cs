// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowObjectModelSourceFileContentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.Workflow
{
  [ExclusiveTo(typeof (PrintWorkflowObjectModelSourceFileContent))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(2477897987, 61459, 22230, 183, 8, 153, 172, 44, 203, 18, 238)]
  internal interface IPrintWorkflowObjectModelSourceFileContentFactory
  {
    PrintWorkflowObjectModelSourceFileContent CreateInstance(
      IInputStream xpsStream);
  }
}
