// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Desktop.DesktopWindowTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Desktop
{
  /// <summary>Represents a window that is the target of a composition.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class DesktopWindowTarget : CompositionTarget, IDesktopWindowTarget
  {
    /// <summary>Gets a value that indicates whether the window is rendered on top of all other windows.</summary>
    /// <returns>**true** if the window is rendered on top of all other windows; otherwise, **false**.</returns>
    public extern bool IsTopmost { [MethodImpl] get; }
  }
}
