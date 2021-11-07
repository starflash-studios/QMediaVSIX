// Decompiled with JetBrains decompiler
// Type: Windows.Management.Core.ApplicationDataManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Management.Core
{
  /// <summary>Enables you to access and manage the app data store for a package family.</summary>
  [Static(typeof (IApplicationDataManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ApplicationDataManager : IApplicationDataManager
  {
    /// <summary>Provides access to the app data store for the specified package family.</summary>
    /// <param name="packageFamilyName">The package family name.</param>
    /// <returns>The app data store.</returns>
    [MethodImpl]
    public static extern ApplicationData CreateForPackageFamily(
      string packageFamilyName);
  }
}
