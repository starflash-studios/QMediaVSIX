// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.CoreFrameworkInputViewAnimationStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class CoreFrameworkInputViewAnimationStartingEventArgs : 
    ICoreFrameworkInputViewAnimationStartingEventArgs
  {
    public extern IVectorView<CoreInputViewOcclusion> Occlusions { [MethodImpl] get; }

    public extern bool FrameworkAnimationRecommended { [MethodImpl] get; }

    public extern TimeSpan AnimationDuration { [MethodImpl] get; }
  }
}
