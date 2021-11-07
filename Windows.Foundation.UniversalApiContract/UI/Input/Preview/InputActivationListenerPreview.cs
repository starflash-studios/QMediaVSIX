// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.InputActivationListenerPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.WindowManagement;

namespace Windows.UI.Input.Preview
{
  /// <summary>Provides the ability to access and observe changes to the activation state of a window, view, or other visual element.</summary>
  [Static(typeof (IInputActivationListenerPreviewStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public static class InputActivationListenerPreview
  {
    /// <summary>Instantiates an InputActivationListenerPreview object for the specified AppWindow.</summary>
    /// <param name="window">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern InputActivationListener CreateForApplicationWindow(
      AppWindow window);
  }
}
