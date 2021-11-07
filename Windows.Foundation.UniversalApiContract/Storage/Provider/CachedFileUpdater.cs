// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.CachedFileUpdater
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  /// <summary>Manages files so that they can be updated in real-time by an app that participates in the Cached File Updater contract.</summary>
  [Static(typeof (ICachedFileUpdaterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class CachedFileUpdater
  {
    /// <summary>Configures update policies for a local file.</summary>
    /// <param name="file">The local file.</param>
    /// <param name="contentId">A unique identifier for the local file.</param>
    /// <param name="readMode">A value that specifies whether Windows will request updates before the local file is retrieved from an app's MostRecentlyUsedList or FutureAccessList.</param>
    /// <param name="writeMode">A value that specifies whether other apps can write to the local file and, if so, whether Windows will request updates after the local file is written.</param>
    /// <param name="options">A value that specifies additional circumstances and behaviors for when Windows requests updates.</param>
    [MethodImpl]
    public static extern void SetUpdateInformation(
      IStorageFile file,
      string contentId,
      ReadActivationMode readMode,
      WriteActivationMode writeMode,
      CachedFileOptions options);
  }
}
