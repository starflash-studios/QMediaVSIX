// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.IRatedContentRestrictions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  [ExclusiveTo(typeof (RatedContentRestrictions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1065296843, 47623, 17409, 164, 157, 139, 146, 34, 32, 87, 35)]
  internal interface IRatedContentRestrictions
  {
    [RemoteAsync]
    IAsyncOperation<ContentRestrictionsBrowsePolicy> GetBrowsePolicyAsync();

    IAsyncOperation<ContentAccessRestrictionLevel> GetRestrictionLevelAsync(
      RatedContentDescription RatedContentDescription);

    IAsyncOperation<bool> RequestContentAccessAsync(
      RatedContentDescription RatedContentDescription);

    event EventHandler<object> RestrictionsChanged;
  }
}
