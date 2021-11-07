// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTileAnimationState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Specifies the AnimationState of the MapTileSource.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum MapTileAnimationState
  {
    /// <summary>The map tile animation is not playing or paused.</summary>
    Stopped,
    /// <summary>The map tile animation is paused. If the MapTileSource was playing an animation, it continues to display the current frame.</summary>
    Paused,
    /// <summary>The map tile animation is playing.</summary>
    Playing,
  }
}
