// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ILimitedAccessFeatureRequestResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (LimitedAccessFeatureRequestResult))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3562100390, 7716, 24029, 171, 180, 97, 136, 171, 164, 213, 191)]
  internal interface ILimitedAccessFeatureRequestResult
  {
    string FeatureId { get; }

    LimitedAccessFeatureStatus Status { get; }

    IReference<DateTime> EstimatedRemovalDate { get; }
  }
}
