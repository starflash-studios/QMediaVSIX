// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IProgressBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2926914697, 103, 18787, 191, 76, 41, 219, 12, 74, 80, 126)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProgressBar))]
  [WebHostHidden]
  internal interface IProgressBar
  {
    bool IsIndeterminate { get; set; }

    bool ShowError { get; set; }

    bool ShowPaused { get; set; }

    ProgressBarTemplateSettings TemplateSettings { get; }
  }
}
