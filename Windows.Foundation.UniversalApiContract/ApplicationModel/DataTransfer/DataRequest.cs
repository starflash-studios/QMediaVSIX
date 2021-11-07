// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Lets your app supply the content the user wants to share or specify a message, if an error occurs.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DataRequest : IDataRequest
  {
    /// <summary>Sets or gets a DataPackage object that contains the content a user wants to share.</summary>
    /// <returns>Contains the content a user wants to share.</returns>
    public extern DataPackage Data { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the deadline for finishing a delayed rendering operation. If execution goes beyond that deadline, the results of delayed rendering are ignored.</summary>
    /// <returns>The deadline for the delayed rendering operation.</returns>
    public extern DateTime Deadline { [MethodImpl] get; }

    /// <summary>Cancels the sharing operation and supplies an error string to display to the user.</summary>
    /// <param name="value">The text to display to the user.</param>
    [MethodImpl]
    public extern void FailWithDisplayText(string value);

    /// <summary>Supports asynchronous sharing operations by creating and returning a DataRequestDeferral object.</summary>
    /// <returns>An object that allows you to share or send content asynchronously.</returns>
    [MethodImpl]
    public extern DataRequestDeferral GetDeferral();
  }
}
