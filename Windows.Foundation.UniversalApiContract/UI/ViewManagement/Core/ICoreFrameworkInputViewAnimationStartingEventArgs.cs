// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreFrameworkInputViewAnimationStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [ExclusiveTo(typeof (CoreFrameworkInputViewAnimationStartingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(3236728860, 48036, 20507, 174, 139, 101, 201, 231, 86, 167, 25)]
  internal interface ICoreFrameworkInputViewAnimationStartingEventArgs
  {
    IVectorView<CoreInputViewOcclusion> Occlusions { get; }

    bool FrameworkAnimationRecommended { get; }

    TimeSpan AnimationDuration { get; }
  }
}
