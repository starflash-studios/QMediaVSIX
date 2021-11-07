// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.BeginStoryboard
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>A trigger action that begins a Storyboard. Not commonly used. See Remarks.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBeginStoryboardStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Storyboard")]
  [WebHostHidden]
  public sealed class BeginStoryboard : TriggerAction, IBeginStoryboard
  {
    /// <summary>Initializes a new instance of the BeginStoryboard class.</summary>
    [MethodImpl]
    public extern BeginStoryboard();

    /// <summary>Gets or sets the Storyboard that this BeginStoryboard starts.</summary>
    /// <returns>The Storyboard that the BeginStoryboard starts. The default is null.</returns>
    public extern Storyboard Storyboard { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the BeginStoryboard.Storyboard  dependency property.</summary>
    /// <returns>The identifier for the BeginStoryboard.Storyboard  dependency property.</returns>
    public static extern DependencyProperty StoryboardProperty { [MethodImpl] get; }
  }
}
