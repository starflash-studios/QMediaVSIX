// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Matrix3DProjection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Applies a Matrix3D projection to an object.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMatrix3DProjectionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "ProjectionMatrix")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Matrix3DProjection : Projection, IMatrix3DProjection
  {
    /// <summary>Initializes a new instance of a Matrix3DProjection class.</summary>
    [MethodImpl]
    public extern Matrix3DProjection();

    /// <summary>Gets or sets the Matrix3D that is used for the projection that is applied to the object.</summary>
    /// <returns>The Matrix3D that is used for the projection that is applied to the object.</returns>
    public extern Matrix3D ProjectionMatrix { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the ProjectionMatrix dependency property.</summary>
    /// <returns>The identifier for the ProjectionMatrix dependency property.</returns>
    public static extern DependencyProperty ProjectionMatrixProperty { [MethodImpl] get; }
  }
}
