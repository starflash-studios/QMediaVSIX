// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapContextRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides event data for the MapContextRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class MapContextRequestedEventArgs : IMapContextRequestedEventArgs
  {
    /// <summary>Initializes a new instance of the MapContextRequestedEventArgs class.</summary>
    [MethodImpl]
    public extern MapContextRequestedEventArgs();

    /// <summary>Gets the x- and y-coordinate values that define the point on the map of a context input gesture, such as a right-click.</summary>
    /// <returns>The x- and y-coordinate values that define the point on the map of a context input gesture, such as a right-click.</returns>
    public extern Point Position { [MethodImpl] get; }

    /// <summary>Gets a geolocation on the map of a context input gesture, such as a right-click.</summary>
    /// <returns>The geolocation on the map of a context input gesture, such as a right-click.</returns>
    public extern Geopoint Location { [MethodImpl] get; }

    /// <summary>Gets a collection of MapElement objects at the point on the map specified by the Location property.</summary>
    /// <returns>A collection of MapElement objects at the point on the map specified by the Location property.</returns>
    public extern IVectorView<MapElement> MapElements { [MethodImpl] get; }
  }
}
