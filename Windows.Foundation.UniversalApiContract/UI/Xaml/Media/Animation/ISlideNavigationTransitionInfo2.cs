﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISlideNavigationTransitionInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (SlideNavigationTransitionInfo))]
  [Guid(2430785984, 23681, 20481, 128, 19, 79, 191, 234, 75, 241, 57)]
  internal interface ISlideNavigationTransitionInfo2
  {
    SlideNavigationTransitionEffect Effect { get; set; }
  }
}