// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IGravityConnectedAnimationConfiguration2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(1647524573, 44756, 24557, 149, 255, 209, 40, 172, 206, 139, 228)]
  [ExclusiveTo(typeof (GravityConnectedAnimationConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  internal interface IGravityConnectedAnimationConfiguration2
  {
    bool IsShadowEnabled { get; set; }
  }
}
