// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DatePickedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the DatePicked event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DatePickedEventArgs : DependencyObject, IDatePickedEventArgs
  {
    /// <summary>Initializes a new instance of the DatePickedEventArgs class.</summary>
    [MethodImpl]
    public extern DatePickedEventArgs();

    /// <summary>Gets the previous date.</summary>
    /// <returns>The previous date.</returns>
    public extern DateTime OldDate { [MethodImpl] get; }

    /// <summary>Gets the date that was selected by the user.</summary>
    /// <returns>The date that was selected by the user.</returns>
    public extern DateTime NewDate { [MethodImpl] get; }
  }
}
