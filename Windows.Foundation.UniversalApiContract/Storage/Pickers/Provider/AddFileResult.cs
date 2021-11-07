// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.AddFileResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  /// <summary>Indicates the result of a call to the fileOpenPickerUI.addFile method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AddFileResult
  {
    /// <summary>The file was successfully added to the file picker UI.</summary>
    Added,
    /// <summary>The file was already in the file picker UI.</summary>
    AlreadyAdded,
    /// <summary>The file wasn't added because it is not one of the allowed file types.</summary>
    NotAllowed,
    /// <summary>The file wasn't added because the file picker UI is unavailable.  The file picker UI is only available while the user is interacting with your app.</summary>
    Unavailable,
  }
}
