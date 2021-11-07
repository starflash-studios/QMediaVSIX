// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHandwritingViewFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3758917439, 18, 18268, 137, 12, 151, 174, 48, 134, 66, 222)]
  [ExclusiveTo(typeof (HandwritingView))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IHandwritingViewFactory
  {
    HandwritingView CreateInstance(object baseInterface, out object innerInterface);
  }
}
