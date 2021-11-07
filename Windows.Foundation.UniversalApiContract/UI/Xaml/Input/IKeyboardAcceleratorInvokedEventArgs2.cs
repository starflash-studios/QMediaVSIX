// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IKeyboardAcceleratorInvokedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(3204228280, 22791, 18670, 142, 33, 156, 150, 144, 120, 250, 17)]
  [WebHostHidden]
  [ExclusiveTo(typeof (KeyboardAcceleratorInvokedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IKeyboardAcceleratorInvokedEventArgs2
  {
    KeyboardAccelerator KeyboardAccelerator { get; }
  }
}
