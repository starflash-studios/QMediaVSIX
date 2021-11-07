// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides access to the package that has changed.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PackageStatusChangedEventArgs : IPackageStatusChangedEventArgs
  {
    /// <summary>The package that has changed.</summary>
    /// <returns>The package that has changed. A package is changed when it is installed, uninstalled, or updated.</returns>
    public extern Package Package { [MethodImpl] get; }
  }
}
