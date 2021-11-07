// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreInputViewAnimationStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [Guid(2836679410, 46428, 24225, 184, 171, 83, 64, 243, 233, 72, 151)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (CoreInputViewAnimationStartingEventArgs))]
  internal interface ICoreInputViewAnimationStartingEventArgs
  {
    IVectorView<CoreInputViewOcclusion> Occlusions { get; }

    bool Handled { get; set; }

    TimeSpan AnimationDuration { get; }
  }
}
