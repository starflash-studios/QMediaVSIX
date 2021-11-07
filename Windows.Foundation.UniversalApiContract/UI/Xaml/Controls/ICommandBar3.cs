// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBar3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1089190947, 10873, 18611, 154, 103, 100, 155, 133, 45, 133, 137)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CommandBar))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICommandBar3
  {
    CommandBarDefaultLabelPosition DefaultLabelPosition { get; set; }

    CommandBarOverflowButtonVisibility OverflowButtonVisibility { get; set; }

    bool IsDynamicOverflowEnabled { get; set; }

    event TypedEventHandler<CommandBar, DynamicOverflowItemsChangingEventArgs> DynamicOverflowItemsChanging;
  }
}
