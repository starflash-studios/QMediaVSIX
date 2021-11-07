// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITwoPaneViewFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [Guid(419395885, 22708, 23021, 160, 81, 81, 172, 239, 251, 204, 169)]
  [ExclusiveTo(typeof (TwoPaneView))]
  internal interface ITwoPaneViewFactory
  {
    TwoPaneView CreateInstance(object baseInterface, out object innerInterface);
  }
}
