﻿// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.IResourceCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  [Guid(2136987145, 48264, 16852, 136, 250, 61, 230, 112, 77, 66, 142)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ResourceCollection))]
  internal interface IResourceCollection : ISyndicationNode
  {
    ISyndicationText Title { get; }

    Uri Uri { get; }

    IVectorView<SyndicationCategory> Categories { get; }

    IVectorView<string> Accepts { get; }
  }
}