// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IClipboardContentOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (ClipboardContentOptions))]
  [Guid(3901270412, 44363, 21575, 160, 86, 171, 53, 86, 39, 109, 43)]
  internal interface IClipboardContentOptions
  {
    bool IsRoamable { get; set; }

    bool IsAllowedInHistory { get; set; }

    IVector<string> RoamingFormats { get; }

    IVector<string> HistoryFormats { get; }
  }
}
