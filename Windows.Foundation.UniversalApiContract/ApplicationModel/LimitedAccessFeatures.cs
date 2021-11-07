// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LimitedAccessFeatures
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>This API enables applications to request access to Limited Access Features.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ILimitedAccessFeaturesStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  public static class LimitedAccessFeatures
  {
    /// <summary>Submits a request to Microsoft to authorize use of a specific Limited Access Feature. Users must have previously obtained a feature ID and a token from Microsoft in order to successfully call this API.</summary>
    /// <param name="featureId">The ID, provided by Microsoft. that identifies the feature being requested.</param>
    /// <param name="token">The string receieved from Microsoft upon agreeing to the requirements for use of the feature.</param>
    /// <param name="attestation">A plain-english statement declaring that the publisher has permission to use the feature.</param>
    /// <returns>A LimitedAccessFeatureRequestResult value indicating the response to the user request.</returns>
    [MethodImpl]
    public static extern LimitedAccessFeatureRequestResult TryUnlockFeature(
      string featureId,
      string token,
      string attestation);
  }
}
