// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IGravityConnectedAnimationConfigurationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (GravityConnectedAnimationConfiguration))]
  [Guid(3894592543, 13910, 20624, 146, 245, 194, 23, 234, 172, 182, 130)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface IGravityConnectedAnimationConfigurationFactory
  {
    GravityConnectedAnimationConfiguration CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
