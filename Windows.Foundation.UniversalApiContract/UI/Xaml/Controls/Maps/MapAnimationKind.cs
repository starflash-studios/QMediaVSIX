﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapAnimationKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Specifies the animation to use when you change the view of the map. For example, you can specify animation when calling the TrySetViewAsync or TrySetViewBoundsAsync methods.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum MapAnimationKind
  {
    /// <summary>The default animation.</summary>
    Default,
    /// <summary>No animation</summary>
    None,
    /// <summary>A linear animation.</summary>
    Linear,
    /// <summary>A parabolic animation.</summary>
    Bow,
  }
}