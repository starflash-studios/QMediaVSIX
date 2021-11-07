// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Represents advanced event settings.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ILoggingOptionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LoggingOptions : ILoggingOptions
  {
    /// <summary>Initializes a new **LoggingOptions** instance with default option values.</summary>
    [MethodImpl]
    public extern LoggingOptions();

    /// <summary>Initializes a new **LoggingOptions** instance with the specified keyword value.</summary>
    /// <param name="keywords">The keyword value.</param>
    [MethodImpl]
    public extern LoggingOptions(long keywords);

    /// <summary>Gets or sets the keyword value that represents the different categories that an event belongs to.</summary>
    /// <returns>The keyword value.</returns>
    public extern long Keywords { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the user-defined metadata value attached to an event.</summary>
    /// <returns>The tag.</returns>
    public extern int Tags { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the user-defined value that identifies a larger unit of work within an application or component.</summary>
    /// <returns>The task value.</returns>
    public extern short Task { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the operation code value for an event.</summary>
    /// <returns>The operation code.</returns>
    public extern LoggingOpcode Opcode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the unique identifier associated with an activity.</summary>
    /// <returns>The activity unique identifier.</returns>
    public extern Guid ActivityId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that uniquely identifies the parent activity to which this activity is related.</summary>
    /// <returns>A value that uniquely identifies the parent activity to which this activity is related.</returns>
    public extern Guid RelatedActivityId { [MethodImpl] get; [MethodImpl] set; }
  }
}
