// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.FocusManagerLostFocusEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides data for the LostFocus event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FocusManagerLostFocusEventArgs : IFocusManagerLostFocusEventArgs
  {
    /// <summary>Gets the last focused element.</summary>
    /// <returns>The last focused element.</returns>
    public extern DependencyObject OldFocusedElement { [MethodImpl] get; }

    /// <summary>Gets the unique ID generated when a focus movement event is initiated.</summary>
    /// <returns>The unique ID, if any. Otherwise, **null**.</returns>
    public extern Guid CorrelationId { [MethodImpl] get; }
  }
}
