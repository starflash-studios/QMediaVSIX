// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GeometryGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a composite geometry, composed of other Geometry objects.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContentProperty(Name = "Children")]
  [Static(typeof (IGeometryGroupStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class GeometryGroup : Geometry, IGeometryGroup
  {
    /// <summary>Initializes a new instance of the GeometryGroup class.</summary>
    [MethodImpl]
    public extern GeometryGroup();

    /// <summary>Gets or sets how the intersecting areas of the objects contained in this GeometryGroup are combined.</summary>
    /// <returns>One of the enumeration values that specifies how the intersecting areas are combined to form the resulting area. The default is **EvenOdd**.</returns>
    public extern FillRule FillRule { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the GeometryCollection that contains the objects that define this GeometryGroup.</summary>
    /// <returns>A collection containing the children of this GeometryGroup.</returns>
    public extern GeometryCollection Children { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the FillRule dependency property.</summary>
    /// <returns>The identifier for the FillRule dependency property.</returns>
    public static extern DependencyProperty FillRuleProperty { [MethodImpl] get; }

    /// <summary>Identifies the Children dependency property.</summary>
    /// <returns>The identifier for the Children dependency property.</returns>
    public static extern DependencyProperty ChildrenProperty { [MethodImpl] get; }
  }
}
