// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  /// <summary>Provides information for the AppExtensionCatalog.PackageUpdated event.</summary>
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AppExtensionPackageUpdatedEventArgs : IAppExtensionPackageUpdatedEventArgs
  {
    /// <summary>Gets the name of the app extension that was updated.</summary>
    /// <returns>The name of the updated app extension.</returns>
    public extern string AppExtensionName { [MethodImpl] get; }

    /// <summary>Provides the package containing the extension that was updated.</summary>
    /// <returns>The updated app extension package.</returns>
    public extern Package Package { [MethodImpl] get; }

    /// <summary>Provides a list of extensions that are in the extension package that was updated</summary>
    /// <returns>A list of extensions within the updated extension package.</returns>
    public extern IVectorView<AppExtension> Extensions { [MethodImpl] get; }
  }
}
