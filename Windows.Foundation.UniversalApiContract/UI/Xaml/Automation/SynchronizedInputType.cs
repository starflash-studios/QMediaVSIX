// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.SynchronizedInputType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Provides a of set constants that identify, as used by the ISynchronizedInputProvider  Microsoft UI Automation interface.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SynchronizedInputType
  {
    /// <summary>A key has been released.</summary>
    KeyUp = 1,
    /// <summary>A key has been pressed.</summary>
    KeyDown = 2,
    /// <summary>The left mouse button has been released.</summary>
    LeftMouseUp = 4,
    /// <summary>The left mouse button has been pressed.</summary>
    LeftMouseDown = 8,
    /// <summary>The right mouse button has been released.</summary>
    RightMouseUp = 16, // 0x00000010
    /// <summary>The right mouse button has been pressed.</summary>
    RightMouseDown = 32, // 0x00000020
  }
}
