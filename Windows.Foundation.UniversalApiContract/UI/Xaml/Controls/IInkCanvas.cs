// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkCanvas
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  [Guid(692337704, 36424, 20424, 164, 115, 53, 176, 186, 18, 172, 234)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkCanvas))]
  internal interface IInkCanvas
  {
    InkPresenter InkPresenter { get; }
  }
}
