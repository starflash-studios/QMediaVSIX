// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ILimitedAccessFeaturesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(2347111124, 12331, 24511, 166, 50, 26, 153, 228, 62, 137, 37)]
  [ExclusiveTo(typeof (LimitedAccessFeatures))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ILimitedAccessFeaturesStatics
  {
    LimitedAccessFeatureRequestResult TryUnlockFeature(
      string featureId,
      string token,
      string attestation);
  }
}
