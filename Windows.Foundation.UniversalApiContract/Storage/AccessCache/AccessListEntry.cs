// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.AccessListEntry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  /// <summary>Represents a list entry that contains the identifier and metadata for a StorageFile or StorageFolder object in a list.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct AccessListEntry
  {
    /// <summary>The identifier of the StorageFile or StorageFolder in the list.</summary>
    public string Token;
    /// <summary>Optional app-specified metadata associated with the StorageFile or StorageFolder in the list.</summary>
    public string Metadata;
  }
}
