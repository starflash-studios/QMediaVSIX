// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.InputEnabledEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Contains the window input state returned by the CoreWindow.InputEnabled event.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class InputEnabledEventArgs : IInputEnabledEventArgs, ICoreWindowEventArgs
  {
    /// <summary>Gets whether the window is enabled for input.</summary>
    /// <returns>True if the window is enabled for input; false if it is not.</returns>
    public extern bool InputEnabled { [MethodImpl] get; }

    /// <summary>Gets or sets whether the input enable event was handled.</summary>
    /// <returns>True if the input enable event was handled by the appropriate delegate; false if it was not.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
