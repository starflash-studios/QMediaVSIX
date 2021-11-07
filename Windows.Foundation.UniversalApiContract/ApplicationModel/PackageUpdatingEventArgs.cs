// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageUpdatingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information about the package that is being updated.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  public sealed class PackageUpdatingEventArgs : IPackageUpdatingEventArgs
  {
    /// <summary>Gets the id for the update operation.</summary>
    /// <returns>A unique value that an app can use to correlate events that relate to a single deployment operation.</returns>
    public extern Guid ActivityId { [MethodImpl] get; }

    /// <summary>Gets the package that is being updated.</summary>
    /// <returns>The package being updated. This is the original package that was on the machine that is now being updated.</returns>
    public extern Package SourcePackage { [MethodImpl] get; }

    /// <summary>Gets the updated package.</summary>
    /// <returns>This is the new package that is an update to the old package on the device.</returns>
    public extern Package TargetPackage { [MethodImpl] get; }

    /// <summary>Gets an approximation of the package's update progress.</summary>
    /// <returns>A value in the range of 0 through 1.0 which represents approximately how far along the package is in the update process.</returns>
    public extern double Progress { [MethodImpl] get; }

    /// <summary>Indicates whether the app package is done updating.</summary>
    /// <returns>**True** if the app package is done updating; **false** otherwise.</returns>
    public extern bool IsComplete { [MethodImpl] get; }

    /// <summary>Gets the result of the package uninstall operation.</summary>
    /// <returns>The result of the package uninstall operation.</returns>
    public extern HResult ErrorCode { [MethodImpl] get; }
  }
}
