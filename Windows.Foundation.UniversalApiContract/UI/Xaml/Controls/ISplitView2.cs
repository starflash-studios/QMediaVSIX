// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitView2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SplitView))]
  [WebHostHidden]
  [Guid(1588059152, 52355, 16538, 130, 249, 62, 145, 214, 215, 8, 79)]
  internal interface ISplitView2
  {
    LightDismissOverlayMode LightDismissOverlayMode { get; set; }
  }
}
