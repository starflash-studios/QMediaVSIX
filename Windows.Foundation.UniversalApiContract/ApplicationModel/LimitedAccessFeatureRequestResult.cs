// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LimitedAccessFeatureRequestResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>An object returned from a LimitedAccessFeatures.TryUnlockFeature request, which contains information on the feature and its availability.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class LimitedAccessFeatureRequestResult : ILimitedAccessFeatureRequestResult
  {
    /// <summary>Provides the feature ID associated with the request made.</summary>
    /// <returns>The feature's ID, as provided by Microsoft.</returns>
    public extern string FeatureId { [MethodImpl] get; }

    /// <summary>Provides the result of the feature request, which indicates the availability of the feature in question.</summary>
    /// <returns>A LimitedAccessFeatureStatus value corresponding to the result of the feature request.</returns>
    public extern LimitedAccessFeatureStatus Status { [MethodImpl] get; }

    /// <summary>Provides the estimate date that the current version of the requested feature will become unavailable.</summary>
    /// <returns>The estimated date at which the token used to gain access to the feature will expire, if known.</returns>
    public extern IReference<DateTime> EstimatedRemovalDate { [MethodImpl] get; }
  }
}
