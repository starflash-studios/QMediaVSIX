// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.IServiceDocument
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  [ExclusiveTo(typeof (ServiceDocument))]
  [Guid(2340341617, 10931, 19902, 139, 204, 119, 143, 146, 183, 94, 81)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IServiceDocument : ISyndicationNode
  {
    IVectorView<Workspace> Workspaces { get; }
  }
}
