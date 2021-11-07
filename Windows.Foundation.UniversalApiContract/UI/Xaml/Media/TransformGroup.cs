// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TransformGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a composite Transform composed of other Transform objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "Children")]
  [Static(typeof (ITransformGroupStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class TransformGroup : Transform, ITransformGroup
  {
    /// <summary>Initializes a new instance of the TransformGroup class.</summary>
    [MethodImpl]
    public extern TransformGroup();

    /// <summary>Gets or sets the collection of child Transform objects.</summary>
    /// <returns>The collection of child Transform objects. The default is an empty collection.</returns>
    public extern TransformCollection Children { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the Matrix structure that describes the transformation represented by this TransformGroup.</summary>
    /// <returns>A composite of the Transform objects in this TransformGroup.</returns>
    public extern Matrix Value { [MethodImpl] get; }

    /// <summary>Identifies the Children dependency property.</summary>
    /// <returns>The identifier for the Children dependency property.</returns>
    public static extern DependencyProperty ChildrenProperty { [MethodImpl] get; }
  }
}
