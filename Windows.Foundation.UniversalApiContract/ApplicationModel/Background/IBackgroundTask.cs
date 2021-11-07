// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTask
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Provides a method to perform the work of a background task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2098451764, 64786, 17358, 140, 34, 234, 31, 241, 60, 6, 223)]
  [WebHostHidden]
  public interface IBackgroundTask
  {
    /// <summary>Performs the work of a background task. The system calls this method when the associated background task has been triggered.</summary>
    /// <param name="taskInstance">An interface to an instance of the background task. The system creates this instance when the task has been triggered to run.</param>
    void Run(IBackgroundTaskInstance taskInstance);
  }
}
