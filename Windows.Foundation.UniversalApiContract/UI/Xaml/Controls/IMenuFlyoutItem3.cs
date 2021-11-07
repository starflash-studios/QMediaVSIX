// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutItem3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (MenuFlyoutItem))]
  [Guid(2535961315, 45750, 18908, 140, 34, 224, 19, 139, 148, 21, 89)]
  [WebHostHidden]
  internal interface IMenuFlyoutItem3
  {
    string KeyboardAcceleratorTextOverride { get; set; }

    MenuFlyoutItemTemplateSettings TemplateSettings { get; }
  }
}
