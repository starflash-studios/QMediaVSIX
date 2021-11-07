// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageContentGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information about a package content group.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPackageContentGroupStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class PackageContentGroup : IPackageContentGroup
  {
    /// <summary>Gets the package for this content group.</summary>
    /// <returns>The package for this content group.</returns>
    public extern Package Package { [MethodImpl] get; }

    /// <summary>Gets the name of this package content group.</summary>
    /// <returns>The content group name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the state of the package content group.</summary>
    /// <returns>A value describing the package content group state.</returns>
    public extern PackageContentGroupState State { [MethodImpl] get; }

    /// <summary>Indicates whether this package content group is required or automatic.</summary>
    /// <returns>**True** indicates that the content group is required; **false** otherwise.</returns>
    public extern bool IsRequired { [MethodImpl] get; }

    /// <summary>Gets the name of the required content group.</summary>
    /// <returns>The name of the required content group.</returns>
    public static extern string RequiredGroupName { [MethodImpl] get; }
  }
}
