// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInputInjector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2395107204, 2818, 19410, 173, 122, 61, 70, 88, 190, 62, 24)]
  [ExclusiveTo(typeof (InputInjector))]
  internal interface IInputInjector
  {
    void InjectKeyboardInput(IIterable<InjectedInputKeyboardInfo> input);

    void InjectMouseInput(IIterable<InjectedInputMouseInfo> input);

    void InitializeTouchInjection(InjectedInputVisualizationMode visualMode);

    void InjectTouchInput(IIterable<InjectedInputTouchInfo> input);

    void UninitializeTouchInjection();

    void InitializePenInjection(InjectedInputVisualizationMode visualMode);

    void InjectPenInput(InjectedInputPenInfo input);

    void UninitializePenInjection();

    void InjectShortcut(InjectedInputShortcut shortcut);
  }
}
