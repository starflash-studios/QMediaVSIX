// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ISelectorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(321915654, 48400, 19977, 191, 247, 113, 239, 184, 187, 180, 43)]
  [ExclusiveTo(typeof (Selector))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISelectorStatics
  {
    DependencyProperty SelectedIndexProperty { get; }

    DependencyProperty SelectedItemProperty { get; }

    DependencyProperty SelectedValueProperty { get; }

    DependencyProperty SelectedValuePathProperty { get; }

    DependencyProperty IsSynchronizedWithCurrentItemProperty { get; }

    bool GetIsSelectionActive(DependencyObject element);
  }
}
