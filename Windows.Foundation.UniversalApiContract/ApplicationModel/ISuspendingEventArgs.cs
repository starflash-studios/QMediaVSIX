// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ISuspendingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides data for an app suspending event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2516982789, 11706, 19720, 176, 189, 43, 48, 161, 49, 198, 170)]
  public interface ISuspendingEventArgs
  {
    /// <summary>Gets the app suspending operation.</summary>
    /// <returns>The suspending operation.</returns>
    SuspendingOperation SuspendingOperation { get; }
  }
}
