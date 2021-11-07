// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Exposes a method that retrieves the arguments associated with a toast action initiated by the user. This lets the app tell which action was taken when multiple actions were exposed.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ToastActivatedEventArgs : IToastActivatedEventArgs, IToastActivatedEventArgs2
  {
    /// <summary>Gets the arguments associated with a toast action initiated by the user. This arguments string was included in the toast's XML payload.</summary>
    /// <returns>The arguments string associated with the particular action.</returns>
    public extern string Arguments { [MethodImpl] get; }

    /// <summary>
    /// </summary>
    /// <returns>
    /// </returns>
    public extern ValueSet UserInput { [MethodImpl] get; }
  }
}
