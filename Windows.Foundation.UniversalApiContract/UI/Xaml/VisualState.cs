// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.VisualState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the visual appearance of a UI element when it is in a specific state. Visual states use Setters or a Storyboard to set UI properties within pages or control templates where the VisualState is defined.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Storyboard")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VisualState : DependencyObject, IVisualState, IVisualState2
  {
    /// <summary>Initializes a new instance of the VisualState class.</summary>
    [MethodImpl]
    public extern VisualState();

    /// <summary>Gets the name of the VisualState.</summary>
    /// <returns>The name of the VisualState.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets or sets a Storyboard that defines state-specific property values and appearance of the control when it is using this visual state.</summary>
    /// <returns>A Storyboard that defines the property changes to apply to the control when this VisualState is used as the current visual state.</returns>
    public extern Storyboard Storyboard { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a collection of Setter objects that define discrete property values that control the appearance of UIElement s when this VisualState is applied.</summary>
    /// <returns>A collection of Setter objects. The default is an empty collection.</returns>
    public extern SetterBaseCollection Setters { [MethodImpl] get; }

    /// <summary>Gets a collection of StateTriggerBase objects that indicate when this VisualState should be applied. If any (not all) of the triggers are active, the VisualState will be applied.</summary>
    /// <returns>A collection of StateTriggerBase objects. The default is an empty collection.</returns>
    public extern IVector<StateTriggerBase> StateTriggers { [MethodImpl] get; }
  }
}
