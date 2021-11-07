// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.StorageLibraryContentChangedTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Creates a trigger that will fire when a file is changed in a specified library.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IStorageLibraryContentChangedTriggerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class StorageLibraryContentChangedTrigger : 
    IStorageLibraryContentChangedTrigger,
    IBackgroundTrigger
  {
    /// <summary>Creates a trigger that will fire when a file is changed in the specified library.</summary>
    /// <param name="storageLibrary">The location that the trigger monitors such as the music library or documents library.</param>
    /// <returns>A trigger that monitors the specified location.</returns>
    [MethodImpl]
    public static extern StorageLibraryContentChangedTrigger Create(
      StorageLibrary storageLibrary);

    [MethodImpl]
    public static extern StorageLibraryContentChangedTrigger CreateFromLibraries(
      IIterable<StorageLibrary> storageLibraries);
  }
}
