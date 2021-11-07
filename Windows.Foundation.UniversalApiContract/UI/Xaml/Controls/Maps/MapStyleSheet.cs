// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapStyleSheet
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a set of rules that define the style of the map in a map control. This class provides methods to:</summary>
  [Static(typeof (IMapStyleSheetStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MapStyleSheet : DependencyObject, IMapStyleSheet
  {
    /// <summary>Gets a MapStyleSheet that presents an aerial view of the map.</summary>
    /// <returns>A MapStyleSheet that presents an aerial view of the map.</returns>
    [MethodImpl]
    public static extern MapStyleSheet Aerial();

    /// <summary>Gets a MapStyleSheet that presents a hybrid map that combines an aerial map with roads.</summary>
    /// <returns>A MapStyleSheet that presents a hybrid map that combines an aerial map with roads.</returns>
    [MethodImpl]
    public static extern MapStyleSheet AerialWithOverlay();

    /// <summary>Gets a MapStyleSheet that presents a road map with a light theme.</summary>
    /// <returns>A MapStyleSheet that presents a road map with a light theme.</returns>
    [MethodImpl]
    public static extern MapStyleSheet RoadLight();

    /// <summary>Gets a MapStyleSheet that presents a road map with a dark theme.</summary>
    /// <returns>A MapStyleSheet that presents a road map with a dark theme.</returns>
    [MethodImpl]
    public static extern MapStyleSheet RoadDark();

    /// <summary>Gets a MapStyleSheet styles the map with a high contrast light theme.</summary>
    /// <returns>A MapStyleSheet styles the map with a high contrast light theme.</returns>
    [MethodImpl]
    public static extern MapStyleSheet RoadHighContrastLight();

    /// <summary>Gets a MapStyleSheet styles the map with a high contrast dark theme.</summary>
    /// <returns>A MapStyleSheet styles the map with a high contrast dark theme.</returns>
    [MethodImpl]
    public static extern MapStyleSheet RoadHighContrastDark();

    [MethodImpl]
    public static extern MapStyleSheet Combine(IIterable<MapStyleSheet> styleSheets);

    /// <summary>Creates a stylesheet by parsing a JSON markup string that defines a set of custom rules.</summary>
    /// <param name="styleAsJson">A JSON markup string that defines a set of custom rules.</param>
    /// <returns>A MapStyleSheet that represents the rules defined in JSON markup string.</returns>
    [MethodImpl]
    public static extern MapStyleSheet ParseFromJson(string styleAsJson);

    /// <summary>Creates stylesheet by parsing a JSON markup string that defines a set of custom rules.</summary>
    /// <param name="styleAsJson">A JSON markup string that defines a set of custom rules.</param>
    /// <param name="styleSheet">The MapStyleSheet that will represent the rules defined in JSON markup string.</param>
    /// <returns>**true** if the operation completed successfully; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParseFromJson(string styleAsJson, out MapStyleSheet styleSheet);
  }
}
