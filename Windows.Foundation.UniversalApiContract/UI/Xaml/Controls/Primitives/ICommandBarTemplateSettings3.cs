// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ICommandBarTemplateSettings3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(1003953850, 13315, 19454, 132, 45, 44, 232, 197, 17, 210, 69)]
  [ExclusiveTo(typeof (CommandBarTemplateSettings))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICommandBarTemplateSettings3
  {
    Visibility EffectiveOverflowButtonVisibility { get; }
  }
}
