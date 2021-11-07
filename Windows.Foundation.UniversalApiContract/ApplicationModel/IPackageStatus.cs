// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageStatus))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1608994673, 41829, 19465, 160, 45, 4, 109, 82, 94, 161, 218)]
  internal interface IPackageStatus
  {
    bool VerifyIsOK();

    bool NotAvailable { get; }

    bool PackageOffline { get; }

    bool DataOffline { get; }

    bool Disabled { get; }

    bool NeedsRemediation { get; }

    bool LicenseIssue { get; }

    bool Modified { get; }

    bool Tampered { get; }

    bool DependencyIssue { get; }

    bool Servicing { get; }

    bool DeploymentInProgress { get; }
  }
}
