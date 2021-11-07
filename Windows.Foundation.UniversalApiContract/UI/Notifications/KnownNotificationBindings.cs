// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.KnownNotificationBindings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the binding templates available for adaptive notifications.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IKnownNotificationBindingsStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class KnownNotificationBindings
  {
    /// <summary>Gets the string representation of the ToastGeneric binding.</summary>
    /// <returns>The string representation of the ToastGeneric binding.</returns>
    public static extern string ToastGeneric { [MethodImpl] get; }
  }
}
