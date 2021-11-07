// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentControl))]
  [WebHostHidden]
  [Guid(2725106140, 52548, 17244, 190, 148, 1, 214, 36, 28, 35, 28)]
  internal interface IContentControl
  {
    object Content { get; set; }

    DataTemplate ContentTemplate { get; set; }

    DataTemplateSelector ContentTemplateSelector { get; set; }

    TransitionCollection ContentTransitions { get; set; }
  }
}
