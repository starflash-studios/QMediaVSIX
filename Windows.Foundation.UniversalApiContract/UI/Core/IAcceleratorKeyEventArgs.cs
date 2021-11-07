// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IAcceleratorKeyEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  [Guid(4280044618, 37511, 18187, 131, 110, 144, 134, 227, 18, 106, 222)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AcceleratorKeyEventArgs))]
  [WebHostHidden]
  internal interface IAcceleratorKeyEventArgs : ICoreWindowEventArgs
  {
    CoreAcceleratorKeyEventType EventType { get; }

    VirtualKey VirtualKey { get; }

    CorePhysicalKeyStatus KeyStatus { get; }
  }
}
