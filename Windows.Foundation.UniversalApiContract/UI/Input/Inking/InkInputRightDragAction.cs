// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkInputRightDragAction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Specifies how the InkPresenter object handles secondary input from a pen barrel button, pen eraser tip, right mouse button, or similar.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum InkInputRightDragAction
  {
    /// <summary>All input is UnprocessedInput. This passes all input through to the app for custom processing.</summary>
    LeaveUnprocessed,
    /// <summary>All input is unmodified by a secondary affordance and is processed as standard ink input by the InkPresenter.</summary>
    AllowProcessing,
  }
}
