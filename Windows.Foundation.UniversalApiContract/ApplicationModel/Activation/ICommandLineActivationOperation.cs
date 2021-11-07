// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ICommandLineActivationOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (CommandLineActivationOperation))]
  [Guid(2571839553, 50590, 20329, 188, 253, 182, 30, 212, 230, 34, 235)]
  internal interface ICommandLineActivationOperation
  {
    string Arguments { get; }

    string CurrentDirectoryPath { get; }

    int ExitCode { set; get; }

    Deferral GetDeferral();
  }
}
