﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsPresenterStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2305909550, 30823, 19814, 150, 48, 41, 241, 197, 247, 64, 63)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ItemsPresenter))]
  internal interface IItemsPresenterStatics2
  {
    DependencyProperty FooterProperty { get; }

    DependencyProperty FooterTemplateProperty { get; }

    DependencyProperty FooterTransitionsProperty { get; }
  }
}