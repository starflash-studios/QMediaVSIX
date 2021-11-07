// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContainerContentChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ContainerContentChangingEventArgs))]
  [Guid(132049575, 399, 19930, 179, 153, 253, 78, 19, 163, 27, 234)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContainerContentChangingEventArgs
  {
    SelectorItem ItemContainer { get; }

    bool InRecycleQueue { get; }

    int ItemIndex { get; }

    object Item { get; }

    uint Phase { get; }

    bool Handled { get; set; }

    [Overload("RegisterUpdateCallback")]
    void RegisterUpdateCallback(
      TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback);

    [Overload("RegisterUpdateCallbackWithPhase")]
    void RegisterUpdateCallback(
      uint callbackPhase,
      TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback);
  }
}
