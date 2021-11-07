// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the **CandidateWindowBoundsChanged** event.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CandidateWindowBoundsChangedEventArgs : ICandidateWindowBoundsChangedEventArgs
  {
    /// <summary>Gets the Rect that defines the size and location of the Input Method Editor (IME) window, in the coordinate space of the text edit control.</summary>
    /// <returns>The Rect that defines the size and location of the Input Method Editor (IME) window</returns>
    public extern Rect Bounds { [MethodImpl] get; }
  }
}
