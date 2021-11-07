// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISettingsFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SettingsFlyout))]
  [WebHostHidden]
  [Guid(2198579243, 50523, 20018, 165, 28, 87, 145, 224, 36, 200, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISettingsFlyout
  {
    string Title { get; set; }

    Brush HeaderBackground { get; set; }

    Brush HeaderForeground { get; set; }

    ImageSource IconSource { get; set; }

    SettingsFlyoutTemplateSettings TemplateSettings { get; }

    event BackClickEventHandler BackClick;

    void Show();

    void ShowIndependent();

    void Hide();
  }
}
