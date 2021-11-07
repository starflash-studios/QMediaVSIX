// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayManagerResultWithState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Contains the status of a DisplayManager operation, and a resulting DisplayState if the operation was successful.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DisplayManagerResultWithState : IDisplayManagerResultWithState
  {
    /// <summary>Gets a value indicating the success or error status of the operation.</summary>
    /// <returns>A DisplayManagerResult value.</returns>
    public extern DisplayManagerResult ErrorCode { [MethodImpl] get; }

    /// <summary>Gets an HRESULT value indicating how the operation succeeded or failed.</summary>
    /// <returns>An HRESULT value.</returns>
    public extern HResult ExtendedErrorCode { [MethodImpl] get; }

    /// <summary>Gets the DisplayState object that resulted from the operation, if successful.</summary>
    /// <returns>A DisplayState value.</returns>
    public extern DisplayState State { [MethodImpl] get; }
  }
}
