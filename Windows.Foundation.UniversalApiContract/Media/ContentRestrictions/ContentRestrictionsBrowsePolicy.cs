// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.ContentRestrictionsBrowsePolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  /// <summary>Contains information used to filter an app's content catalog.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContentRestrictionsBrowsePolicy : IContentRestrictionsBrowsePolicy
  {
    /// <summary>Gets the region of the user's content restrictions.</summary>
    /// <returns>A String, representing the geographic region.</returns>
    public extern string GeographicRegion { [MethodImpl] get; }

    /// <summary>Gets the maximum allowed age rating level to show in a content catalog. No content rated above this level should be displayed. For example, if the **MaxBrowsableAgeRating** is 13, MPAA:R rated movies should not be displayed.</summary>
    /// <returns>An integer, that represents an age.</returns>
    public extern IReference<uint> MaxBrowsableAgeRating { [MethodImpl] get; }

    /// <summary>Gets the maximum allowed rating level for content consumption.</summary>
    /// <returns>An integer that represents the rating level.</returns>
    public extern IReference<uint> PreferredAgeRating { [MethodImpl] get; }
  }
}
