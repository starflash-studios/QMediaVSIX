// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogClosingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ContentDialogClosingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3678149684, 15295, 18388, 190, 79, 201, 236, 17, 89, 24, 185)]
  internal interface IContentDialogClosingEventArgs
  {
    ContentDialogResult Result { get; }

    bool Cancel { get; set; }

    ContentDialogClosingDeferral GetDeferral();
  }
}
