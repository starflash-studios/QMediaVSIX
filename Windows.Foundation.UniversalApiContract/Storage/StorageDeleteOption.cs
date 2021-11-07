// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageDeleteOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Specifies whether a deleted item is moved to the Recycle Bin or permanently deleted.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum StorageDeleteOption
  {
    /// <summary>Specifies the default behavior.</summary>
    Default,
    /// <summary>Permanently deletes the item. The item is not moved to the Recycle Bin.</summary>
    PermanentDelete,
  }
}
