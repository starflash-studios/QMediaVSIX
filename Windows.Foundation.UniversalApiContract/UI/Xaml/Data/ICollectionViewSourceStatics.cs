﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICollectionViewSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CollectionViewSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(389678864, 18095, 19468, 129, 139, 33, 182, 239, 129, 191, 101)]
  internal interface ICollectionViewSourceStatics
  {
    DependencyProperty SourceProperty { get; }

    DependencyProperty ViewProperty { get; }

    DependencyProperty IsSourceGroupedProperty { get; }

    DependencyProperty ItemsPathProperty { get; }
  }
}