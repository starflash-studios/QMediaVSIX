// Decompiled with JetBrains decompiler
// Type: Windows.System.AppResourceGroupBackgroundTaskReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Provides snapshot information about a background task such as its name, trigger name, entry point name, and task identifier.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class AppResourceGroupBackgroundTaskReport : IAppResourceGroupBackgroundTaskReport
  {
    /// <summary>Gets the background task's identifier.</summary>
    /// <returns>The background task GUID.</returns>
    public extern Guid TaskId { [MethodImpl] get; }

    /// <summary>Gets the name of the background task.</summary>
    /// <returns>The background task name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the name of the trigger that activated this task.</summary>
    /// <returns>The name of the trigger.</returns>
    public extern string Trigger { [MethodImpl] get; }

    /// <summary>Gets the name of the background task entry point.</summary>
    /// <returns>The name of the entry point as specified in the app manifest.</returns>
    public extern string EntryPoint { [MethodImpl] get; }
  }
}
