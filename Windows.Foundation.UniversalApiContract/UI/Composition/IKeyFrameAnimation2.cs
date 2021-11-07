// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IKeyFrameAnimation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (KeyFrameAnimation))]
  [Guid(4105472187, 10560, 20160, 164, 26, 235, 109, 128, 26, 47, 24)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IKeyFrameAnimation2
  {
    AnimationDirection Direction { get; set; }
  }
}
