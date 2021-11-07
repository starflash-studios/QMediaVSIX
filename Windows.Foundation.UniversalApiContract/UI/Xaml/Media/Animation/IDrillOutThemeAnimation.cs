// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDrillOutThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3633368287, 1747, 20350, 142, 74, 79, 183, 110, 37, 97, 57)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DrillOutThemeAnimation))]
  internal interface IDrillOutThemeAnimation
  {
    string EntranceTargetName { get; set; }

    DependencyObject EntranceTarget { get; set; }

    string ExitTargetName { get; set; }

    DependencyObject ExitTarget { get; set; }
  }
}
