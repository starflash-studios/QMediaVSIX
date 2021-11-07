// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DependencyPropertyChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides data for a PropertyChangedCallback implementation that is invoked when a dependency property changes its value. Also provides event data for the Control.IsEnabledChanged event and any other event that uses the DependencyPropertyChangedEventHandler delegate.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DependencyPropertyChangedEventArgs : IDependencyPropertyChangedEventArgs
  {
    /// <summary>Gets the identifier for the dependency property where the value change occurred.</summary>
    /// <returns>The identifier field of the dependency property where the value change occurred.</returns>
    public extern DependencyProperty Property { [MethodImpl] get; }

    /// <summary>Gets the value of the dependency property before the reported change.</summary>
    /// <returns>The dependency property value before the change.</returns>
    public extern object OldValue { [MethodImpl] get; }

    /// <summary>Gets the value of the dependency property after the reported change.</summary>
    /// <returns>The dependency property value after the change.</returns>
    public extern object NewValue { [MethodImpl] get; }
  }
}
