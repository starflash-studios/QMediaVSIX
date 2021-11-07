// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.GeographicRegion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  /// <summary>Describes a region. This is usually a country, but may be a macroregion.</summary>
  [Static(typeof (IGeographicRegionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IGeographicRegionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class GeographicRegion : IGeographicRegion
  {
    /// <summary>Creates a GeographicRegion object.</summary>
    /// <param name="geographicRegionCode">One of the ISO 3166-1 two-letter or three-letter codes that identify the country, or one of the three-digit UN-M49 codes that identify the geographical region.</param>
    [MethodImpl]
    public extern GeographicRegion(string geographicRegionCode);

    /// <summary>Creates a GeographicRegion object that defaults to the user's home region.</summary>
    [MethodImpl]
    public extern GeographicRegion();

    /// <summary>Gets the string that contains the best available identifier that represents the region.</summary>
    /// <returns>Returns a string that contains:</returns>
    public extern string Code { [MethodImpl] get; }

    /// <summary>Gets the two-letter identifier for this region.</summary>
    /// <returns>Returns the two-letter ISO 3166-1 alpha-2 code for this region, if one exists; otherwise, returns "ZZ".</returns>
    public extern string CodeTwoLetter { [MethodImpl] get; }

    /// <summary>Gets the three-letter identifier for this region.</summary>
    /// <returns>Returns the three-letter ISO 3166-1 alpha-3 code for this region, if one exists; otherwise, returns "ZZZ".</returns>
    public extern string CodeThreeLetter { [MethodImpl] get; }

    /// <summary>Gets the three-digit identifier for this region, as a string.</summary>
    /// <returns>Returns as a string the ISO-3166-1 numeric three-digit code for the region, or the UN-M49 code. If the region is unknown, returns "999".</returns>
    public extern string CodeThreeDigit { [MethodImpl] get; }

    /// <summary>Gets a localized string that is suitable for display to the user for identifying the region.</summary>
    /// <returns>The localized name of the region.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the name of the region in the primary language spoken in this region.</summary>
    /// <returns>The name of the region in the primary language spoken in this region.</returns>
    public extern string NativeName { [MethodImpl] get; }

    /// <summary>Gets the set of currencies in use in this region.</summary>
    /// <returns>The set of ISO 4217 3-letter codes for the currencies that are used in the region.</returns>
    public extern IVectorView<string> CurrenciesInUse { [MethodImpl] get; }

    /// <summary>Determines whether a geographic region identifier is supported.</summary>
    /// <param name="geographicRegionCode">One of the ISO 3166-1 two-letter or three-letter codes that identify the country, or one of the three-digit UN-M49 codes that identify the geographical region.</param>
    /// <returns>**True** if the ID is known; otherwise, ** false**. If this method returns **true**, an app can safely construct a region by using this region identifier. If it returns **false**, attempting to construct a region for the given code will throw an exception.</returns>
    [MethodImpl]
    public static extern bool IsSupported(string geographicRegionCode);
  }
}
