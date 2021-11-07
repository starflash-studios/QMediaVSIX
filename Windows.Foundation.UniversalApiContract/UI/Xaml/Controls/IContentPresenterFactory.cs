// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentPresenter))]
  [Guid(859428087, 18453, 17604, 159, 118, 104, 200, 56, 128, 239, 16)]
  [WebHostHidden]
  internal interface IContentPresenterFactory
  {
    ContentPresenter CreateInstance(object baseInterface, out object innerInterface);
  }
}
