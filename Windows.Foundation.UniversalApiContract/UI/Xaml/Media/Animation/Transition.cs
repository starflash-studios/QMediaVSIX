// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.Transition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents a visual behavior that occurs for predefined actions or state changes. Specific theme transitions (various Transition derived classes) can be applied to individual elements using the UIElement.Transitions property, or applied for scenario-specific theme transition properties such as ContentControl.ContentTransitions.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ITransitionFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class Transition : DependencyObject, ITransition
  {
  }
}
