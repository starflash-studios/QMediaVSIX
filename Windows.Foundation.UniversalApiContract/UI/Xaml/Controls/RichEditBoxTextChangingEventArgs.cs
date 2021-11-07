// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RichEditBoxTextChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the RichEditBox.TextChanging event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class RichEditBoxTextChangingEventArgs : 
    IRichEditBoxTextChangingEventArgs,
    IRichEditBoxTextChangingEventArgs2
  {
    /// <summary>Gets a value that indicates whether the event occured due to a change in the text content.</summary>
    /// <returns>**true** if a change to the text content caused the event; otherwise, **false**.</returns>
    public extern bool IsContentChanging { [MethodImpl] get; }
  }
}
