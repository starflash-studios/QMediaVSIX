// Decompiled with JetBrains decompiler
// Type: Windows.Storage.CachedFileManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;

namespace Windows.Storage
{
  /// <summary>Lets apps manage real-time updates to files.</summary>
  [Static(typeof (ICachedFileManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class CachedFileManager
  {
    /// <summary>Lets apps defer real-time updates for a specified file.</summary>
    /// <param name="file">The file to defer updates for.</param>
    [MethodImpl]
    public static extern void DeferUpdates(IStorageFile file);

    /// <summary>Initiates updates for the specified file. This method contacts the app that provided the file to perform the updates.</summary>
    /// <param name="file">The file to update.</param>
    /// <returns>When this method completes, it returns a FileUpdateStatus enum value that describes the status of the updates to the file.</returns>
    [MethodImpl]
    public static extern IAsyncOperation<FileUpdateStatus> CompleteUpdatesAsync(
      IStorageFile file);
  }
}
