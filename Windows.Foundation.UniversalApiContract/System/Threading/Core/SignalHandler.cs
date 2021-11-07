// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.SignalHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  /// <summary>Represents a method that is called when a signal notifier's attached event or semaphore is signaled, or when the optional timeout value has elapsed (whichever comes first).</summary>
  /// <param name="signalNotifier">Represents the signal notifier that called the delegate.</param>
  /// <param name="timedOut">Indicates whether *timeout* value elapsed before calling the delegate.</param>
  [Guid(2453422126, 18209, 17422, 157, 218, 85, 182, 242, 224, 119, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public delegate void SignalHandler(SignalNotifier signalNotifier, bool timedOut);
}
