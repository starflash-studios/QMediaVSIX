// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Contains info about the service that stores files and folders. Files and folders may be stored either by the local file system or by a remote service like Microsoft OneDrive.</summary>
  [Muse(Version = 100859904)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageProvider : IStorageProvider, IStorageProvider2
  {
    /// <summary>Gets an identifier for the current provider of files and folders.</summary>
    /// <returns>The identifier for the provider.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a user-friendly name for the current provider of files and folders.</summary>
    /// <returns>The user-friendly name for the provider. This name is localized to the current system locale.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Determines if a property is supported by a cloud storage provider.</summary>
    /// <param name="propertyCanonicalName">The name of the property. E.g., "System.Photo.DateTaken" or "System.Music.Artist"</param>
    /// <returns>**True** if the property is supported by the cloud storage provider; **False** otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsPropertySupportedForPartialFileAsync(
      string propertyCanonicalName);
  }
}
