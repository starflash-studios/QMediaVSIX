// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.Preview.CoreAppWindowPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.WindowManagement;

namespace Windows.UI.Core.Preview
{
  /// <summary>Represents an app window and its thread.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (ICoreAppWindowPreviewStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreAppWindowPreview : ICoreAppWindowPreview
  {
    /// <summary>Retrieves the ID from the specified app window.</summary>
    /// <param name="window">The app window to get the ID from.</param>
    /// <returns>The ID from the specified app window.</returns>
    [MethodImpl]
    public static extern int GetIdFromWindow(AppWindow window);
  }
}
