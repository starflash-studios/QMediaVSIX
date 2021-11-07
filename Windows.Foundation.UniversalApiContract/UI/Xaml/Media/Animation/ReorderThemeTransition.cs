// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ReorderThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides the animated transition behavior for when list-view controls items change order. Typically this is due to a drag-drop operation. Different controls and themes potentially have varying characteristics for the animations involved.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ReorderThemeTransition : Transition, IReorderThemeTransition
  {
    /// <summary>Initializes a new instance of the ReorderThemeTransition class.</summary>
    [MethodImpl]
    public extern ReorderThemeTransition();
  }
}
