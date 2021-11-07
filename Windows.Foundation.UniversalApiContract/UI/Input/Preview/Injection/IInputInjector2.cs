// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInputInjector2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [ExclusiveTo(typeof (InputInjector))]
  [Guid(2390397021, 5203, 17319, 155, 203, 6, 214, 215, 179, 5, 247)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IInputInjector2 : IInputInjector
  {
    void InitializeGamepadInjection();

    void InjectGamepadInput(InjectedInputGamepadInfo input);

    void UninitializeGamepadInjection();
  }
}
