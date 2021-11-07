// Decompiled with JetBrains decompiler
// Type: Windows.Storage.CreationCollisionOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Specifies what to do if a file or folder with the specified name already exists in the current folder when you create a new file or folder.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CreationCollisionOption
  {
    /// <summary>Automatically append a number to the base of the specified name if the file or folder already exists.</summary>
    GenerateUniqueName,
    /// <summary>Replace the existing item if the file or folder already exists.</summary>
    ReplaceExisting,
    /// <summary>Raise an exception of type **System.Exception** if the file or folder already exists.</summary>
    FailIfExists,
    /// <summary>Return the existing item if the file or folder already exists.</summary>
    OpenIfExists,
  }
}
