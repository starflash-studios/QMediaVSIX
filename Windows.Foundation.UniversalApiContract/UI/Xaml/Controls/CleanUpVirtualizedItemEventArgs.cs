// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the CleanUpVirtualizedItemEvent event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class CleanUpVirtualizedItemEventArgs : 
    RoutedEventArgs,
    ICleanUpVirtualizedItemEventArgs
  {
    /// <summary>Gets an object that represents the original data value.</summary>
    /// <returns>The Object that represents the original data value.</returns>
    public extern object Value { [MethodImpl] get; }

    /// <summary>Gets an instance of the visual element that represents the data value.</summary>
    /// <returns>The UIElement that represents the data value.</returns>
    public extern UIElement UIElement { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether this item should not be revirtualized.</summary>
    /// <returns>**true** if you want to prevent revirtualization of this item; otherwise, **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }
  }
}
