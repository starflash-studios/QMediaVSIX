// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageOpenOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Provides options to use when opening a file.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum StorageOpenOptions : uint
  {
    /// <summary>No options are specified.</summary>
    None = 0,
    /// <summary>Only allow the file to be read.</summary>
    AllowOnlyReaders = 1,
    /// <summary>Allows both readers and writers to coexist.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] AllowReadersAndWriters = 2,
  }
}
