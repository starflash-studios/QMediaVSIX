﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IImageStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Image))]
  [Guid(2307929970, 49974, 17361, 157, 81, 195, 187, 213, 213, 214, 145)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IImageStatics
  {
    DependencyProperty SourceProperty { get; }

    DependencyProperty StretchProperty { get; }

    DependencyProperty NineGridProperty { get; }

    DependencyProperty PlayToSourceProperty { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}