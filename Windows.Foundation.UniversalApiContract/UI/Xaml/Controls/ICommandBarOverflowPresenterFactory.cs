// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBarOverflowPresenterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CommandBarOverflowPresenter))]
  [Guid(2200172404, 23210, 16457, 183, 143, 33, 140, 106, 25, 195, 126)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICommandBarOverflowPresenterFactory
  {
    CommandBarOverflowPresenter CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
