﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlStatics7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(2934032965, 51472, 23979, 162, 102, 253, 245, 12, 11, 237, 210)]
  [ExclusiveTo(typeof (Control))]
  internal interface IControlStatics7
  {
    DependencyProperty BackgroundSizingProperty { get; }

    DependencyProperty CornerRadiusProperty { get; }
  }
}