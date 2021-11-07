// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarIsStencilButtonCheckedChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(40820006, 54059, 20008, 160, 51, 213, 9, 118, 98, 178, 146)]
  [ExclusiveTo(typeof (InkToolbarIsStencilButtonCheckedChangedEventArgs))]
  internal interface IInkToolbarIsStencilButtonCheckedChangedEventArgs
  {
    InkToolbarStencilButton StencilButton { get; }

    InkToolbarStencilKind StencilKind { get; }
  }
}
