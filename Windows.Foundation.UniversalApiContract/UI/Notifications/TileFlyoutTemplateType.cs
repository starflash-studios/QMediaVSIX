// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileFlyoutTemplateType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the layout template to use in a tile flyout (mix view) update. At present, only one template is defined.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TileFlyoutTemplateType
  {
    /// <summary>Eight sub-tiles that surround a central medium (150x150) tile. Each sub-tile supports a combination of text and images.</summary>
    TileFlyoutTemplate01,
  }
}
