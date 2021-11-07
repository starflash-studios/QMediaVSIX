// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowSpoolStreamContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.Workflow
{
  [Guid(1927634638, 58374, 19316, 132, 225, 63, 243, 253, 205, 175, 112)]
  [ExclusiveTo(typeof (PrintWorkflowSpoolStreamContent))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPrintWorkflowSpoolStreamContent
  {
    IInputStream GetInputStream();
  }
}
