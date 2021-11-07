// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.BrushTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides the animated transition behavior when an element's brush changes. Currently limited to changes between SolidColorBrush objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Composable(typeof (IBrushTransitionFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class BrushTransition : IBrushTransition
  {
    /// <summary>Initializes a new instance of the BrushTransition class.</summary>
    [MethodImpl]
    public extern BrushTransition();

    /// <summary>Gets or sets the duration of the transition.</summary>
    /// <returns>The duration of the transition.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }
  }
}
