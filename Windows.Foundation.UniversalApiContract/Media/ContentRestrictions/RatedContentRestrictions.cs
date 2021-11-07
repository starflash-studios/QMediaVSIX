// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.RatedContentRestrictions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  /// <summary>Contains all behavior and functionality related to a user's Family Safety content settings.</summary>
  [Activatable(typeof (IRatedContentRestrictionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RatedContentRestrictions : IRatedContentRestrictions
  {
    /// <summary>Initializes a new instance of the **RatedContentRestrictions** class, with the specified age rating the app uses, to restrict content usage.</summary>
    /// <param name="maxAgeRating">The max age rating.</param>
    [MethodImpl]
    public extern RatedContentRestrictions(uint maxAgeRating);

    /// <summary>Initializes a new instance of the **RatedContentRestrictions** class.</summary>
    [MethodImpl]
    public extern RatedContentRestrictions();

    /// <summary>Gets information that is used filter an app's content catalog.</summary>
    /// <returns>Returns a ContentRestrictionsBrowsePolicy object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContentRestrictionsBrowsePolicy> GetBrowsePolicyAsync();

    /// <summary>Gets the policy that applies to a piece of content, for content browsing and consumption.</summary>
    /// <param name="RatedContentDescription">The rated content info.</param>
    /// <returns>This method returns these values:</returns>
    [MethodImpl]
    public extern IAsyncOperation<ContentAccessRestrictionLevel> GetRestrictionLevelAsync(
      RatedContentDescription RatedContentDescription);

    /// <summary>Determines whether the user is allowed to consume a piece of content.</summary>
    /// <param name="RatedContentDescription">The rated content info.</param>
    /// <returns>Returns true, if the user can consume the content. Otherwise, returns false.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestContentAccessAsync(
      RatedContentDescription RatedContentDescription);

    /// <summary>An event handler to notify apps when there are changes to the user's content settings.</summary>
    public extern event EventHandler<object> RestrictionsChanged;
  }
}
