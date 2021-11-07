// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LimitedAccessFeatureStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides the result of an attempt to authorize the use of a Limited Access Feature with the LimitedAccessFeatures.TryUnlockFeature API.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum LimitedAccessFeatureStatus
  {
    /// <summary>Indicates that the user does not have access to the feature.</summary>
    Unavailable,
    /// <summary>Indicates that the user has permission to use the feature, and that the feature is still in the "limited access" state.</summary>
    Available,
    /// <summary>Indicates that the feature is no longer in the "limited access" state, and that permission is no longer required for its use.</summary>
    AvailableWithoutToken,
    /// <summary>Indicates that the feature could not be found. This is likely due to an incorrect or deleted feature ID.</summary>
    Unknown,
  }
}
