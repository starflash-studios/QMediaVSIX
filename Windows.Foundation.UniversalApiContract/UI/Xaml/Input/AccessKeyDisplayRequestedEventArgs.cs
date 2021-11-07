// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides event data for the AccessKeyDisplayRequested event.</summary>
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class AccessKeyDisplayRequestedEventArgs : IAccessKeyDisplayRequestedEventArgs
  {
    /// <summary>Initializes a new instance of the AccessKeyDisplayRequestedEventArgs class.</summary>
    [MethodImpl]
    public extern AccessKeyDisplayRequestedEventArgs();

    /// <summary>Gets the keys that were pressed to start the access key sequence.</summary>
    /// <returns>The keys that were pressed to start the access key sequence.</returns>
    public extern string PressedKeys { [MethodImpl] get; }
  }
}
