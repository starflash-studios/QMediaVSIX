// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapInputEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides data about user input for the MapTapped, MapDoubleTapped, and MapHolding events of the MapControl.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapInputEventArgs : DependencyObject, IMapInputEventArgs
  {
    /// <summary>Initializes a new instance of the MapInputEventArgs class.</summary>
    [MethodImpl]
    public extern MapInputEventArgs();

    /// <summary>Gets the physical location on the MapControl that received user input.</summary>
    /// <returns>The physical location on the MapControl that received user input.</returns>
    public extern Point Position { [MethodImpl] get; }

    /// <summary>Gets the geographic location on the MapControl that received user input.</summary>
    /// <returns>The geographic location on the MapControl that received user input.</returns>
    public extern Geopoint Location { [MethodImpl] get; }
  }
}
