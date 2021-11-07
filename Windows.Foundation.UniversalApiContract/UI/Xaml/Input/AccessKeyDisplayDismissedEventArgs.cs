// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.AccessKeyDisplayDismissedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides event data for the AccessKeyDisplayDismissed event.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class AccessKeyDisplayDismissedEventArgs : IAccessKeyDisplayDismissedEventArgs
  {
    /// <summary>Initializes a new instance of the AccessKeyDisplayDismissedEventArgs class.</summary>
    [MethodImpl]
    public extern AccessKeyDisplayDismissedEventArgs();
  }
}
