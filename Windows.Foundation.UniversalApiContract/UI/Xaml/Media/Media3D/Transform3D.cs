// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.Transform3D
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  /// <summary>The base class for the CompositeTransform3D and PerspectiveTransform3D classes.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ITransform3DFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  public class Transform3D : DependencyObject, ITransform3D
  {
    /// <summary>Initializes a new instance of the Transform3D class.</summary>
    [MethodImpl]
    protected extern Transform3D();
  }
}
