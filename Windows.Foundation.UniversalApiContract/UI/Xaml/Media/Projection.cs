// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Projection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides a base class for projections, which describe how to transform an object in 3-D space using perspective transforms.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IProjectionFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class Projection : DependencyObject, IProjection
  {
    /// <summary>Provides base class initialization behavior for Projection -derived classes.</summary>
    [MethodImpl]
    protected extern Projection();
  }
}
