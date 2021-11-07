// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayStateOperationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Contains the status of a DisplayState operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class DisplayStateOperationResult : IDisplayStateOperationResult
  {
    /// <summary>Gets the status of the result.</summary>
    /// <returns>A DisplayStateOperationStatus value.</returns>
    public extern DisplayStateOperationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the extended error code of the result.</summary>
    /// <returns>An HResult value.</returns>
    public extern HResult ExtendedErrorCode { [MethodImpl] get; }
  }
}
