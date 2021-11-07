// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ConnectedAnimationComponent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Defines constants that specify the component animations that make up a connected animation.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum ConnectedAnimationComponent
  {
    /// <summary>The X component of the translation animation.</summary>
    OffsetX,
    /// <summary>The Y component of the translation animation.</summary>
    OffsetY,
    /// <summary>The crossfade animation.</summary>
    CrossFade,
    /// <summary>The scale animation.</summary>
    Scale,
  }
}
