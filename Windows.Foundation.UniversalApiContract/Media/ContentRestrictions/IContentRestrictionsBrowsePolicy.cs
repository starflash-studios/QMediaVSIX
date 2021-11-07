// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.IContentRestrictionsBrowsePolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  [Guid(2348888996, 17454, 17946, 135, 87, 250, 210, 245, 189, 55, 228)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentRestrictionsBrowsePolicy))]
  internal interface IContentRestrictionsBrowsePolicy
  {
    string GeographicRegion { get; }

    IReference<uint> MaxBrowsableAgeRating { get; }

    IReference<uint> PreferredAgeRating { get; }
  }
}
