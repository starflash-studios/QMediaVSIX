﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDragOverThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(1928815351, 32337, 19051, 185, 55, 220, 75, 76, 28, 84, 88)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DragOverThemeAnimation))]
  internal interface IDragOverThemeAnimation
  {
    string TargetName { get; set; }

    double ToOffset { get; set; }

    AnimationDirection Direction { get; set; }
  }
}