// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IUISettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (UISettings))]
  [Guid(2234914304, 7267, 17959, 188, 177, 58, 137, 224, 188, 156, 85)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUISettings
  {
    HandPreference HandPreference { get; }

    Size CursorSize { get; }

    Size ScrollBarSize { get; }

    Size ScrollBarArrowSize { get; }

    Size ScrollBarThumbBoxSize { get; }

    uint MessageDuration { get; }

    bool AnimationsEnabled { get; }

    bool CaretBrowsingEnabled { get; }

    uint CaretBlinkRate { get; }

    uint CaretWidth { get; }

    uint DoubleClickTime { get; }

    uint MouseHoverTime { get; }

    Color UIElementColor(UIElementType desiredElement);
  }
}
