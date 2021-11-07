// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.TimerElapsedHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  /// <summary>Represents a method that is called when a timer created with CreateTimer or CreatePeriodicTimer expires.</summary>
  /// <param name="timer">The timer to associate with this method. When this timer expires, the method is called.</param>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4205749863, 64491, 18891, 173, 178, 113, 24, 76, 85, 110, 67)]
  public delegate void TimerElapsedHandler(ThreadPoolTimer timer);
}
