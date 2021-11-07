// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AutomationBulletStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Defines the style of bullets used by the automation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum AutomationBulletStyle
  {
    /// <summary>No bullets.</summary>
    None,
    /// <summary>Hollow round bullets.</summary>
    HollowRoundBullet,
    /// <summary>Filled round bullets.</summary>
    FilledRoundBullet,
    /// <summary>Hollow square bullets.</summary>
    HollowSquareBullet,
    /// <summary>Filled square bullets.</summary>
    FilledSquareBullet,
    /// <summary>Dashed bullets.</summary>
    DashBullet,
    /// <summary>Other style of bullets.</summary>
    Other,
  }
}
