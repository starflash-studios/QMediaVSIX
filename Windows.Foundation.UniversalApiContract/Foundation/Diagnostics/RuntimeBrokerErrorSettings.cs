// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.RuntimeBrokerErrorSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Represents diagnostic error reporting settings.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772166)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RuntimeBrokerErrorSettings : IErrorReportingSettings
  {
    /// <summary>Creates and initializes a new instance of the RuntimeBrokerErrorSettings.</summary>
    [MethodImpl]
    public extern RuntimeBrokerErrorSettings();

    /// <summary>Sets the type of error reporting for the error object.</summary>
    /// <param name="value">One of the enumeration values.</param>
    [MethodImpl]
    public extern void SetErrorOptions(ErrorOptions value);

    /// <summary>Gets the type of error reporting for the error object.</summary>
    /// <returns>One of the enumeration values.</returns>
    [MethodImpl]
    public extern ErrorOptions GetErrorOptions();
  }
}
