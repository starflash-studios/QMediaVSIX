// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.Preview.WindowManagementPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement.Preview
{
  /// <summary>Provides preview APIs for handling and managing the windows associated with the active app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [Static(typeof (IWindowManagementPreviewStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  public sealed class WindowManagementPreview : IWindowManagementPreview
  {
    /// <summary>Sets the preferred minimum size for the specified AppWindow.</summary>
    /// <param name="window">The app window to set the size for.</param>
    /// <param name="preferredFrameMinSize">The preferred minimum size for the window.</param>
    [MethodImpl]
    public static extern void SetPreferredMinSize(AppWindow window, Size preferredFrameMinSize);
  }
}
