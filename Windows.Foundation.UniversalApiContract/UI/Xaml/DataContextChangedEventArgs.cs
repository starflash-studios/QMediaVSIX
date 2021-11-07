// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DataContextChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides data for the DataContextChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DataContextChangedEventArgs : IDataContextChangedEventArgs
  {
    /// <summary>Gets the new DataContext value for the element where the DataContextChanged event fired.</summary>
    /// <returns>An object representing the new DataContext value for the element where the DataContextChanged event fired.</returns>
    public extern object NewValue { [MethodImpl] get; }

    /// <summary>Gets or sets a value that influences whether another DataContextChanged event should be fired from child elements that inherit the DataContext value and detect that the value has changed.</summary>
    /// <returns>**true** to prevent further DataContextChanged events from being fired for each child FrameworkElement that inherits the DataContext value. You would do this to indicate to other handlers that the necessary logic for responding to the data context change has already been performed. **false** to permit the event to be fired by each immediate child FrameworkElement in the element tree that detects a change to the inherited DataContext value. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
