// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.CommandLineActivationOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides info about the activation of the app such as what arguments were provided and the current directory path.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class CommandLineActivationOperation : ICommandLineActivationOperation
  {
    /// <summary>Gets the command-line arguments passed to the app when it was activated.</summary>
    /// <returns>The command line arguments.</returns>
    public extern string Arguments { [MethodImpl] get; }

    /// <summary>Gets the directory path from which the app was activated from the command line.</summary>
    /// <returns>The current directory path.</returns>
    public extern string CurrentDirectoryPath { [MethodImpl] get; }

    /// <summary>Sets the exit code for the app that was launched from the command line.</summary>
    /// <returns>The code the app returned when it exits.</returns>
    public extern int ExitCode { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a deferral object for this operation.</summary>
    /// <returns>A **Deferral** object that your code uses to signal when it has finished processing the activation.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
