// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DynamicOverflowItemsChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the CommandBar.DynamicOverflowItemsChanging event.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class DynamicOverflowItemsChangingEventArgs : IDynamicOverflowItemsChangingEventArgs
  {
    /// <summary>Initializes a new instance of the DynamicOverflowItemsChangingEventArgs class.</summary>
    [MethodImpl]
    public extern DynamicOverflowItemsChangingEventArgs();

    /// <summary>Gets a value that indicates whether items were added to or removed from the CommandBar overflow menu.</summary>
    /// <returns>A value that indicates whether items were added to or removed from the CommandBar overflow menu.</returns>
    public extern CommandBarDynamicOverflowAction Action { [MethodImpl] get; }
  }
}
