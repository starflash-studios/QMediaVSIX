// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IClipboardHistoryItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(24362378, 45055, 23632, 171, 146, 61, 25, 244, 129, 236, 88)]
  [ExclusiveTo(typeof (ClipboardHistoryItem))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IClipboardHistoryItem
  {
    string Id { get; }

    DateTime Timestamp { get; }

    DataPackageView Content { get; }
  }
}
