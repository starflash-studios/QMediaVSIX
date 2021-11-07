// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarEraserButton2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3886387799, 23272, 17261, 178, 226, 147, 194, 0, 144, 12, 160)]
  [ExclusiveTo(typeof (InkToolbarEraserButton))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  internal interface IInkToolbarEraserButton2
  {
    bool IsClearAllVisible { get; set; }
  }
}
