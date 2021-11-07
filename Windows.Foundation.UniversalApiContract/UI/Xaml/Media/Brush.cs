// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Brush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Defines objects used to paint graphical objects. Classes that derive from Brush describe how the area is painted.</summary>
  [Static(typeof (IBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IBrushFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class Brush : DependencyObject, IBrush, IBrushOverrides2, IAnimationObject
  {
    /// <summary>Provides base class initialization behavior for Brush -derived classes.</summary>
    [MethodImpl]
    protected extern Brush();

    /// <summary>Gets or sets the degree of opacity of a Brush.</summary>
    /// <returns>The value of the Opacity property is expressed as a value between 0 and 1.0. The default value is 1.0, which is full opacity. 0 is transparent opacity.</returns>
    public extern double Opacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the transformation that is applied to the brush.</summary>
    /// <returns>The transformation to apply to the brush.</returns>
    public extern Transform Transform { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the transformation that is applied to the brush using relative coordinates.</summary>
    /// <returns>The transformation that is applied to the brush using relative coordinates. The default value is null.</returns>
    public extern Transform RelativeTransform { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern void IBrushOverrides2.PopulatePropertyInfoOverride(
      string propertyName,
      AnimationPropertyInfo animationPropertyInfo);

    /// <summary>Defines a property that can be animated.</summary>
    /// <param name="propertyName">The property that can be animated.</param>
    /// <param name="propertyInfo">Information about the property to be animated.</param>
    [MethodImpl]
    public extern void PopulatePropertyInfo(string propertyName, AnimationPropertyInfo propertyInfo);

    /// <summary>Identifies the Opacity dependency property.</summary>
    /// <returns>The Opacity dependency property identifier.</returns>
    public static extern DependencyProperty OpacityProperty { [MethodImpl] get; }

    /// <summary>Identifies the Transform dependency property.</summary>
    /// <returns>The Transform dependency property identifier.</returns>
    public static extern DependencyProperty TransformProperty { [MethodImpl] get; }

    /// <summary>Identifies the RelativeTransform dependency property.</summary>
    /// <returns>The RelativeTransform dependency property identifier.</returns>
    public static extern DependencyProperty RelativeTransformProperty { [MethodImpl] get; }
  }
}
