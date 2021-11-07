// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides data about a change in range value for the ValueChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class RangeBaseValueChangedEventArgs : 
    RoutedEventArgs,
    IRangeBaseValueChangedEventArgs
  {
    /// <summary>Gets the previous value of a range value property.</summary>
    /// <returns>The previous value.</returns>
    public extern double OldValue { [MethodImpl] get; }

    /// <summary>Gets the new value of a range value property.</summary>
    /// <returns>The new value.</returns>
    public extern double NewValue { [MethodImpl] get; }
  }
}
