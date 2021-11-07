// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.XamlLight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides a base class used to create XAML lights that use a CompositionLight to apply lighting effects to XAML elements and brushes.</summary>
  [Static(typeof (IXamlLightStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Composable(typeof (IXamlLightFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class XamlLight : DependencyObject, IXamlLight, IXamlLightProtected, IXamlLightOverrides
  {
    /// <summary>Initializes a new instance of the **XamlLight** class.</summary>
    [MethodImpl]
    public extern XamlLight();

    extern CompositionLight IXamlLightProtected.CompositionLight { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern string IXamlLightOverrides.GetId();

    [MethodImpl]
    extern void IXamlLightOverrides.OnConnected(UIElement newElement);

    [MethodImpl]
    extern void IXamlLightOverrides.OnDisconnected(UIElement oldElement);

    /// <summary>Sets a UIElement as a target of a XamlLight.</summary>
    /// <param name="lightId">The identifier for the XamlLight that should target the UIElement.</param>
    /// <param name="element">The UIElement that the light should target.</param>
    [MethodImpl]
    public static extern void AddTargetElement(string lightId, UIElement element);

    /// <summary>Stops a UIElement from being a target of a XamlLight.</summary>
    /// <param name="lightId">The identifier for the XamlLight that should no longer target the UIElement.</param>
    /// <param name="element">The UIElement that the light should no longer target.</param>
    [MethodImpl]
    public static extern void RemoveTargetElement(string lightId, UIElement element);

    /// <summary>Sets a Brush as a target of a XamlLight.</summary>
    /// <param name="lightId">The identifier for the XamlLight that should target the Brush.</param>
    /// <param name="brush">The Brush that the light should target.</param>
    [MethodImpl]
    public static extern void AddTargetBrush(string lightId, Brush brush);

    /// <summary>Stops a Brush from being a target of a XamlLight.</summary>
    /// <param name="lightId">The identifier for the XamlLight that should no longer target the Brush.</param>
    /// <param name="brush">The Brush that the light should no longer target.</param>
    [MethodImpl]
    public static extern void RemoveTargetBrush(string lightId, Brush brush);
  }
}
