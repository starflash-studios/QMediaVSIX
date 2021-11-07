// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHub
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Hub))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2926128770, 29460, 20305, 171, 17, 42, 241, 237, 74, 25, 248)]
  internal interface IHub
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    Orientation Orientation { get; set; }

    int DefaultSectionIndex { get; set; }

    IVector<HubSection> Sections { get; }

    IVector<HubSection> SectionsInView { get; }

    IObservableVector<object> SectionHeaders { get; }

    event HubSectionHeaderClickEventHandler SectionHeaderClick;

    event SectionsInViewChangedEventHandler SectionsInViewChanged;

    void ScrollToSection(HubSection section);
  }
}
