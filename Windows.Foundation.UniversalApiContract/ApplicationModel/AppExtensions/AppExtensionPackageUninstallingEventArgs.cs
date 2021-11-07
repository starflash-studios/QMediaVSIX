// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.AppExtensionPackageUninstallingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  /// <summary>Provides information for the AppExtensionCatalog.PackageUninstalling event.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AppExtensionPackageUninstallingEventArgs : 
    IAppExtensionPackageUninstallingEventArgs
  {
    /// <summary>Gets the name of the app extension that is uninstalling.</summary>
    /// <returns>The name of the app extension.</returns>
    public extern string AppExtensionName { [MethodImpl] get; }

    /// <summary>Gets the app extension package that is uninstalilng.</summary>
    /// <returns>The app extension package that was uninstalled.</returns>
    public extern Package Package { [MethodImpl] get; }
  }
}
