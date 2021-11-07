// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageUninstallingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information about the app package that is being uninstalled.</summary>
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class PackageUninstallingEventArgs : IPackageUninstallingEventArgs
  {
    /// <summary>Gets the id for the uninstall operation.</summary>
    /// <returns>A unique value that an app can use to correlate events that relate to a single deployment operation.</returns>
    public extern Guid ActivityId { [MethodImpl] get; }

    /// <summary>Gets the package that is uninstalling.</summary>
    /// <returns>The package being uninstalled.</returns>
    public extern Package Package { [MethodImpl] get; }

    /// <summary>Gets an approximation of the package's uninstall progress.</summary>
    /// <returns>A value in the range of 0 through 1.0 which represents approximately how far along the package is in the uninstall process.</returns>
    public extern double Progress { [MethodImpl] get; }

    /// <summary>Indicates whether the app package is done uninstalling.</summary>
    /// <returns>**True** indicates that the app package is done uninstalling; **false**, otherwise.</returns>
    public extern bool IsComplete { [MethodImpl] get; }

    /// <summary>Gets the result of the package uninstall operation.</summary>
    /// <returns>The result of the package uninstall operation.</returns>
    public extern HResult ErrorCode { [MethodImpl] get; }
  }
}
