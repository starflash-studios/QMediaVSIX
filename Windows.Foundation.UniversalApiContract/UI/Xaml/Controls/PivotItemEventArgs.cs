// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PivotItemEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Event arguments for dynamically interacting with the PivotItem before use, allowing for delay load scenarios.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class PivotItemEventArgs : IPivotItemEventArgs
  {
    /// <summary>Initializes a new instance of the PivotItemEventArgs type</summary>
    [MethodImpl]
    public extern PivotItemEventArgs();

    /// <summary>Gets the pivot item instance.</summary>
    /// <returns>Returns PivotItem.</returns>
    public extern PivotItem Item { [MethodImpl] get; [MethodImpl] set; }
  }
}
