// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ISettingsFlyoutTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (SettingsFlyoutTemplateSettings))]
  [Guid(3169930256, 52903, 17393, 157, 104, 87, 96, 93, 237, 105, 212)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISettingsFlyoutTemplateSettings
  {
    Brush HeaderBackground { get; }

    Brush HeaderForeground { get; }

    Brush BorderBrush { get; }

    Thickness BorderThickness { get; }

    ImageSource IconSource { get; }

    TransitionCollection ContentTransitions { get; }
  }
}
