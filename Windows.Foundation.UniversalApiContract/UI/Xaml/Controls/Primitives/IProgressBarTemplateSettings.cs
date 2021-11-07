// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IProgressBarTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProgressBarTemplateSettings))]
  [WebHostHidden]
  [Guid(1071835690, 58354, 19499, 148, 136, 145, 141, 119, 210, 187, 228)]
  internal interface IProgressBarTemplateSettings
  {
    double EllipseDiameter { get; }

    double EllipseOffset { get; }

    double EllipseAnimationWellPosition { get; }

    double EllipseAnimationEndPosition { get; }

    double ContainerAnimationStartPosition { get; }

    double ContainerAnimationEndPosition { get; }

    double IndicatorLengthDelta { get; }
  }
}
