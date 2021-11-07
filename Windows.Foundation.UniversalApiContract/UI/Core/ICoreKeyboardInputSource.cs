// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreKeyboardInputSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (CoreComponentInputSource))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(589074568, 58473, 19953, 178, 8, 110, 73, 13, 113, 203, 144)]
  internal interface ICoreKeyboardInputSource
  {
    CoreVirtualKeyStates GetCurrentKeyState(VirtualKey virtualKey);

    event TypedEventHandler<object, CharacterReceivedEventArgs> CharacterReceived;

    event TypedEventHandler<object, KeyEventArgs> KeyDown;

    event TypedEventHandler<object, KeyEventArgs> KeyUp;
  }
}
