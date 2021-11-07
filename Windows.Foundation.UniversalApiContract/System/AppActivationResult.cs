// Decompiled with JetBrains decompiler
// Type: Windows.System.AppActivationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Gets the result of activating an app via AppDiagnosticInfo.LaunchAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [DualApiPartition(version = 167772165)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppActivationResult : IAppActivationResult
  {
    /// <summary>Gets the error information, if any, that may have resulted from trying to activate the app.</summary>
    /// <returns>
    /// </returns>
    public extern HResult ExtendedError { [MethodImpl] get; }

    /// <summary>Gets diagnostic information, such as memory and energy use, for the activated app.</summary>
    /// <returns>
    /// </returns>
    public extern AppResourceGroupInfo AppResourceGroupInfo { [MethodImpl] get; }
  }
}
