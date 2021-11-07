// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapModel3D
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a 3D object to show on a map.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMapModel3DStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IMapModel3DFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class MapModel3D : DependencyObject, IMapModel3D
  {
    /// <summary>Creates an instance of a MapElement3D.</summary>
    [MethodImpl]
    public extern MapModel3D();

    /// <summary>Creates an instance of a MapModel3D by importing a 3D object from a 3D Manufacturing Format (3MF) file.</summary>
    /// <param name="source">A 3D Manufacturing Format (3MF) file file that describes a 3D object.</param>
    /// <returns>A 3D model object.</returns>
    [Overload("CreateFrom3MFAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapModel3D> CreateFrom3MFAsync(
      IRandomAccessStreamReference source);

    /// <summary>Creates an instance of a MapModel3D by importing a 3D object from a 3D Manufacturing Format (3MF) file.</summary>
    /// <param name="source">A 3D Manufacturing Format (3MF) file file that describes a 3D object.</param>
    /// <param name="shadingOption">The type of shading that you would like to appear for the object.</param>
    /// <returns>A 3D model object.</returns>
    [Overload("CreateFrom3MFWithShadingOptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapModel3D> CreateFrom3MFAsync(
      IRandomAccessStreamReference source,
      MapModel3DShadingOption shadingOption);
  }
}
