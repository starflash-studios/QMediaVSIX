// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IAppBarTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(3166873699, 60213, 16956, 131, 137, 215, 130, 123, 227, 191, 103)]
  [ExclusiveTo(typeof (AppBarTemplateSettings))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppBarTemplateSettings
  {
    Rect ClipRect { get; }

    double CompactVerticalDelta { get; }

    Thickness CompactRootMargin { get; }

    double MinimalVerticalDelta { get; }

    Thickness MinimalRootMargin { get; }

    double HiddenVerticalDelta { get; }

    Thickness HiddenRootMargin { get; }
  }
}
