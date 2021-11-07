// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.CanExecuteRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides event data for the CanExecuteRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CanExecuteRequestedEventArgs : ICanExecuteRequestedEventArgs
  {
    /// <summary>Gets the command parameter passed into the CanExecute method that raised this event.</summary>
    /// <returns>
    /// </returns>
    public extern object Parameter { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether the ICommand that raised this event is able to execute.</summary>
    /// <returns>**true** if the ICommand is able to execute; otherwise, **false**.</returns>
    public extern bool CanExecute { [MethodImpl] get; [MethodImpl] set; }
  }
}
