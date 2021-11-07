// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageUpdateAvailabilityResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Describes whether the main app package listed in the .appinstaller file requires updates.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PackageUpdateAvailabilityResult : IPackageUpdateAvailabilityResult
  {
    /// <summary>Describes the type of package update that's available.</summary>
    /// <returns>A PackageUpdateAvailability value that indicates the type of update available.</returns>
    public extern PackageUpdateAvailability Availability { [MethodImpl] get; }

    /// <summary>If there is a problem checking for an update via Package.CheckUpdateAvailabilityAsync, this error can provide details.</summary>
    /// <returns>The error triggered by checking for the update.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
