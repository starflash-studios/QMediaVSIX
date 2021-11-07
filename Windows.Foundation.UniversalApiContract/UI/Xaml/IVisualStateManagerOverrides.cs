// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateManagerOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (VisualStateManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1248235790, 31097, 17352, 143, 244, 236, 97, 34, 117, 0, 6)]
  [WebHostHidden]
  internal interface IVisualStateManagerOverrides
  {
    bool GoToStateCore(
      Control control,
      FrameworkElement templateRoot,
      string stateName,
      VisualStateGroup group,
      VisualState state,
      bool useTransitions);
  }
}
