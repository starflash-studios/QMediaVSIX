// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (VisualStateManager))]
  [Guid(30468576, 55059, 16718, 167, 78, 230, 62, 199, 172, 140, 61)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVisualStateManagerStatics
  {
    IVector<VisualStateGroup> GetVisualStateGroups(FrameworkElement obj);

    DependencyProperty CustomVisualStateManagerProperty { get; }

    VisualStateManager GetCustomVisualStateManager(FrameworkElement obj);

    void SetCustomVisualStateManager(FrameworkElement obj, VisualStateManager value);

    bool GoToState(Control control, string stateName, bool useTransitions);
  }
}
