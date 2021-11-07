// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ItemsChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides data for the ItemsChanged event.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ItemsChangedEventArgs : IItemsChangedEventArgs
  {
    /// <summary>Gets the action that occurred on the items collection.</summary>
    /// <returns>Returns the action that occurred.</returns>
    public extern int Action { [MethodImpl] get; }

    /// <summary>Gets the position in the collection where the change occurred.</summary>
    /// <returns>Returns a GeneratorPosition.</returns>
    public extern GeneratorPosition Position { [MethodImpl] get; }

    /// <summary>Gets the position in the collection before the change occurred.</summary>
    /// <returns>Returns a GeneratorPosition.</returns>
    public extern GeneratorPosition OldPosition { [MethodImpl] get; }

    /// <summary>Gets the number of items that were involved in the change.</summary>
    /// <returns>Integer that represents the number of items involved in the change.</returns>
    public extern int ItemCount { [MethodImpl] get; }

    /// <summary>Gets the number of UI elements involved in the change.</summary>
    /// <returns>Integer that represents the number of UI elements involved in the change.</returns>
    public extern int ItemUICount { [MethodImpl] get; }
  }
}
