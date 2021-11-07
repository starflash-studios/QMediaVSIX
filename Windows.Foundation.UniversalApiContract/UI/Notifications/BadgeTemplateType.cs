// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.BadgeTemplateType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the template to use for a tile's badge overlay. Used by BadgeUpdateManager.getTemplateContent.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BadgeTemplateType
  {
    /// <summary>A system-provided glyph image. For more information, see [Badge overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779719(v=win.10)).</summary>
    BadgeGlyph,
    /// <summary>A numerical value from 1 to 99. Values greater than 99 are accepted, but in those cases "99+" is displayed instead of the actual number. In scenarios where your numbers are expected to be greater than 99, you should consider using a glyph instead.</summary>
    BadgeNumber,
  }
}
