// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ApplicationTriggerResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>The result of the request to trigger a background task. The RequestAsync method returns a value of this enumeration type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ApplicationTriggerResult
  {
    /// <summary>The trigger has been set. The task will run, unless an exception is thrown in the background infrastructure.</summary>
    Allowed,
    /// <summary>The system denied triggering the background task because it is currently running.</summary>
    CurrentlyRunning,
    /// <summary>A system policy doesn't allow this background task to be triggered.</summary>
    DisabledByPolicy,
    /// <summary>The background task cannot be triggered because of an unknown issue.</summary>
    UnknownError,
  }
}
