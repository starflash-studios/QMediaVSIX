// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageItemTypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Describes whether an item that implements the IStorageItem interface is a file or a folder.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum StorageItemTypes : uint
  {
    /// <summary>A storage item that is neither a file nor a folder.</summary>
    None = 0,
    /// <summary>A file that is represented as a StorageFile instance.</summary>
    File = 1,
    /// <summary>A folder that is represented as a StorageFolder instance.</summary>
    Folder = 2,
  }
}
