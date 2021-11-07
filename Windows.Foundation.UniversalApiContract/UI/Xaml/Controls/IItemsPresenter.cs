// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3262207643, 28106, 20011, 142, 20, 197, 81, 54, 176, 42, 113)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ItemsPresenter))]
  internal interface IItemsPresenter
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    TransitionCollection HeaderTransitions { get; set; }

    Thickness Padding { get; set; }
  }
}
