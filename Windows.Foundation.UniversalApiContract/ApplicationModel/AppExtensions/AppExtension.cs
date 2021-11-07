// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.AppExtension
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.AppExtensions
{
  /// <summary>Provides information about an application extension.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AppExtension : IAppExtension, IAppExtension2
  {
    /// <summary>The extension's instance identifier.</summary>
    /// <returns>Instance identifier.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Provides the display name of this extension.</summary>
    /// <returns>The display name.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Provides the description of this app extension.</summary>
    /// <returns>Description of the extension.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets the package information for the app extension.</summary>
    /// <returns>The package information which includes the package description, logo, display name, and so on.</returns>
    public extern Package Package { [MethodImpl] get; }

    /// <summary>Provides information such as the app extension's name, logo, package information, and app identifier, that the host app may choose to show to the user.</summary>
    /// <returns>The application information.</returns>
    public extern AppInfo AppInfo { [MethodImpl] get; }

    /// <summary>Used by the extension to specify any extra information that the hosting app can query.</summary>
    /// <returns>A collection of key-value pairs.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IPropertySet> GetExtensionPropertiesAsync();

    /// <summary>Gets the readable subfolder in the extension's isolated storage.</summary>
    /// <returns>The public sub-folder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetPublicFolderAsync();

    public extern string AppUserModelId { [MethodImpl] get; }
  }
}
