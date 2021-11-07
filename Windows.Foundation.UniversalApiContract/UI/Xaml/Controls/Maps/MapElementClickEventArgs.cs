// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs
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
  /// <summary>Provides data for the MapElementClick event.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MapElementClickEventArgs : IMapElementClickEventArgs
  {
    /// <summary>Initializes a new instance of the MapElementClickEventArgs class.</summary>
    [MethodImpl]
    public extern MapElementClickEventArgs();

    /// <summary>Gets the physical position on the MapControl where it received user input.</summary>
    /// <returns>The physical position on the MapControl where it received user input, in terms of X and Y coordinates.</returns>
    public extern Point Position { [MethodImpl] get; }

    /// <summary>Gets the geographic location that corresponds to where the MapControl received user input.</summary>
    /// <returns>The geographic location that corresponds to where the MapControl received user input.</returns>
    public extern Geopoint Location { [MethodImpl] get; }

    /// <summary>Gets a list of map elements that correspond to where the MapControl received user input.</summary>
    /// <returns>A list of map elements that correspond to where the MapControl received user input.</returns>
    public extern IVector<MapElement> MapElements { [MethodImpl] get; }
  }
}
