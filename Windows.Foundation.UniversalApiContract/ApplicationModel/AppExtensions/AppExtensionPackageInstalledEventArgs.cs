// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.AppExtensionPackageInstalledEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  /// <summary>Provides information for the AppExtensionCatalog.PackageInstalled event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AppExtensionPackageInstalledEventArgs : IAppExtensionPackageInstalledEventArgs
  {
    /// <summary>Gets the name of the extension package that was installed.</summary>
    /// <returns>The name of the extension.</returns>
    public extern string AppExtensionName { [MethodImpl] get; }

    /// <summary>Gets the package containing the extension that was installed.</summary>
    /// <returns>The extension package that was installed.</returns>
    public extern Package Package { [MethodImpl] get; }

    /// <summary>Provides a list of extensions in the extension package that was just installed.</summary>
    /// <returns>The list of extensions within the extension package.</returns>
    public extern IVectorView<AppExtension> Extensions { [MethodImpl] get; }
  }
}
