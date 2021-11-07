// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.StorageLibraryChangeTrackerTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a file change within a StorageFolder that triggers a background task to run.</summary>
  [Activatable(typeof (IStorageLibraryChangeTrackerTriggerFactory), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StorageLibraryChangeTrackerTrigger : IBackgroundTrigger
  {
    /// <summary>Initializes a new **StorageLibraryChangeTrackerTrigger** instance.</summary>
    /// <param name="tracker">The change tracker for the **StorageLibrary** that you want to monitor for changes.</param>
    [MethodImpl]
    public extern StorageLibraryChangeTrackerTrigger(StorageLibraryChangeTracker tracker);
  }
}
