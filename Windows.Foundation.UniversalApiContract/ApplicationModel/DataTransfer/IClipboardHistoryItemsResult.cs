// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IClipboardHistoryItemsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (ClipboardHistoryItemsResult))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3873431270, 3810, 21219, 133, 43, 242, 149, 219, 101, 147, 154)]
  internal interface IClipboardHistoryItemsResult
  {
    ClipboardHistoryItemsResultStatus Status { get; }

    IVectorView<ClipboardHistoryItem> Items { get; }
  }
}
