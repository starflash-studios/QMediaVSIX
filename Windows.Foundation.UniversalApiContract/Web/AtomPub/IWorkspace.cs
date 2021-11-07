// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.IWorkspace
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  [ExclusiveTo(typeof (Workspace))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3021841979, 42168, 16438, 137, 197, 131, 195, 18, 102, 186, 73)]
  internal interface IWorkspace : ISyndicationNode
  {
    ISyndicationText Title { get; }

    IVectorView<ResourceCollection> Collections { get; }
  }
}
