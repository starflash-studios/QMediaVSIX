// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ISplitViewTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (SplitViewTemplateSettings))]
  [Guid(3244996007, 18838, 17475, 177, 153, 107, 107, 137, 18, 78, 171)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISplitViewTemplateSettings
  {
    double OpenPaneLength { get; }

    double NegativeOpenPaneLength { get; }

    double OpenPaneLengthMinusCompactLength { get; }

    double NegativeOpenPaneLengthMinusCompactLength { get; }

    GridLength OpenPaneGridLength { get; }

    GridLength CompactPaneGridLength { get; }
  }
}
