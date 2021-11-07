// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Defines constants that describe the type of animation to play during a slide transition.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  public enum SlideNavigationTransitionEffect
  {
    /// <summary>The exiting page fades out and the entering page enters from the bottom.</summary>
    FromBottom,
    /// <summary>The exiting page leaves to the right of the panel and the entering page enters from the left.</summary>
    FromLeft,
    /// <summary>The exiting page leaves to the left of the panel and the entering page enters from the right.</summary>
    FromRight,
  }
}
