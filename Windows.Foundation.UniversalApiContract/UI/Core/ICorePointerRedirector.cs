// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICorePointerRedirector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Defines pointer events for cross-process input handling.</summary>
  [Guid(2409434260, 22152, 19212, 169, 241, 249, 49, 247, 250, 61, 195)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  public interface ICorePointerRedirector
  {
    /// <summary>Occurs on the process receiving input when the pointer input is routed to another process.</summary>
    event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedAway;

    /// <summary>Occurs on the process not currently receiving pointer input when ongoing pointer input, for an existing pointer ID, transitions from one process to another.</summary>
    event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedTo;

    /// <summary>Occurs on all processes ever associated with, but not currently receiving input from, a pointer that fires a PointerReleased event on the current process.</summary>
    event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedReleased;
  }
}
