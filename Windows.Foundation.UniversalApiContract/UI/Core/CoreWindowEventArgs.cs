// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreWindowEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Contains the set of arguments returned to an app after a window input or behavior event.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreWindowEventArgs : ICoreWindowEventArgs
  {
    /// <summary>Specifies the property that gets or sets whether the event was handled.</summary>
    /// <returns>True if the event has been handled by the appropriate delegate; false if it has not.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
