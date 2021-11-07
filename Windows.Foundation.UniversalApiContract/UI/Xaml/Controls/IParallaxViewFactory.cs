// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IParallaxViewFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ParallaxView))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3840644674, 16014, 23078, 148, 242, 145, 33, 209, 33, 185, 22)]
  internal interface IParallaxViewFactory
  {
    ParallaxView CreateInstance(object baseInterface, out object innerInterface);
  }
}
