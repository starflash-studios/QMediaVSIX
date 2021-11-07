// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.AddDeleteThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides the animated transition behavior for when controls add or delete children of a panel. For example, if you have a collection of photos displayed in a Grid, you can associate this animation to the Grid so that when photos are added or deleted, the photos will animate in and out of view.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class AddDeleteThemeTransition : Transition, IAddDeleteThemeTransition
  {
    /// <summary>Initializes a new instance of the AddDeleteThemeTransition class.</summary>
    [MethodImpl]
    public extern AddDeleteThemeTransition();
  }
}
