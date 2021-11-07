// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.CachedFileUpdaterTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Provides details about the cached file operation that invoked the trigger.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CachedFileUpdaterTriggerDetails : ICachedFileUpdaterTriggerDetails
  {
    /// <summary>Gets the CachedFileTarget object associated with cached file update that indicates whether the local or remote file should be updated.</summary>
    /// <returns>The CachedFileTarget object associated with cached file update that indicates whether the local or remote file should be updated.</returns>
    public extern CachedFileTarget UpdateTarget { [MethodImpl] get; }

    /// <summary>Gets the FileUpdateRequest object associated with the cached file update.</summary>
    /// <returns>The FileUpdateRequest object associated with the cached file update.</returns>
    public extern FileUpdateRequest UpdateRequest { [MethodImpl] get; }

    /// <summary>Gets whether the system can display UI allowing the user to launch provider app in response to the cached file updater trigger.</summary>
    /// <returns>Whether the system can display UI allowing the user to launch provider app in response to the cached file updater trigger.</returns>
    public extern bool CanRequestUserInput { [MethodImpl] get; }
  }
}
