// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenter5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3527972620, 46981, 24191, 156, 17, 138, 108, 211, 213, 146, 155)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ContentPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IContentPresenter5
  {
    BrushTransition BackgroundTransition { get; set; }

    BackgroundSizing BackgroundSizing { get; set; }
  }
}
