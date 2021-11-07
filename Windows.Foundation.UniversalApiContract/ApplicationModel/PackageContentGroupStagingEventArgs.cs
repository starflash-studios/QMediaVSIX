// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageContentGroupStagingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information about the package content group that is being staged.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PackageContentGroupStagingEventArgs : IPackageContentGroupStagingEventArgs
  {
    /// <summary>Gets the identifier of the content group staging operation.</summary>
    /// <returns>A unique value that an app can use to correlate events that relate to a particular content group staging operation.</returns>
    public extern Guid ActivityId { [MethodImpl] get; }

    /// <summary>Gets the package that is being staged.</summary>
    /// <returns>The package containing the content group being staged.</returns>
    public extern Package Package { [MethodImpl] get; }

    /// <summary>Gets an approximation of the package content group's staging progress.</summary>
    /// <returns>A value in the range of 0 through 100 which represents approximately how far along the content group is in the staging process.</returns>
    public extern double Progress { [MethodImpl] get; }

    /// <summary>Indicates whether the content group is done staging.</summary>
    /// <returns>**True** indicates that the content group is done staging; **false**, otherwise.</returns>
    public extern bool IsComplete { [MethodImpl] get; }

    /// <summary>Gets the result of the package content group staging operation.</summary>
    /// <returns>The result of the package content group staging operation.</returns>
    public extern HResult ErrorCode { [MethodImpl] get; }

    /// <summary>Gets the name of the content group that is being staged.</summary>
    /// <returns>The name of the content group.</returns>
    public extern string ContentGroupName { [MethodImpl] get; }

    /// <summary>Indicates whether the content group is required.</summary>
    /// <returns>**True** indicates that the package content group is required; **false**, otherwise.</returns>
    public extern bool IsContentGroupRequired { [MethodImpl] get; }
  }
}
