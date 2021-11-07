// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageStagingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information about the app package that is being staged.</summary>
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PackageStagingEventArgs : IPackageStagingEventArgs
  {
    /// <summary>Gets the id for the staging operation.</summary>
    /// <returns>A unique value that an app can use to correlate events that relate to a single deployment operation.</returns>
    public extern Guid ActivityId { [MethodImpl] get; }

    /// <summary>Gets the package that is staging.</summary>
    /// <returns>The package being staged.</returns>
    public extern Package Package { [MethodImpl] get; }

    /// <summary>Gets an approximation of the package's staging progress.</summary>
    /// <returns>A value in the range of 0 through 1.0 which represents approximately how far along the package is in the staging process.</returns>
    public extern double Progress { [MethodImpl] get; }

    /// <summary>Indicates whether the app package is done staging.</summary>
    /// <returns>**True** indicates that the app package is done staging; **false**, otherwise.</returns>
    public extern bool IsComplete { [MethodImpl] get; }

    /// <summary>Gets the result of the package staging operation.</summary>
    /// <returns>The code for the error. **S_OK** if no error.</returns>
    public extern HResult ErrorCode { [MethodImpl] get; }
  }
}
