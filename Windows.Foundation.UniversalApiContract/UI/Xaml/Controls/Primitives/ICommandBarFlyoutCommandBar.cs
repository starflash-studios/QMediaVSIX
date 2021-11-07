// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ICommandBarFlyoutCommandBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(336883324, 14532, 21956, 183, 6, 206, 24, 246, 6, 30, 126)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CommandBarFlyoutCommandBar))]
  internal interface ICommandBarFlyoutCommandBar
  {
    CommandBarFlyoutCommandBarTemplateSettings FlyoutTemplateSettings { get; }
  }
}
