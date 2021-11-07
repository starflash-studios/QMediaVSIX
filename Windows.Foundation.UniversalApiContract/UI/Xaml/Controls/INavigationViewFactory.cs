// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (NavigationView))]
  [Guid(3842410433, 47042, 18805, 173, 122, 95, 79, 230, 165, 20, 201)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface INavigationViewFactory
  {
    NavigationView CreateInstance(object baseInterface, out object innerInterface);
  }
}
