﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGridViewItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (GridViewItem))]
  [Guid(580583599, 16294, 17385, 151, 157, 7, 234, 13, 98, 128, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGridViewItemFactory
  {
    GridViewItem CreateInstance(object baseInterface, out object innerInterface);
  }
}