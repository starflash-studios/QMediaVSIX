// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.CurrentChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Provides data for the CurrentChanging event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ICurrentChangingEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class CurrentChangingEventArgs : ICurrentChangingEventArgs
  {
    /// <summary>Initializes a new instance of the CurrentChangingEventArgs class.</summary>
    [MethodImpl]
    public extern CurrentChangingEventArgs();

    /// <summary>Initializes a new instance of the CurrentChangingEventArgs class.</summary>
    /// <param name="isCancelable">**true** to disable the ability to cancel a CurrentItem change; **false** to enable cancellation.</param>
    [MethodImpl]
    public extern CurrentChangingEventArgs(bool isCancelable);

    /// <summary>Gets or sets a value that indicates whether the CurrentItem change should be canceled.</summary>
    /// <returns>**true** if the event should be canceled; otherwise, **false**. The default is **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the CurrentItem change can be canceled.</summary>
    /// <returns>**true** if the event can be canceled; **false** if the event cannot be canceled.</returns>
    public extern bool IsCancelable { [MethodImpl] get; }
  }
}
