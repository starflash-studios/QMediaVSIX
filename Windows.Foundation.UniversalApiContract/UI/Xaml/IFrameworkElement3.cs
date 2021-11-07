// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElement3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3357288224, 23634, 19390, 161, 153, 43, 30, 52, 240, 15, 112)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameworkElement))]
  [WebHostHidden]
  internal interface IFrameworkElement3
  {
    event TypedEventHandler<FrameworkElement, object> Loading;
  }
}
