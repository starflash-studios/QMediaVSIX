// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IKeyEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (KeyEventArgs))]
  [Guid(1609951536, 9540, 18967, 189, 120, 31, 47, 222, 187, 16, 107)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeyEventArgs : ICoreWindowEventArgs
  {
    VirtualKey VirtualKey { get; }

    CorePhysicalKeyStatus KeyStatus { get; }
  }
}
