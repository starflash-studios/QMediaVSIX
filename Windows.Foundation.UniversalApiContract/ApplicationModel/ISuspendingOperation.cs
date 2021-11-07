// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ISuspendingOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information about an app suspending operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2644822593, 8417, 20123, 159, 101, 169, 244, 53, 52, 12, 58)]
  public interface ISuspendingOperation
  {
    /// <summary>Requests that the app suspending operation be delayed.</summary>
    /// <returns>The suspension deferral.</returns>
    SuspendingDeferral GetDeferral();

    /// <summary>Gets the time remaining before a delayed app suspending operation continues.</summary>
    /// <returns>The time remaining.</returns>
    DateTime Deadline { get; }
  }
}
