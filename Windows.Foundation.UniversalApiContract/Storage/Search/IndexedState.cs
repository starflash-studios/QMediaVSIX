// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IndexedState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Indicates whether a StorageFolder is included in the system index.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum IndexedState
  {
    /// <summary>The indexed state is not known.</summary>
    Unknown,
    /// <summary>The folder is not indexed.</summary>
    NotIndexed,
    /// <summary>Some folders in the library are indexed, but not all of them. This value is relevant only for libraries.</summary>
    PartiallyIndexed,
    /// <summary>The folder contains indexed content. </summary>
    FullyIndexed,
  }
}
