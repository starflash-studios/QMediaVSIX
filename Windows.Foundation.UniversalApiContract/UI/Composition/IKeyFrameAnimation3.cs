// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IKeyFrameAnimation3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(2220617908, 55518, 17967, 135, 83, 200, 13, 67, 198, 255, 90)]
  [ExclusiveTo(typeof (KeyFrameAnimation))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IKeyFrameAnimation3
  {
    AnimationDelayBehavior DelayBehavior { get; set; }
  }
}
