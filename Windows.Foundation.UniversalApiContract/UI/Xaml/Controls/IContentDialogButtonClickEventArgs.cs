// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogButtonClickEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1597293061, 35578, 19698, 140, 160, 38, 77, 115, 190, 214, 61)]
  [ExclusiveTo(typeof (ContentDialogButtonClickEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContentDialogButtonClickEventArgs
  {
    bool Cancel { get; set; }

    ContentDialogButtonClickDeferral GetDeferral();
  }
}
