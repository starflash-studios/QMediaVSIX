// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IChoosingItemContainerEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ChoosingItemContainerEventArgs))]
  [Guid(2612280270, 44647, 19072, 131, 99, 227, 254, 27, 36, 79, 44)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChoosingItemContainerEventArgs
  {
    int ItemIndex { get; }

    object Item { get; }

    SelectorItem ItemContainer { get; set; }

    bool IsContainerPrepared { get; set; }
  }
}
