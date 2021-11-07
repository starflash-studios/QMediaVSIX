// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ScalarTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides the animated transition behavior when an element's Opacity or Rotation properties change.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Composable(typeof (IScalarTransitionFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ScalarTransition : IScalarTransition
  {
    /// <summary>Initializes a new instance of the ScalarTransition class.</summary>
    [MethodImpl]
    public extern ScalarTransition();

    /// <summary>Gets or sets the duration of the transition.</summary>
    /// <returns>The duration of the transition.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }
  }
}
