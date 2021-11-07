// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.AppExtensionPackageStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  /// <summary>Provides information for the AppExtensionCatalog.PackageStatusChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppExtensionPackageStatusChangedEventArgs : 
    IAppExtensionPackageStatusChangedEventArgs
  {
    /// <summary>Gets the name of the app extension that has been updated or uninstalled.</summary>
    /// <returns>The name of the app extension.</returns>
    public extern string AppExtensionName { [MethodImpl] get; }

    /// <summary>Gets the package containing the extension that is being updated or uninstalled.</summary>
    /// <returns>The extension package that changed.</returns>
    public extern Package Package { [MethodImpl] get; }
  }
}
