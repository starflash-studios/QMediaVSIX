// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotificationActionTriggerDetail
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Represents the details of a toast action trigger.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ToastNotificationActionTriggerDetail : IToastNotificationActionTriggerDetail
  {
    /// <summary>Gets a value representing the argument that was passed.</summary>
    /// <returns>The argument that was passed.</returns>
    public extern string Argument { [MethodImpl] get; }

    /// <summary>Gets a value indicating the user's action.</summary>
    /// <returns>A value indicating the user's action.</returns>
    public extern ValueSet UserInput { [MethodImpl] get; }
  }
}
