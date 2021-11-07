// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ICommandBarFlyoutCommandBarTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CommandBarFlyoutCommandBarTemplateSettings))]
  [Guid(1197747268, 9983, 23828, 156, 252, 119, 220, 100, 243, 164, 71)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ICommandBarFlyoutCommandBarTemplateSettings
  {
    double OpenAnimationStartPosition { get; }

    double OpenAnimationEndPosition { get; }

    double CloseAnimationEndPosition { get; }

    double CurrentWidth { get; }

    double ExpandedWidth { get; }

    double WidthExpansionDelta { get; }

    double WidthExpansionAnimationStartPosition { get; }

    double WidthExpansionAnimationEndPosition { get; }

    double WidthExpansionMoreButtonAnimationStartPosition { get; }

    double WidthExpansionMoreButtonAnimationEndPosition { get; }

    double ExpandUpOverflowVerticalPosition { get; }

    double ExpandDownOverflowVerticalPosition { get; }

    double ExpandUpAnimationStartPosition { get; }

    double ExpandUpAnimationEndPosition { get; }

    double ExpandUpAnimationHoldPosition { get; }

    double ExpandDownAnimationStartPosition { get; }

    double ExpandDownAnimationEndPosition { get; }

    double ExpandDownAnimationHoldPosition { get; }

    Rect ContentClipRect { get; }

    Rect OverflowContentClipRect { get; }
  }
}
