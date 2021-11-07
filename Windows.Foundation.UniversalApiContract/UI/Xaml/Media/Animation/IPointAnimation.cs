﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPointAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (PointAnimation))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(821052178, 30502, 20360, 184, 226, 47, 165, 69, 24, 150, 59)]
  internal interface IPointAnimation
  {
    IReference<Point> From { get; set; }

    IReference<Point> To { get; set; }

    IReference<Point> By { get; set; }

    EasingFunctionBase EasingFunction { get; set; }

    bool EnableDependentAnimation { get; set; }
  }
}