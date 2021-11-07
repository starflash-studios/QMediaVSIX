// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IBasicConnectedAnimationConfigurationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(2514912330, 17271, 20540, 190, 226, 17, 223, 205, 85, 112, 230)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (BasicConnectedAnimationConfiguration))]
  internal interface IBasicConnectedAnimationConfigurationFactory
  {
    BasicConnectedAnimationConfiguration CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
