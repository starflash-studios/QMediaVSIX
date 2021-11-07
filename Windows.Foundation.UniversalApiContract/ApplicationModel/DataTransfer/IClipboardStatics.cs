// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IClipboardStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(3324502673, 13538, 18787, 142, 237, 147, 203, 176, 234, 61, 112)]
  [ExclusiveTo(typeof (Clipboard))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IClipboardStatics
  {
    DataPackageView GetContent();

    void SetContent(DataPackage content);

    void Flush();

    void Clear();

    event EventHandler<object> ContentChanged;
  }
}
