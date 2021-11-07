// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInjectedInputGamepadInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Gaming.Input;

namespace Windows.UI.Input.Preview.Injection
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(548313663, 57105, 17778, 169, 171, 215, 91, 138, 94, 72, 173)]
  [ExclusiveTo(typeof (InjectedInputGamepadInfo))]
  internal interface IInjectedInputGamepadInfo
  {
    GamepadButtons Buttons { get; set; }

    double LeftThumbstickX { get; set; }

    double LeftThumbstickY { get; set; }

    double LeftTrigger { get; set; }

    double RightThumbstickX { get; set; }

    double RightThumbstickY { get; set; }

    double RightTrigger { get; set; }
  }
}
