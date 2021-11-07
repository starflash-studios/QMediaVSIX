// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (RichEditBox))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1554681141, 51256, 19373, 160, 124, 32, 65, 131, 187, 117, 31)]
  [WebHostHidden]
  internal interface IRichEditBox4
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> GetLinguisticAlternativesAsync();

    RichEditClipboardFormat ClipboardCopyFormat { get; set; }
  }
}
