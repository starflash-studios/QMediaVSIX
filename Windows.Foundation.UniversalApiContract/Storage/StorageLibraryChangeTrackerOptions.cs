// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageLibraryChangeTrackerOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  [Threading(ThreadingModel.Both)]
  [Activatable(720896, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StorageLibraryChangeTrackerOptions : IStorageLibraryChangeTrackerOptions
  {
    [MethodImpl]
    public extern StorageLibraryChangeTrackerOptions();

    public extern bool TrackChangeDetails { [MethodImpl] get; [MethodImpl] set; }
  }
}
