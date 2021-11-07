// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataPackageOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Specifies the operation to perform on the DataPackage in clipboard and drag and drop scenarios.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum DataPackageOperation : uint
  {
    /// <summary>No action. Typically used when the DataPackage object requires delayed rendering.</summary>
    None = 0,
    /// <summary>Copies the content to the target destination. When implementing clipboard functionality, this corresponds to the "Copy" command.</summary>
    Copy = 1,
    /// <summary>Copies the content to the target destination and deletes the original. When implementing clipboard functionality, this corresponds to the "Cut" command.</summary>
    Move = 2,
    /// <summary>Creates a link for the data.</summary>
    Link = 4,
  }
}
