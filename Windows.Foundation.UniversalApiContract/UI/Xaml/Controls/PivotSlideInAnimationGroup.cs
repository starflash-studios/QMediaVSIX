// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PivotSlideInAnimationGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the different slide-in animation groups that Pivot elements can belong to.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum PivotSlideInAnimationGroup
  {
    /// <summary>The element belongs to the default animation group. It slides in after the Pivot header.</summary>
    Default,
    /// <summary>The element belongs to the first animation group. It slides in after elements in the default group.</summary>
    GroupOne,
    /// <summary>The element belongs to the second animation group. It slides in after elements in the first group.</summary>
    GroupTwo,
    /// <summary>The element belongs to the third animation group. It slides in after elements in the second group.</summary>
    GroupThree,
  }
}
