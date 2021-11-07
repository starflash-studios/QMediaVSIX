// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DrillInNavigationTransitionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Specifies the animation to run when a user navigates forward in a logical hierarchy, like from a master list to a detail page.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class DrillInNavigationTransitionInfo : 
    NavigationTransitionInfo,
    IDrillInNavigationTransitionInfo
  {
    /// <summary>Initializes a new instance of the DrillInNavigationTransitionInfo class.</summary>
    [MethodImpl]
    public extern DrillInNavigationTransitionInfo();
  }
}
