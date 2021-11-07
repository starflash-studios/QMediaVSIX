// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileAttributes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Describes the attributes of a file or folder.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum FileAttributes : uint
  {
    /// <summary>The item is normal. That is, the item doesn't have any of the other values in the enumeration.</summary>
    Normal = 0,
    /// <summary>The item is read-only.</summary>
    ReadOnly = 1,
    /// <summary>The item is a directory.</summary>
    Directory = 16, // 0x00000010
    /// <summary>The item is archived.</summary>
    Archive = 32, // 0x00000020
    /// <summary>The item is a temporary file.</summary>
    Temporary = 256, // 0x00000100
    /// <summary>The item is locally incomplete. Windows only.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] LocallyIncomplete = 512, // 0x00000200
  }
}
