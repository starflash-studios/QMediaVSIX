// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingOpcode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Specifies an event opcode. Opcodes represent an operation within a component of an application and are used to logically group events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum LoggingOpcode
  {
    /// <summary>An informational event.</summary>
    Info = 0,
    /// <summary>An event that represents the start of an activity.</summary>
    Start = 1,
    /// <summary>An event that represents the end of an activity. The event corresponds to the last unpaired **Start** event.</summary>
    Stop = 2,
    /// <summary>A reply event.</summary>
    Reply = 6,
    /// <summary>An event that represents an activity resuming after being suspended.</summary>
    Resume = 7,
    /// <summary>An event that represents the activity being suspended pending another activity's completion.</summary>
    Suspend = 8,
    /// <summary>An event that represents transferring activity to another component.</summary>
    Send = 9,
  }
}
