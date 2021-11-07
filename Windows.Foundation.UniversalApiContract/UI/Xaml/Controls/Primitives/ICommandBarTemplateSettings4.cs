// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ICommandBarTemplateSettings4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(4065734099, 43608, 22981, 133, 59, 130, 138, 25, 209, 33, 78)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CommandBarTemplateSettings))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ICommandBarTemplateSettings4
  {
    double OverflowContentCompactYTranslation { get; }

    double OverflowContentMinimalYTranslation { get; }

    double OverflowContentHiddenYTranslation { get; }
  }
}
