// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.SetHistoryItemAsContentStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Represents the return status of a call to the SetHistoryItemAsContent method to set an item in the clipboard history as the current content for the clipboard.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum SetHistoryItemAsContentStatus
  {
    /// <summary>The request was successful.</summary>
    Success,
    /// <summary>Access to the clipboard history is denied.</summary>
    AccessDenied,
    /// <summary>The specified item was deleted.</summary>
    ItemDeleted,
  }
}
