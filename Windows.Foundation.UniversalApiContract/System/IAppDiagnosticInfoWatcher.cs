// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppDiagnosticInfoWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppDiagnosticInfoWatcher))]
  [Guid(1968656496, 467, 18586, 147, 37, 82, 249, 204, 110, 222, 10)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAppDiagnosticInfoWatcher
  {
    event TypedEventHandler<AppDiagnosticInfoWatcher, AppDiagnosticInfoWatcherEventArgs> Added;

    event TypedEventHandler<AppDiagnosticInfoWatcher, AppDiagnosticInfoWatcherEventArgs> Removed;

    event TypedEventHandler<AppDiagnosticInfoWatcher, object> EnumerationCompleted;

    event TypedEventHandler<AppDiagnosticInfoWatcher, object> Stopped;

    AppDiagnosticInfoWatcherStatus Status { get; }

    void Start();

    void Stop();
  }
}
