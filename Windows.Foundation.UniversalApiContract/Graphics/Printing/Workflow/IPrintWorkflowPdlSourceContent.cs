// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowPdlSourceContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.Workflow
{
  [ExclusiveTo(typeof (PrintWorkflowPdlSourceContent))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(2465725505, 12984, 22187, 132, 94, 177, 230, 139, 58, 237, 213)]
  internal interface IPrintWorkflowPdlSourceContent
  {
    string ContentType { get; }

    IInputStream GetInputStream();

    [RemoteAsync]
    IAsyncOperation<StorageFile> GetContentFileAsync();
  }
}
