// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInjectedInputGamepadInfoFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Gaming.Input;

namespace Windows.UI.Input.Preview.Injection
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1499031670, 27705, 20164, 139, 42, 41, 239, 125, 225, 138, 202)]
  [ExclusiveTo(typeof (InjectedInputGamepadInfo))]
  internal interface IInjectedInputGamepadInfoFactory
  {
    [Overload("CreateInstanceFromGamepadReading")]
    InjectedInputGamepadInfo CreateInstance(GamepadReading reading);
  }
}
