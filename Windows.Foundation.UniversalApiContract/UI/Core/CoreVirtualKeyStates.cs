// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreVirtualKeyStates
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Specifies flags for indicating the possible states of a virtual key.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Flags]
  public enum CoreVirtualKeyStates : uint
  {
    /// <summary>The key is up or in no specific state.</summary>
    None = 0,
    /// <summary>The key is pressed down for the input event.</summary>
    Down = 1,
    /// <summary>The key is in a toggled or modified state (for example, Caps Lock) for the input event.</summary>
    Locked = 2,
  }
}
