// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingChannelOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Represents advanced settings that you can use to configure a LoggingChannel object.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ILoggingChannelOptionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LoggingChannelOptions : ILoggingChannelOptions
  {
    /// <summary>Creates a LoggingChannelOptions object with all options set to default values.</summary>
    [MethodImpl]
    public extern LoggingChannelOptions();

    /// <summary>Creates a LoggingChannelOptions object with all properties set to default values except for the specified group.</summary>
    /// <param name="group">The group identifier.</param>
    [MethodImpl]
    public extern LoggingChannelOptions(Guid group);

    /// <summary>Gets or sets the channel group identifier.</summary>
    /// <returns>The group identifier.</returns>
    public extern Guid Group { [MethodImpl] get; [MethodImpl] set; }
  }
}
