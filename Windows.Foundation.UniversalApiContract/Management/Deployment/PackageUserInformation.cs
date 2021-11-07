// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageUserInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Provides information about the users of an installed package.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class PackageUserInformation : IPackageUserInformation
  {
    /// <summary>Gets the security identifier (SID) of the package user.</summary>
    /// <returns>The SID.</returns>
    public extern string UserSecurityId { [MethodImpl] get; }

    /// <summary>Gets the install state of the package for the user.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern PackageInstallState InstallState { [MethodImpl] get; }
  }
}
