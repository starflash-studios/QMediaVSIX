// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.ILicenseSatisfactionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  [Guid(1019981967, 56113, 18645, 131, 132, 250, 23, 200, 20, 116, 226)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (LicenseSatisfactionInfo))]
  internal interface ILicenseSatisfactionInfo
  {
    bool SatisfiedByDevice { get; }

    bool SatisfiedByOpenLicense { get; }

    bool SatisfiedByTrial { get; }

    bool SatisfiedByPass { get; }

    bool SatisfiedByInstallMedia { get; }

    bool SatisfiedBySignedInUser { get; }

    bool IsSatisfied { get; }
  }
}
