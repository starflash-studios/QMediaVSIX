// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageUserInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4130878499, 64009, 19644, 144, 85, 21, 202, 39, 94, 46, 126)]
  [ExclusiveTo(typeof (PackageUserInformation))]
  internal interface IPackageUserInformation
  {
    string UserSecurityId { get; }

    PackageInstallState InstallState { get; }
  }
}
